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
namespace application_de_hotele.Controls
{
    public partial class UpdateControl : UserControl
    {
        string cnxStr = "server=eldb.cfev9d8jukdt.us-east-2.rds.amazonaws.com,1433; Database=HotelApp;User Id=admin;Password=Nightzokssa1;";
        public UpdateControl()
        {
            InitializeComponent();
            
        }
        private void getData()
        {
            
            using (SqlConnection cn = new SqlConnection(cnxStr))
            {
                cn.Open();
                SqlCommand command = new SqlCommand();
                if (searchTxt.Text.Trim().Length > 0)
                {
                    
                    command.Connection = cn;
                    command.CommandText = "SearchID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", searchTxt.Text.Trim());
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable data = new DataTable();
                    data.Load(reader);
                    if (data.Rows.Count != 0)
                    {
                        bunifuPanel2.Visible = true;
                        bunifuPanel3.Visible = true;
                        idTxt.Text = searchTxt.Text;
                        nomTxt.Text = data.Rows[0][1].ToString();
                        prenomTxt.Text = data.Rows[0][2].ToString();
                        cinTxt.Text = data.Rows[0][3].ToString();
                        dateDebut.Value = DateTime.Parse(data.Rows[0][4].ToString());
                        dateFin.Value = DateTime.Parse(data.Rows[0][5].ToString());
                        if (data.Rows[0][6].ToString() == "True")
                        {
                            CheckedIn.Checked = true;
                        }
                        else
                        {
                            CheckedIn.Checked = false;
                        }
                        roomNumber.Text = data.Rows[0][7].ToString();
                    }
                    else
                    {
                        Error error = new Error();
                        error.Show();
                        error.Focus();
                    }
                }
                

            }
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            getData();
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
                string query = "update  client set nomClient=@nomClient, prenomClient=@prenomClient, cinClient=@cinClient, dateDebut=@dateDebut, dateFin=@dateFin, checkedIn=@checkedIn where idClient = @idClient";
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@idClient", int.Parse(idTxt.Text));
                command.Parameters.AddWithValue("@nomClient", nomTxt.Text);
                command.Parameters.AddWithValue("@prenomClient", prenomTxt.Text);
                command.Parameters.AddWithValue("@cinClient", cinTxt.Text);
                command.Parameters.AddWithValue("@dateDebut", dateDebut.Value);
                command.Parameters.AddWithValue("@dateFin", dateFin.Value);
                command.Parameters.AddWithValue("@checkedIn", getCheckedIn());
                command.ExecuteNonQuery();
                MessageBox.Show("Client Has Updated Successfully");
            }
        }
        private void validateData()
        {
            if (nomTxt.Text == "" || prenomTxt.Text == "" || cinTxt.Text == "")
            {
                MessageBox.Show("Fill in the informations please");
                return;
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
    }
}
