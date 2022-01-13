#############################################
#Libraries

import socket
import os
import vlc
import sys
import Adafruit_DHT
import RPi.GPIO as GPIO
import smbus
import time
from gtts import gTTS

##############################################
#Host, Port and Socket Preparation

HOST = '192.168.1.124'  # Server IP or Hostname
PORT = 1234 		# Pick an open Port
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
print("Socket created")

###############################################
#Sensor and Pin Decleration
###############################################
# 3 Differnent Voltage Source Pin Decleration
Low_Voltage   = 12
Med_Voltage   = 21
High_Voltage = 16

###############################################
#DHT11 (Temprature Sensor)
DHT_SENSOR = Adafruit_DHT.DHT11
DHT_PIN = 4

#HCSR04 (Serum Sensor)
TRIG = 23
ECHO = 24

#Heater
Heater = 1

#Fan
Fan = 20

#Light
Light = 26

#Serum
SerumFill  = 15
SerumDrain = 18

###############################################
#Connection and Data Communication

while 1:
	try:
		s.bind((HOST, PORT))
	except socket.error:
		print("Bind failed")
	s.listen(5)
	print("Socket awaiting messages")
	conn, addr = s.accept()
	print("Connected")

	# awaiting for message
	data0 = conn.recv(1024)
	data = data0.decode('UTF-8')
	print("Received: %s" % data)
	isDataSpeach = data[:3]

##############################################
#DH11 (Temprature)

	if data == "temp":

		humidity, temprature = Adafruit_DHT.read(DHT_SENSOR, DHT_PIN)
		if humidity is not  None and temprature is not None:
			print("Temp = {0:0.1f} C , Humidity = {1:0.1f}%".format(temprature,humidity))
		else:
			print("Error....Chechk DHT11 Wiring")
		temprature = str(temprature)
		tempratureReply = bytes(temprature,'UTF-8')
		conn.send(tempratureReply)

##############################################
#HCSR-04 (Serum Sensor)

	elif data == "serum":

		GPIO.setmode(GPIO.BCM)
		GPIO.setup(TRIG, GPIO.OUT)
		GPIO.setup(ECHO, GPIO.IN)

		GPIO.output(TRIG, False)
		time.sleep(2)

		GPIO.output(TRIG, True)
		time.sleep(0.00001)
		GPIO.output(TRIG, False)

		while GPIO.input(ECHO) == 0:
			pulse_start = time.time()
		while GPIO.input(ECHO) == 1:
			pulse_end = time.time()

		pulse_duration = pulse_end - pulse_start
		distance = pulse_end - pulse_start
		distance = pulse_duration * 17150
		distance = round(distance, 2)

		print("Distance: ",distance, " cm")

		distance = str(distance)
		distanceReply = bytes(distance, 'UTF-8')
		conn.send(distanceReply)

###############################################
#BH1790 (Light Sensor)

	elif data == "light":

		DEVICE = 0x23
		POWER_DOWN = 0x00
		POWER_ON = 0x01
		RESET = 0x07

		cont_lw_res_md = 0x13
		cont_hg_res_md1 = 0x10
		cont_hg_res_md2 = 0x11
		one_time_hg_res_md1 = 0x20
		one_time_hg_res_md2 = 0x21
		one_time_lw_res_md =0x23

		bus = smbus.SMBus(1)

		def convertToNumber(data):
			result=(data[1] + (256 * data[0])) / 1.2
			return (result)

		def readLight(addr=DEVICE):
			data = bus.read_i2c_block_data(addr,one_time_hg_res_md1)
			return convertToNumber(data)

		lightLevel = readLight()

		lightReply = str(lightLevel)
		lightReply = bytes(lightReply, 'UTF-8')
		conn.send(lightReply)

#################################################
#Serum Fill

	elif data == "SerumFill":

		GPIO.setmode(GPIO.BCM)
		GPIO.setup(SerumFill, GPIO.OUT)

		GPIO.output(SerumFill, False)

		fillReply = "Serum Filling"
		fillReply = bytes(fillReply, 'UTF-8')
		conn.send(fillReply)

	elif data == "SerumPour":

		GPIO.setmode(GPIO.BCM)
		GPIO.setup(SerumDrain, GPIO.OUT)

		GPIO.output(SerumDrain, False)

		DrainReply = "Serum Draining"
		DrainReply = bytes(DrainReply, 'UTF-8')
		conn.send(DrainReply)

	elif data == "SerumStop":

		GPIO.setmode(GPIO.BCM)
		GPIO.setup(SerumFill, GPIO.OUT)
		GPIO.setup(SerumDrain, GPIO.OUT)

		GPIO.output(SerumFill, True)
		GPIO.output(SerumDrain, True)
		GPIO.cleanup()

		SerumStopResp = "Serum Motors Stoped"
		SerumStopResp = bytes(SerumStopResp, 'UTF-8')
		conn.send(SerumStopResp)


