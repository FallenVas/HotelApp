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
using application_de_hotele.Controls;
using application_de_hotele.Controls.Products;

namespace application_de_hotele.forms
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(HeaderPanel);
            bunifuFormDock1.SubscribeControlToDragEvents(titleLbl);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Thread th;
        private void backButton_Click(object sender, EventArgs e)
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
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            mainAreaPanel.Controls.Clear();
            AllProducts control = new AllProducts();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }


        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            mainAreaPanel.Controls.Clear();
            AddProduct control = new AddProduct();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            mainAreaPanel.Controls.Clear();
            RemoveProduct control = new RemoveProduct();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            mainAreaPanel.Controls.Clear();
            UpdateProduct control = new UpdateProduct();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }
    }
}
