/*
 * Programmer:          Corey Jenkins
 * Date:                February 15, 2021
 * Program Name:        Latte Selection
 * Purpose:             To create a GUI in C# that allows you to select either Pumpkin Spice or Mocha and a button
 *                      to select.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latte_Selection
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
            Application.Run(new frmLatteSelection());
        }
    }
}
