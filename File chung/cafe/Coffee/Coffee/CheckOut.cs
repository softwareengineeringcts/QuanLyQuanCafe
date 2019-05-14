using Coffee.DAO;
using Coffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            int discount = (int)nmDiscount.Value;
            

            double totalPrice = Convert.ToDouble(txtPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            
        }

    }
}
