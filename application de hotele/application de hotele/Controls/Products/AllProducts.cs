using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_de_hotele.Controls.Products
{
    public partial class AllProducts : UserControl
    {
        RapportEntities2 context = new RapportEntities2();
        public AllProducts()
        {
            InitializeComponent();
        }
        private void getData()
        {
            
                List<product> products = context.products.ToList<product>();
                foreach (product item in products)
                {
                    GridData.Rows.Add(
                            imageList1.Images[0],
                            item.id,
                            item.reference,
                            item.price,
                            item.quantity,
                            checkQuantityAction((int)item.quantity),
                            item.fournisseur.nomFournisseur

                          );
                }
            
        }
        int filter = 0;
        private void search()
        {
            GridData.Rows.Clear();
            
                List<product> products;
                switch (filter)
                {
                    
                    case 1:  products = context.products.Where(pro => pro.reference.Contains(searchTxt.Text) && pro.quantity > 50).Select(pro => pro).ToList<product>(); break;
                    case 2:  products = context.products.Where(pro => pro.reference.Contains(searchTxt.Text) && pro.quantity >= 1 && pro.quantity <= 50).Select(pro => pro).ToList<product>(); break;
                    case 3:  products = context.products.Where(pro => pro.reference.Contains(searchTxt.Text) && pro.quantity == 0).Select(pro => pro).ToList<product>();  break;
                    default: products = context.products.Where(pro => pro.reference.Contains(searchTxt.Text)).Select(pro => pro).ToList<product>(); break;

                }
                
                foreach (product item in products)
                {
                    GridData.Rows.Add(
                            imageList1.Images[0],
                            item.id,
                            item.reference,
                            item.price,
                            item.quantity,
                            checkQuantityAction((int)item.quantity),
                            item.fournisseur.nomFournisseur

                          );
                }
            
        }

            
        
        private Image checkQuantityAction(int quantity)
        {
            if (quantity > 50)
            {
                return imageList1.Images[1];
            }
            else if (quantity > 1)
            {
                return imageList1.Images[3];
            }
            else
            {
                return imageList1.Images[2];
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
            search();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            filter = 0;
            search();
        }

        private void checkedBtn_Click(object sender, EventArgs e)
        {
            filter = 1;
            search();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            filter = 2;
            search();
        }

        private void notCheckedIn_Click(object sender, EventArgs e)
        {
            filter = 3;
            search();
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
