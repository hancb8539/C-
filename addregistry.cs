using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paths = new string[] { "C:\\Program Files\\Adobe\\Acrobat 5.0\\Reader\\", "C:\\Program Files\\OpenOffice 4\\", "C:\\Program Files\\McAfee\\", "C:\\Documents and Settings\\Administrator\\桌面\\NEWSID.exe" };
            foreach (string i in paths) {
                RegistryKey _regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0", true);
                _regKey = _regKey.OpenSubKey("Paths", true);
                _regKey = _regKey.CreateSubKey("{" + Guid.NewGuid() + "}");
                _regKey.SetValue("ItemData", i, RegistryValueKind.String);
                _regKey.SetValue("SaferFlags", 0, RegistryValueKind.DWord);
            }
        }
    }
}
