﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;

namespace ArduinoCore
{
    public class Arduino
    {
        private SerialPort _Port; 
        public Arduino(string com)
        {
            _Port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
        }

        public void AnalogSetPin(int pin, int value)
        {
            _Port.Open();
            var x = (pin * 2) + 14;
            _Port.Write(new byte[] { (byte)x }, 0, 1);
            _Port.Write(new byte[] { (byte)value }, 0, 1);
            Debug.WriteLine(_Port.ReadByte());
            _Port.Close();
        }

        public void SetPin(int pin, int value)
        {
            _Port.Open();
            var x = (pin * (value + 1));
            _Port.Write(new byte[] {(byte)x}, 0, 1);
            Debug.WriteLine(_Port.ReadByte());
            _Port.Close();
        }
    }
}
