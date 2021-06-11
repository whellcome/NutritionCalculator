using NutritionCalculator.Forms;
using System;
using System.Windows.Forms;

namespace NutritionCalculator
{
    static class Program
    {
        /// <summary>
        /// Main point of enter.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
