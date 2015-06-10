import System.Windows.Forms
import System.Drawing
import System

from System.Windows.Forms import *
from System.Drawing import *
from System import *
#Arduino.SetPin(int(Properties["Pin"]),1);
def Change(sender ,e):
	Arduino.AnalogSetPin(int(Properties["Pin"]),Slider.Value);

MainForm.Size = Size(Slider.Size.Width + 11, Slider.Size.Height + 11)
Slider.Maximum = 255
Slider.ValueChanged += Change