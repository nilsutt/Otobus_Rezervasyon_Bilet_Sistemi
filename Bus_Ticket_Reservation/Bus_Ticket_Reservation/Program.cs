﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ticket_Reservation
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
            Application.Run(new Form1());
            Application.Run(new Personel_Giris());
            Application.Run(new Admin_Giris());
            Application.Run(new Yolcu_Giris());
            Application.Run(new Yolcu_Uye_Ol());
        }
    }
}
