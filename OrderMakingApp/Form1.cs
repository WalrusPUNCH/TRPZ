using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMakingApp
{
    public partial class Form1 : Form
    {
        readonly Presenter Presenter_;
        public Form1()
        {
            InitializeComponent();
            Presenter_ = new Presenter();
            TableMenu.AutoGenerateColumns = false;
            TableMenu.DataSource = Presenter_.Menu;
            
        }

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            List<string> DishesNames = new List<string>();
            var checkedRows = from DataGridViewRow row in TableMenu.Rows
                              where Convert.ToBoolean(row.Cells["IsOrderedDishColumn"].Value) == true
                              select row;

            foreach (var row in checkedRows)
            {
                row.Cells["IsOrderedDishColumn"].Value = false;
                DishesNames.Add(row.Cells["DishName"].Value.ToString());
            }

            Order CurrentOrder = Presenter_.MakeOrder(DishesNames);
            MessageBox.Show(String.Format("Ваше замовлення буде готове {0}", CurrentOrder.ServingTime.ToString()), "Інформація про замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
