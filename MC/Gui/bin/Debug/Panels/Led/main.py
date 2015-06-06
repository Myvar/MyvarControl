import System.Windows.Forms
import System.Drawing
import System

from System.Windows.Forms import *
from System.Drawing import *
from System import *

def Onclick(sender ,e):
	global state
	if state == 1:
		Arduino.SetPin(int(Properties["Pin"]),1);
		state = 0		
		Btn.Text = "ON"
		return
	if state == 0:
		Arduino.SetPin(int(Properties["Pin"]),0);
		state = 1
		Btn.Text = "OFF"
		return
state = int(Properties["Starting State"])
Onclick(0,0)
MainForm.Size = Size(Btn.Size.Width + 11, Btn.Size.Height + 11)
Btn.Click += Onclick