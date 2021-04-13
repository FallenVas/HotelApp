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
using application_de_hotele.Controls;

namespace application_de_hotele.forms
{
    public partial class MainHub : Form
    {
        
        public MainHub()
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
            UserControl1 control = new UserControl1();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            mainAreaPanel.Controls.Clear();
            addControl control = new addControl();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            mainAreaPanel.Controls.Clear();
            RemoveControl control = new RemoveControl();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            mainAreaPanel.Controls.Clear();
            UpdateControl control = new UpdateControl();
            control.Dock = DockStyle.Fill;
            mainAreaPanel.Controls.Add(control);
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }
    }
}
