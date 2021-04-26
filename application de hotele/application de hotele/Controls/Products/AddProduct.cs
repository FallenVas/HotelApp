using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_de_hotele.Controls
{
    public partial class AddProduct : UserControl
    {
        RapportEntities2 context = new RapportEntities2();
        public AddProduct()
        {
            InitializeComponent();
            idTxt.Text = getNextId();
            getFournisseur();
        }
        private string getNextId()
        {
            List<product> products = context.products.ToList<product>();
            return (products.Count + 1).ToString();
        }
        private void getFournisseur()
        {
            var fournisseurs = context.fournisseurs.Select(f => new {f.idFournisseur , f.nomFournisseur } ).ToList();
            roomCombo.DataSource = fournisseurs;
            roomCombo.DisplayMember = "nomFournisseur";
            roomCombo.ValueMember = "idFournisseur";

        }
        private void addProduct()
        {
            product pro = new product();
            pro.id = int.Parse(idTxt.Text);
            pro.reference = nomTxt.Text;
            pro.quantity = (int)quantity.Value;
            pro.price = (decimal)price.Value;
            pro.idFournisseur = (int)roomCombo.SelectedValue;
            context.products.Add(pro);
            context.SaveChanges();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addProduct();
            AnotherOne anotherOne = new AnotherOne();
            anotherOne.Show();
            anotherOne.Focus();
            idTxt.Text = "";
            nomTxt.Text = "";
            quantity.Value = 0;
            price.Value = (decimal)0.00;
        }
    }
}
