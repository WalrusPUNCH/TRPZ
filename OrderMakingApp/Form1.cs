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
    interface IView
    {
        void ShowResponseOK(string text);
        void ShowResponseError(string text);
    }

    public partial class MainForm : Form, IView
    {
        readonly IPresenter Presenter_;
        public MainForm()
        {
            InitializeComponent();
            Presenter_ = new Presenter(this);
            TableMenu.AutoGenerateColumns = false;
            TableMenu.DataSource = Presenter_.GetMenu();
            
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
            
            Presenter_.MakeOrder(DishesNames);
            //MessageBox.Show(String.Format("Ваше замовлення буде готове {0}", CurrentOrder.ServingTime.ToString()), "Інформація про замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowResponseOK(string text)
        {
            MessageBox.Show(text, "Інформація про замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowResponseError(string text)
        {
            MessageBox.Show(text, "Помилка у замовленні", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
