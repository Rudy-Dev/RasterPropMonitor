using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RealWindows
{

    public class RealWindow
    {
        public RealWindow()
        {

            Form myform = new Form();
            Button mybutton = new Button()
            {
                Text = "Hello",
                Location = new System.Drawing.Point(10, 10)
            };
            mybutton.Click += (o, s) =>
            {
                MessageBox.Show("world");
            };

            myform.Controls.Add(mybutton);
            myform.ShowDialog();
        }
    }
}