/*
 
Names: Joachim Isaac, Olanrewaju Elijah Ayedun  
Date:09/28/2020

Course: CMPS4143, Fall 2020, Dr. Stringfellow.


Purpose: To implement a GUI of the game who wants to be a millioniare.

 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WhoWantsToBeAMillionaire
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
            Infile f = new Infile();
            Application.Run(f);



            



        }
    }
}


