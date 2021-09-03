using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TesteMouse
{
    public partial class Form1 : Form
    {
        public Boolean rodando = false;

        private void MoveCursor()
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            Random r = new Random();
            int rw = r.Next(0, resolution.Width / 2); //for ints
            int rh = r.Next(0, resolution.Height / 2);

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(resolution.Width - rw, resolution.Height - rh);
           // Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        public Form1()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop")
            {
                button1.Text = "Start";
                timer1.Enabled = false;
            }
            else
            {
                button1.Text = "Stop";
                timer1.Interval = Convert.ToInt32(textBox1.Text);
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            MoveCursor();
        }
    }
}
