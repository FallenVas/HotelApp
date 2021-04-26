using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_de_hotele.forms
{
    public partial class Rapport : Form
    {
        public Rapport()
        {
            InitializeComponent();
        }




        private void clntButton_MouseEnter(object sender, EventArgs e)
        {

            statsBtn.BackColor = Color.FromArgb(255, 182, 6);
        }

        private void roomButton_MouseEnter(object sender, EventArgs e)
        {
            ProductsBtn.BackColor = Color.FromArgb(255, 182, 6);
        }
        private void clntButton_MouseLeave(object sender, EventArgs e)
        {

            statsBtn.BackColor = Color.Transparent;
        }

        private void roomButton_MouseLeave(object sender, EventArgs e)
        {
            ProductsBtn.BackColor = Color.Transparent;
        }
        private void rptButton_MouseEnter(object sender, EventArgs e)
        {
            FournisseurBtn.BackColor = Color.FromArgb(255, 182, 6);
        }

        private void rptButton_MouseLeave(object sender, EventArgs e)
        {
            FournisseurBtn.BackColor = Color.Transparent;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Thread th;
        private void clntButton_Click(object sender, EventArgs e)
        {
            void thread()
            {
                Application.Run(new MainHub());
            }
            th = new Thread(thread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            void thread()
            {
                Application.Run(new Rooms());
            }
            th = new Thread(thread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            void thread()
            {
                Application.Run(new Menu_pr());
            }
            th = new Thread(thread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Application.Exit();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            void thread()
            {
                Application.Run(new Stats());
            }
            th = new Thread(thread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            void thread()
            {
                Application.Run(new Product());
            }
            th = new Thread(thread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
    }
}
