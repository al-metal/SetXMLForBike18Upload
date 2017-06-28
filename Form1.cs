using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetXMLForBike18Upload
{
    public partial class Form1 : Form
    {
        string fileUrlsAllProducts;
        string fileUrlsNewProducts;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenAllProducts_Click(object sender, EventArgs e)
        {
            fileUrlsAllProducts = "";
            ofdAllProducts.ShowDialog();
        }

        private void btnLoadNewProduct_Click(object sender, EventArgs e)
        {
            fileUrlsNewProducts = "";
            ofdNewProduct.ShowDialog();
        }
    }
}
