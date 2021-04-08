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
namespace application_de_hotele
{
    public partial class UserControl1 : UserControl
    {
        string cnxStr = "Server=3elhotel.database.windows.net;Database=fakeData;User Id=nightzokssa;Password=Darkzokssa1;";
        public UserControl1()
        {
            InitializeComponent();
            getData();
        }
        private int filter = 2;
        private void getData()
        {
            using(SqlConnection cn = new SqlConnection(cnxStr))
            {
                SqlCommand command = new SqlCommand("select * from client", cn);
                if(searchTxt.Text.Trim().Length > 0)
                {
                    command.CommandText = "Search";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@search", searchTxt.Text.Trim());
                }
                if(filter == 0)
                {
                    searchTxt.Text = "";
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from client where checkedIn = 0";
                }
                if(filter == 1)
                {
                    searchTxt.Text = "";
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from client where checkedIn = 1";
                }
                cn.Open();
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
        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                GridData.FirstDisplayedScrollingRowIndex = GridData.Rows[e.Value].Index;
            }
            catch (Exception) { }

        }

        private void GridData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = GridData.RowCount;

            }
            catch (Exception) { }

        }

        private void GridData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = GridData.RowCount;

            }
            catch (Exception) { }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            GridData.Rows.Clear();
            getData();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            GridData.Rows.Clear();
            this.filter = 2;
            getData();
        }

        private void checkedBtn_Click(object sender, EventArgs e)
        {
            GridData.Rows.Clear();
            this.filter = 1;
            getData();
        }

        private void notCheckedIn_Click(object sender, EventArgs e)
        {
            GridData.Rows.Clear();
            this.filter = 0;
            getData();
        }
    }
}
