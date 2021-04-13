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
    public partial class Rooms : Form
    {
        string cnxStr = "Server=3elhotel.database.windows.net;Database=fakeData;User Id=nightzokssa;Password=Darkzokssa1;";
        public Rooms()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(HeaderPanel);
            bunifuFormDock1.SubscribeControlToDragEvents(titleLbl);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Rooms_Load(object sender, EventArgs e)
        {
            using(SqlConnection cn = new SqlConnection(cnxStr))
            {
                SqlCommand command = new SqlCommand("select * from room", cn);
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GridData.Rows.Add(new object[]
                    {
                        imageList1.Images[0],
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetDecimal(2),
                    }) ;
                }
            }
        }
        private Image checkIfNull(int idClient)
        {
            if(idClient == null || idClient == 0)
            {
              return  imageList1.Images[2];
            }
            else
            {
               return imageList1.Images[1];
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
        Thread th;
        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
