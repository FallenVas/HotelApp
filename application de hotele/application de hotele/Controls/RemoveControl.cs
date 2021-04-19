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
    public partial class RemoveControl : UserControl
    {
        string cnxStr = "server=eldb.cfev9d8jukdt.us-east-2.rds.amazonaws.com,1433; Database=HotelApp;User Id=admin;Password=Nightzokssa1;";
        public RemoveControl()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            GridData.Rows.Clear();
            getData();
        }

        private void getData()
        {
            using (SqlConnection cn = new SqlConnection(cnxStr))
            {
                if (searchTxt.Text == "")
                {
                    return;
                }
                cn.Open();
                SqlCommand command = new SqlCommand();
                if (searchTxt.Text.Trim().Length > 0)
                {
                    command.Connection = cn;
                    command.CommandText = "SearchID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", searchTxt.Text.Trim());
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GridData.Rows.Add(new object[]
                    {
                        imageList1.Images[0],
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetBoolean(6)? imageList1.Images[1] : imageList1.Images[2],
                        reader.GetInt32(7)
                    });
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                return;
            }
            if (GridData.Rows.Count == 0)
            {
                return;
            }
            using (SqlConnection cn = new SqlConnection(cnxStr))
            {
                cn.Open();
                SqlCommand command = new SqlCommand();
                
                    command.Connection = cn;
                    command.CommandText = "removeClient";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", searchTxt.Text.Trim());
                    command.ExecuteNonQuery();
                    GridData.Rows.Clear();
                    searchTxt.Text = "";
                    MessageBox.Show("Client Has Been Deleted");
            }
        }
    }
}
