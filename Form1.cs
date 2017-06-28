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
            ControlsFormEnabledFalse();

            ControlsFormEnabledTrue();
        }

        private void ControlsFormEnabledTrue()
        {
            btnLoadNewProduct.Invoke(new Action(() => btnLoadNewProduct.Enabled = true));
            btnOpenAllProducts.Invoke(new Action(() => btnOpenAllProducts.Enabled = true));
            btnUpdateSLUG.Invoke(new Action(() => btnUpdateSLUG.Enabled = true));
        }

        private void ControlsFormEnabledFalse()
        {
            btnLoadNewProduct.Invoke(new Action(() => btnLoadNewProduct.Enabled = false));
            btnOpenAllProducts.Invoke(new Action(() => btnOpenAllProducts.Enabled = false));
            btnUpdateSLUG.Invoke(new Action(() => btnUpdateSLUG.Enabled = false));
        }
    }
}
