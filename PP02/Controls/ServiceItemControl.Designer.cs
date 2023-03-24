namespace PP02.Controls
{
    partial class ServiceItemControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameService = new System.Windows.Forms.Label();
            this.labelSaleService = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSalePriceService = new System.Windows.Forms.Label();
            this.labelPriceService = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.buttonDeleteService = new System.Windows.Forms.Button();
            this.buttonViewService = new System.Windows.Forms.Button();
            this.pictureBoxService = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxService)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameService
            // 
            this.labelNameService.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNameService.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameService.Location = new System.Drawing.Point(15, 5);
            this.labelNameService.Name = "labelNameService";
            this.labelNameService.Size = new System.Drawing.Size(738, 40);
            this.labelNameService.TabIndex = 1;
            this.labelNameService.Text = "label1";
            // 
            // labelSaleService
            // 
            this.labelSaleService.AutoSize = true;
            this.labelSaleService.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSaleService.Location = new System.Drawing.Point(159, 75);
            this.labelSaleService.Name = "labelSaleService";
            this.labelSaleService.Size = new System.Drawing.Size(44, 18);
            this.labelSaleService.TabIndex = 3;
            this.labelSaleService.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNameService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(143, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(753, 36);
            this.panel1.TabIndex = 6;
            // 
            // labelSalePriceService
            // 
            this.labelSalePriceService.AutoSize = true;
            this.labelSalePriceService.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSalePriceService.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalePriceService.Location = new System.Drawing.Point(72, 5);
            this.labelSalePriceService.Name = "labelSalePriceService";
            this.labelSalePriceService.Size = new System.Drawing.Size(57, 24);
            this.labelSalePriceService.TabIndex = 5;
            this.labelSalePriceService.Text = "label1";
            // 
            // labelPriceService
            // 
            this.labelPriceService.AutoSize = true;
            this.labelPriceService.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPriceService.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceService.Location = new System.Drawing.Point(15, 5);
            this.labelPriceService.Name = "labelPriceService";
            this.labelPriceService.Size = new System.Drawing.Size(57, 24);
            this.labelPriceService.TabIndex = 2;
            this.labelPriceService.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelSalePriceService);
            this.panel2.Controls.Add(this.labelPriceService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(143, 36);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(753, 36);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonAddRecord);
            this.panel3.Controls.Add(this.buttonDeleteService);
            this.panel3.Controls.Add(this.buttonViewService);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(143, 100);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 5);
            this.panel3.Size = new System.Drawing.Size(753, 41);
            this.panel3.TabIndex = 8;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecord.Location = new System.Drawing.Point(423, 0);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(204, 36);
            this.buttonAddRecord.TabIndex = 7;
            this.buttonAddRecord.Text = "Создать запись";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // buttonDeleteService
            // 
            this.buttonDeleteService.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteService.Location = new System.Drawing.Point(219, 0);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new System.Drawing.Size(204, 36);
            this.buttonDeleteService.TabIndex = 6;
            this.buttonDeleteService.Text = "Удалить";
            this.buttonDeleteService.UseVisualStyleBackColor = true;
            this.buttonDeleteService.Click += new System.EventHandler(this.buttonDeleteService_Click);
            // 
            // buttonViewService
            // 
            this.buttonViewService.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonViewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewService.Location = new System.Drawing.Point(15, 0);
            this.buttonViewService.Name = "buttonViewService";
            this.buttonViewService.Size = new System.Drawing.Size(204, 36);
            this.buttonViewService.TabIndex = 5;
            this.buttonViewService.Text = "Просмотреть";
            this.buttonViewService.UseVisualStyleBackColor = true;
            this.buttonViewService.Click += new System.EventHandler(this.buttonViewService_Click);
            // 
            // pictureBoxService
            // 
            this.pictureBoxService.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxService.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxService.Name = "pictureBoxService";
            this.pictureBoxService.Size = new System.Drawing.Size(143, 141);
            this.pictureBoxService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxService.TabIndex = 0;
            this.pictureBoxService.TabStop = false;
            // 
            // ServiceItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSaleService);
            this.Controls.Add(this.pictureBoxService);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ServiceItemControl";
            this.Size = new System.Drawing.Size(896, 141);
            this.Load += new System.EventHandler(this.ServiceItemControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxService;
        private System.Windows.Forms.Label labelNameService;
        private System.Windows.Forms.Label labelSaleService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSalePriceService;
        private System.Windows.Forms.Label labelPriceService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonDeleteService;
        private System.Windows.Forms.Button buttonViewService;
    }
}
