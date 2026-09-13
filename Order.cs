using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Assignment_3._4;
namespace Assignment_3._4
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            cmbSize.DataSource = Enum.GetValues(typeof(Size));
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                var newCoffee = new Coffee();
                newCoffee.Name = txtName.Text;
                //newCoffee.BevNum = Convert.ToInt32(txtBevNum.Text);
                //newCoffee.Quantity = Convert.ToInt32(txtQuantity.Text);
                newCoffee.PhoneNum = Convert.ToInt32(txtPhoneNum.Text);
                newCoffee.Type = cmbType.SelectedItem.ToString();
                newCoffee.Strength = (Strength)Enum.Parse(typeof(Strength), cmbStrength.SelectedItem.ToString());
                newCoffee.Milk = cmbMilk.SelectedItem.ToString();
                newCoffee.Sugar = cmbSugar.SelectedItem.ToString();
                newCoffee.Cup = (Size)(cmbSize.SelectedItem);
                Data.Coffees.Add(newCoffee);
                MessageBox.Show("Your coffee has been added to your order");
                
            }            
        }
    }
}
