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
    public partial class UpdateProduct : UserControl
    {
        product pro;
        RapportEntities2 context = new RapportEntities2();
        public UpdateProduct()
        {
            InitializeComponent();
        }
        private void getData()
        {
            getFournisseur();
            int id = int.Parse(searchTxt.Text);
            bunifuPanel2.Visible = true;
            bunifuPanel3.Visible = true;
            pro = context.products.Where(p => p.id == id).FirstOrDefault();
            idTxt.Text = searchTxt.Text;
            nomTxt.Text = pro.reference;
            quantity.Value = (int)pro.quantity;
            price.Value = (decimal)pro.price;
            roomCombo.SelectedValue = pro.idFournisseur;
        }
        private void getFournisseur()
        {
            var fournisseurs = context.fournisseurs.Select( f => new {f.idFournisseur , f.nomFournisseur }).ToList();
            roomCombo.DataSource = fournisseurs;
            roomCombo.DisplayMember = "nomFournisseur";
            roomCombo.ValueMember = "idFournisseur";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                getData();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            pro.reference = nomTxt.Text;
            pro.quantity = (int)quantity.Value;
            pro.price = price.Value;
            pro.idFournisseur = (int)roomCombo.SelectedValue;
            context.SaveChanges();
            Power power = new Power();
            power.Show();
            power.Focus();
        }
    }
}
