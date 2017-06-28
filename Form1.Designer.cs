namespace SetXMLForBike18Upload
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdAllProducts = new System.Windows.Forms.OpenFileDialog();
            this.ofdNewProduct = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenAllProducts = new System.Windows.Forms.Button();
            this.btnLoadNewProduct = new System.Windows.Forms.Button();
            this.btnUpdateSLUG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdAllProducts
            // 
            this.ofdAllProducts.FileName = "openFileDialog1";
            // 
            // ofdNewProduct
            // 
            this.ofdNewProduct.FileName = "openFileDialog2";
            // 
            // btnOpenAllProducts
            // 
            this.btnOpenAllProducts.Location = new System.Drawing.Point(12, 12);
            this.btnOpenAllProducts.Name = "btnOpenAllProducts";
            this.btnOpenAllProducts.Size = new System.Drawing.Size(153, 23);
            this.btnOpenAllProducts.TabIndex = 0;
            this.btnOpenAllProducts.Text = "Выбрать выгрузку с сайта";
            this.btnOpenAllProducts.UseVisualStyleBackColor = true;
            this.btnOpenAllProducts.Click += new System.EventHandler(this.btnOpenAllProducts_Click);
            // 
            // btnLoadNewProduct
            // 
            this.btnLoadNewProduct.Location = new System.Drawing.Point(12, 52);
            this.btnLoadNewProduct.Name = "btnLoadNewProduct";
            this.btnLoadNewProduct.Size = new System.Drawing.Size(153, 23);
            this.btnLoadNewProduct.TabIndex = 1;
            this.btnLoadNewProduct.Text = "Выбрать файл для загрузки";
            this.btnLoadNewProduct.UseVisualStyleBackColor = true;
            this.btnLoadNewProduct.Click += new System.EventHandler(this.btnLoadNewProduct_Click);
            // 
            // btnUpdateSLUG
            // 
            this.btnUpdateSLUG.Location = new System.Drawing.Point(171, 12);
            this.btnUpdateSLUG.Name = "btnUpdateSLUG";
            this.btnUpdateSLUG.Size = new System.Drawing.Size(168, 23);
            this.btnUpdateSLUG.TabIndex = 2;
            this.btnUpdateSLUG.Text = "Обработать slug";
            this.btnUpdateSLUG.UseVisualStyleBackColor = true;
            this.btnUpdateSLUG.Click += new System.EventHandler(this.btnUpdateSLUG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 346);
            this.Controls.Add(this.btnUpdateSLUG);
            this.Controls.Add(this.btnLoadNewProduct);
            this.Controls.Add(this.btnOpenAllProducts);
            this.Name = "Form1";
            this.Text = "Подготовка файла для загрузки на сайт";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdAllProducts;
        private System.Windows.Forms.OpenFileDialog ofdNewProduct;
        private System.Windows.Forms.Button btnOpenAllProducts;
        private System.Windows.Forms.Button btnLoadNewProduct;
        private System.Windows.Forms.Button btnUpdateSLUG;
    }
}

