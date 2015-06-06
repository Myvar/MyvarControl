import System.Windows.Forms
import System.Drawing
import System

from System.Windows.Forms import *
from System.Drawing import *
from System import *

def Onclick(sender ,e):
	Lbl.Text = str(Properties["Text"])

Onclick(0,0)
MainForm.Size = Size(Lbl.Size.Width + 11, Lbl.Size.Height + 11)
Lbl.Click += Onclick
Lbl.Text = str(Properties["Text"])