using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetXMLForBike18Upload
{
    public partial class Form1 : Form
    {
        string fileUrlsAllProducts;
        string fileUrlsNewProducts;
        Thread forms;


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

        private void btnUpdateSLUG_Click(object sender, EventArgs e)
        {
            if (ofdAllProducts.FileName == "openFileDialog1" || ofdAllProducts.FileName == "" || ofdNewProduct.FileName == "openFileDialog1" || ofdNewProduct.FileName == "")
            {
                MessageBox.Show("Ошибка при выборе файла", "Ошибка файла");
                return;
            }

            Thread tabl = new Thread(() => UpdateSLUG());
            forms = tabl;
            forms.IsBackground = true;
            forms.Start();
        }

        private void UpdateSLUG()
        {
            throw new NotImplementedException();
        }
    }
}
