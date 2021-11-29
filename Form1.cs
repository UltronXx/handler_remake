using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HMS
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        Form2 form2 = new Form2();
        DialogResult result;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.progressBar.Visible = true;
            this.processReaderLabel.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(5);

            if (progressBar.Value == 10)
            {
                processReaderLabel.Text = "Initializing setup....";
            }
            else if (progressBar.Value == 20)
            {
                processReaderLabel.Text = "Rendering graphics and interface....";
            }
            else if (progressBar.Value == 80)
            {
                processReaderLabel.Text = "Launching Handler database....";
            }
            else if (progressBar.Value == 100)
            {
                this.timer1.Stop();
                this.progressBar.Visible = false;
                this.processReaderLabel.Visible = false;
                
                this.Hide();

                form2.ShowDialog();
            }
        }
    }
}
