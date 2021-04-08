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

namespace application_de_hotele.forms
{
    
    public partial class Menu_pr : Form
    {
        int startLoad = 0;
        public Menu_pr()
        {
            InitializeComponent();
        }

        private void Menu_pr_Load(object sender, EventArgs e)
        {

        }

        private void clntButton_MouseEnter(object sender, EventArgs e)
        {
            
            clntButton.BackColor = Color.FromArgb(255, 182, 6);
        }

        private void roomButton_MouseEnter(object sender, EventArgs e)
        {
            roomButton.BackColor = Color.FromArgb(255, 182, 6);
        }
        private void clntButton_MouseLeave(object sender, EventArgs e)
        {

            clntButton.BackColor = Color.Transparent;
        }

        private void roomButton_MouseLeave(object sender, EventArgs e)
        {
            roomButton.BackColor = Color.Transparent;
        }
        private void rptButton_MouseEnter(object sender, EventArgs e)
        {
            rptButton.BackColor = Color.FromArgb(255, 182, 6);
        }

        private void rptButton_MouseLeave(object sender, EventArgs e)
        {
            rptButton.BackColor = Color.Transparent;
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
    }
}