###############################################
#Heater

	elif data == "heatON":

		GPIO.setmode(GPIO.BCM)
		GPIO.setup(Med_Voltage, GPIO.OUT)
		GPIO.setup(Heater, GPIO.OUT)

		GPIO.output(Heater, False)
		GPIO.output(Med_Voltage, False)

		heaterReply = "heater working"
		heaterReply = bytes(heaterReply, 'UTF-8')
		conn.send(heaterReply)

	elif data == "heatOFF":
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(Med_Voltage, GPIO.OUT)
		GPIO.setup(Heater, GPIO.OUT)

		GPIO.output(Heater, True)
		GPIO.output(Med_Voltage, True)

		heaterReply = "heater shuted down"
		heaterReply = bytes(heaterReply, 'UTF-8')
		conn.send(heaterReply)

###############################################
#Light

	elif data == "LightOff":
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(Light, GPIO.OUT)
		GPIO.setup(Low_Voltage, GPIO.OUT)
		GPIO.setup(Med_Voltage, GPIO.OUT)
		GPIO.setup(High_Voltage, GPIO.OUT)

		GPIO.output(Light, True)
		GPIO.output(Low_Voltage, True)
		GPIO.output(Med_Voltage, True)
		GPIO.output(High_Voltage, True)

		light0Reply = "lightOff"
		light0Reply = bytes(light0Reply, 'UTF-8')
		conn.send(light0Reply)

	elif data == "LightLow":
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(High_Voltage, GPIO.OUT)
		GPIO.setup(Med_Voltage, GPIO.OUT)
		GPIO.output(High_Voltage, True)
		GPIO.output(Med_Voltage, True)
		GPIO.setup(Light, GPIO.OUT)
		GPIO.setup(Low_Voltage, GPIO.OUT)

		GPIO.output(Light, False)
		GPIO.output(Low_Voltage, False)

		light0Reply = "lightLow"
		light0Reply = bytes(light0Reply, 'UTF-8')
		conn.send(light0Reply)

	elif data == "LightMed":
		GPIO.output(High_Voltage, True)
		GPIO.output(Low_Voltage, True)
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(Light, GPIO.OUT)
		GPIO.setup(Med_Voltage, GPIO.OUT)

		GPIO.output(Light, False)
		GPIO.output(Med_Voltage, False)

		light0Reply = "lightMedium"
		light0Reply = bytes(light0Reply, 'UTF-8')
		conn.send(light0Reply)

	elif data == "LightHigh":
		GPIO.output(Med_Voltage, True)
		GPIO.output(Low_Voltage, True)
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(Light, GPIO.OUT)
		GPIO.setup(High_Voltage, GPIO.OUT)

		GPIO.output(Light, False)
		GPIO.output(High_Voltage, False)

		light0Reply = "lightHigh"
		light0Reply = bytes(light0Reply, 'UTF-8')
		conn.send(light0Reply)

##############################################
#Fan

	elif data == "FanLow":
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(Low_Voltage, GPIO.OUT)
		GPIO.setup(Med_Voltage, GPIO.OUT)
		GPIO.setup(High_Voltage, GPIO.OUT)
		GPIO.setup(Fan, GPIO.OUT)

		GPIO.output(Med_Voltage, True)
		GPIO.output(High_Voltage, True)

		GPIO.output(Fan, False)
		GPIO.output(Low_Voltage, False)

		fan0Reply = "Fan Low"
		fan0Reply = bytes(fan0Reply, 'UTF-8')
		conn.send(fan0Reply)

	elif data == "FanMed":
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(Low_Voltage, GPIO.OUT)
		GPIO.setup(Med_Voltage, GPIO.OUT)
		GPIO.setup(High_Voltage, GPIO.OUT)
		GPIO.setup(Fan, GPIO.OUT)

		GPIO.output(High_Voltage, True)
		GPIO.output(Low_Voltage, True)

		GPIO.output(Fan, False)
		GPIO.output(Med_Voltage, False)

		fan0Reply = "Fan Medium"
		fan0Reply = bytes(fan0Reply, 'UTF-8')
		conn.send(fan0Reply)

	elif data == "FanHigh":

		GPIO.setmode(GPIO.BCM)
		GPIO.setup(High_Voltage, GPIO.OUT)
		GPIO.setup(Med_Voltage, GPIO.OUT)
		GPIO.setup(Low_Voltage, GPIO.OUT)
		GPIO.setup(Fan, GPIO.OUT)

		GPIO.output(Low_Voltage, True)
		GPIO.output(Med_Voltage, True)

		GPIO.output(Fan, False)
		GPIO.output(High_Voltage, False)

		fan0Reply = "Fan High"
		fan0Reply = bytes(fan0Reply, 'UTF-8')
		conn.send(fan0Reply)

	elif data == "FanOff":
		GPIO.setup(Fan, GPIO.OUT)
		GPIO.output(Fan, True)
		GPIO.output(Low_Voltage, True)
		GPIO.output(Med_Voltage, True)
		GPIO.output(High_Voltage, True)

		fan0Reply =  "Fan Off"
		fan0Reply = bytes(fan0Reply, 'UTF-8')
		conn.send(fan0Reply)

################################################
#Speach

	elif isDataSpeach == "SPC":
		speach = data[3:]
		language = 'tr'
		output =gTTS(text = speach, lang = language, slow = False)
		output.save("speach.mp3")
		p=vlc.MediaPlayer("speach.mp3")
		p.play()
		conn.send(bytes('Done','UTF-8'))


