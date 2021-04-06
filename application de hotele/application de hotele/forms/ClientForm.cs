using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace application_de_hotele.forms
{
    public partial class ClientForm : Form
    {
        
        public ClientForm()
        {
            InitializeComponent();
        }
        private Thread th;
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            void threading()
            {
                Application.Run(new Menu_pr());
            }   
            th = new Thread(threading);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }



        private void ClientForm_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            DataSet ds = new DataSet();
            string cnxStr = "Server=3elhotel.database.windows.net;Database=hotel_db;User Id=nightzokssa;Password=Darkzokssa1;";
            SqlConnection connection = new SqlConnection(cnxStr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select fullName_client,paymentValidation_client,checkInDate_client,checkOutDate_client from client", connection);
            dataAdapter.Fill(ds, "Client");
            ClientDataGrid.DataSource = ds.Tables["Client"];
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            ClientDataGrid.Visible = true;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            ClientDataGrid.Visible = false;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            ClientDataGrid.Visible = false;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            ClientDataGrid.Visible = false;
        }

        private void bunifuShadowPanel1_MouseUp(object sender, MouseEventArgs e)
        {

        }


    }
}
