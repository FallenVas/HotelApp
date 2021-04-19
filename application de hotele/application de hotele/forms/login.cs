using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_de_hotele.forms
{
    public partial class login : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRecRgn")]
        //private static extern IntPtr CreateRoundRecRgn
        //    (
        //    int nLeft,
        //    int nTop,
        //    int nBottom,
        //    int nWidthEllipse,
        //    int nHeightEllipse

        //    );
        private HotelAppEntities db;
        //class connexion
        classe.Connextion C = new classe.Connextion();
        public login()
        {
            InitializeComponent();
            db = new HotelAppEntities();
        }
        
        string testvalidation()
        {
            if(box_name.Text =="" || box_name.Text =="User Name")
            {
                return "enter votre Nom";
            }
            if(BOX_pass.Text=="" || BOX_pass.Text=="Password")
            {
                return "enter votre pasword";
            }
            return null;
        }
        private void login_Load(object sender, EventArgs e)
        {
        }

        private void box_name_Enter(object sender, EventArgs e)
        {
            if (box_name.Text == "User Name")
            {
                box_name.Text = "";
                box_name.ForeColor = Color.Black;//pour changer couleur de text
            }
        }

        private void BTN_FRM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void box_name_Leave(object sender, EventArgs e)
        {

            if (box_name.Text == "")
            {
                box_name.Text = "User Name";
                box_name.ForeColor = Color.Gray;//pour changer couleur de text
            }
        }

        private void BOX_pass_Leave(object sender, EventArgs e)
        {
            if(BOX_pass.Text=="")
            {
                BOX_pass.Text = "Password";
                BOX_pass.ForeColor = Color.Gray;
                BOX_pass.UseSystemPasswordChar = true;
            }
        }

        private void BOX_pass_Enter(object sender, EventArgs e)
        {
            if(BOX_pass.Text== "Password")
            {
                BOX_pass.Text = "";
                BOX_pass.UseSystemPasswordChar = false;
                BOX_pass.PasswordChar = '*';
                BOX_pass.ForeColor = Color.Black;
            }
        }

        private void BTN_COX_Click(object sender, EventArgs e)
        {
            if(testvalidation()==null)
            {

                if (C.connextionvalide(db, box_name.Text, BOX_pass.Text) == true)
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Menu_pr menu = new Menu_pr();
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion a echoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(testvalidation(), "obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
