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
    public partial class RemoveProduct : UserControl
    {
        RapportEntities2 context = new RapportEntities2();
        product pro;
        public RemoveProduct()
        {
            InitializeComponent();
        }
        private void searchID()
        {
            int id = int.Parse(searchTxt.Text);
            pro = context.products.Where(p => p.id == id).FirstOrDefault();
            if(pro != null)
            {
                GridData.Rows.Add(
                            imageList1.Images[0],
                            pro.id,
                            pro.reference,
                            pro.price,
                            pro.quantity,
                            checkQuantityAction((int)pro.quantity),
                            pro.fournisseur.nomFournisseur

                          );
            }
            else
            {
                Error error = new Error();
                error.Show();
                error.Focus();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                searchID();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(searchTxt.Text == "")
            {
                MessageBox.Show("Please fill in the id box");
            }
            else
            {
                context.products.Remove(pro);
                context.SaveChanges();
                Peace p = new Peace();
                p.Show();
                p.Focus();
                GridData.Rows.Clear();
            }
            
        }
    }
}
