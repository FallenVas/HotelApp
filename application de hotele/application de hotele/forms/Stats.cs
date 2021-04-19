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
    public partial class Stats : Form
    {
        string cnxStr = "server=eldb.cfev9d8jukdt.us-east-2.rds.amazonaws.com,1433; Database=HotelApp;User Id=admin;Password=Nightzokssa1;";
        public Stats()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(mainPanel);

            incomeLineChart.Data.Clear();
            getIncomeData();
            getCustomersData();
            getAvailableRooms();
            getCurrentUser();
        }
        private void getIncomeData()
        {
            using(SqlConnection cn = new SqlConnection(cnxStr))
            {
                SqlCommand command = new SqlCommand("select sum(priceRoom) from room inner join client on roomNumber = idRoom", cn);
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                incomeLbl.Text = table.Rows[0][0].ToString();
            }
            for(int counter = 1; counter < 13; counter++)
            {
                using (SqlConnection cn = new SqlConnection(cnxStr))
                {
                    SqlCommand command = new SqlCommand("IncomePerMonth", cn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@counter", counter);
                    cn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    double def = 0;
                    bool success=double.TryParse(table.Rows[0][0].ToString(), out def);
                    incomeLineChart.Data.Add(def);
                }
            }
        }
        private void getCustomersData()
        {
            using (SqlConnection cn = new SqlConnection(cnxStr))
            {
                SqlCommand command = new SqlCommand("select count(idClient) from room inner join client on roomNumber = idRoom", cn);
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                customerLbl.Text = table.Rows[0][0].ToString();
            }
            for (int counter = 1; counter < 13; counter++)
            {
                using (SqlConnection cn = new SqlConnection(cnxStr))
                {
                    SqlCommand command = new SqlCommand("CustomerPerMonth", cn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@counter", counter);
                    cn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    double def = 0;
                    bool success = double.TryParse(table.Rows[0][0].ToString(), out def);
                    customerLineChart.Data.Add(def);
                }
            }
        }
        private void getAvailableRooms()
        {
            using (SqlConnection cn = new SqlConnection(cnxStr))
            {
                SqlCommand command = new SqlCommand("select count(idRoom) from room left join client on idRoom = roomNumber where idClient is null", cn);
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                roomLbl.Text = table.Rows[0][0].ToString();
            }
        }
        private void getCurrentUser()
        {
            using(HotelAppEntities context = new HotelAppEntities())
            {
                List<user> users = context.users.ToList<user>();
                userLbl.Text = "Welcome Back " + users[0].username;
            }
        }
        Thread th;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            void thread()
            {
                Application.Run(new forms.Rapport());
            }
            th = new Thread(thread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
