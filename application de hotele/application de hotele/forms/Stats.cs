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
        RapportEntities2 context = new RapportEntities2();
        
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
            double total2 = 0;
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
                    SqlCommand command2 = new SqlCommand("deletedCustomersIncomePerMonth", cn);
                    command2.CommandType = CommandType.StoredProcedure;
                    command2.Parameters.AddWithValue("@counter", counter);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    DataTable table2 = new DataTable();
                    table2.Load(reader2);
                    double def2 = 0;
                    double def = 0;
                    bool success=double.TryParse(table.Rows[0][0].ToString(), out def);
                    bool success2 = double.TryParse(table2.Rows[0][0].ToString(), out def2);
                    double total = def + def2;
                  
                    var products = context.products.Sum(p => p.price);
                    total = total - (double)products;
                    total2 += total;
                    incomeLineChart.Data.Add(total);
                }
            }
            incomeLbl.Text = total2.ToString();
        }
        private void getCustomersData()
        {
            double total2 = 0;
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
                    SqlCommand command2 = new SqlCommand("deletedCustomersPerMonth", cn);
                    command2.CommandType = CommandType.StoredProcedure;
                    command2.Parameters.AddWithValue("@counter", counter);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    DataTable table2 = new DataTable();
                    table2.Load(reader2);
                    double def2 = 0;
                    double def = 0;
                    bool success2 = double.TryParse(table2.Rows[0][0].ToString(), out def2);
                    bool success = double.TryParse(table.Rows[0][0].ToString(), out def);
                    double total = def + def2;
                    total2 += total;
                    customerLineChart.Data.Add(total);
                }
            }
            customerLbl.Text = total2.ToString();
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
