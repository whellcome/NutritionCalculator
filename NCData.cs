using NutritionCalculator.Controllers;
using NutritionCalculator.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutritionCalculator
{
    public class NCEventArgs : EventArgs
    {
        public NCEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
    internal static class NCData
    {
        public static User CurrentUser { get; internal set; }
        public delegate void EventHandler<TSender, TArgs>(TSender sender, TArgs e) where TArgs : EventArgs;
        public static EventHandler<DataController,NCEventArgs> DataSaved;
        public static EventHandler<Form, NCEventArgs> DataSelected;
        public static Point GetNewFormPoint(Form form, int fWidth)
        {
            Point pt = new Point();
            var x = (Screen.PrimaryScreen.WorkingArea.Width - fWidth - form.Location.X - form.Width < 0) ?
                form.Location.X - fWidth : form.Location.X + form.Width;
            pt.X = x;
            pt.Y = form.Location.Y;
            return pt;
        }
    }
}
