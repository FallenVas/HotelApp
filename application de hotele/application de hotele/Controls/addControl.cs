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
using application_de_hotele.forms;

namespace application_de_hotele
{
    public partial class addControl : UserControl
    {
        string cnxStr = "Server=3elhotel.database.windows.net;Database=fakeData;User Id=nightzokssa;Password=Darkzokssa1;";
        public addControl()
        {
            InitializeComponent();
            getAvailableRooms();
            idTxt.Text = getNextId();
        }
        private void getAvailableRooms()
        {
            using(SqlConnection cn = new SqlConnection(cnxStr))
            {
                DateTime date = DateTime.Now;
                
                cn.Open();
                SqlCommand command = new SqlCommand("select idRoom, typeRoom from room  left join client on roomNumber = idRoom where idClient is null", cn);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                roomCombo.DataSource = dt;
                roomCombo.DisplayMember = "idRoom";
                roomCombo.ValueMember = "idRoom";
                idTxt.Text = "";
                nomTxt.Text = "";
                prenomTxt.Text = "";
                cinTxt.Text = "";
                dateDebut.Value = date.Date;
                dateFin.Value = date.Date;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nomTxt.Text == "" || prenomTxt.Text == "" || cinTxt.Text == "")
            {
                MessageBox.Show("Fill in the informations please");
                return;
            }
            using (SqlConnection cn = new SqlConnection(cnxStr))
            {
                cn.Open();
                string query = "insert into client (idClient, nomClient, prenomClient, cinClient, dateDebut, dateFin, checkedIn, roomNumber) values (@idClient,@nomClient,@prenomClient,@cinClient,@dateDebut,@dateFin,@checkedIn,@roomNumber)";
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@idClient", int.Parse(idTxt.Text));
                command.Parameters.AddWithValue("@nomClient", nomTxt.Text);
                command.Parameters.AddWithValue("@prenomClient", prenomTxt.Text);
                command.Parameters.AddWithValue("@cinClient", cinTxt.Text);
                command.Parameters.AddWithValue("@dateDebut", dateDebut.Value);
                command.Parameters.AddWithValue("@dateFin", dateFin.Value);
                command.Parameters.AddWithValue("@checkedIn", getCheckedIn());
                command.Parameters.AddWithValue("@roomNumber", roomCombo.SelectedValue);
                command.ExecuteNonQuery();
                AnotherOne anotherOne = new AnotherOne();
                anotherOne.Show();
                anotherOne.Focus();
                getAvailableRooms();
            }
        }

        private int getCheckedIn()
        {
            if (CheckedIn.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private string getNextId()
        {
            using (SqlConnection cn = new SqlConnection(cnxStr))
            {
                SqlCommand command = new SqlCommand("select * from client", cn);
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                string id = (int.Parse(table.Rows[table.Rows.Count - 1][0].ToString()) + 1).ToString();
                return id;
            }
        }
    }
}
