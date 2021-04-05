using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_de_hotele.forms
{
    public partial class Form_loding : Form
    {
        public Form_loding()
        {
            InitializeComponent();
        }
        int start_load = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            start_load += 1;
            progre_load.Value = start_load;
            porsontage.Text = start_load + "%";
            if (progre_load.Value == 100)
            {
                progre_load.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }

        }

        private void Form_loding_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(26, 26, 26);
            timer1.Start();
        }

        private void progre_load_Click(object sender, EventArgs e)
        {

        }

        private void porsontage_Click(object sender, EventArgs e)
        {

        }
    }
}
