/**
 * 
 * Aplicativo desenvolvido para controlar
 * servo motores com Arduino a partir de 
 * uma porta serial.
 * 
 * Autor: Renato Peterman
 * 
 * Data: 26/07/2010
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ArduinoServoControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JanelaPrincipal());
        }
    }
}
