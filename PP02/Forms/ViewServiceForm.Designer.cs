namespace PP02.Forms
{
    partial class ViewServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewServiceForm));
            this.pictureBoxMainPhoto = new System.Windows.Forms.PictureBox();
            this.panelDataService = new System.Windows.Forms.Panel();
            this.buttonSaveService = new System.Windows.Forms.Button();
            this.buttonAddSubPhoto = new System.Windows.Forms.Button();
            this.buttonEditMainPhoto = new System.Windows.Forms.Button();
            this.numericSaleService = new System.Windows.Forms.NumericUpDown();
            this.numericDurationService = new System.Windows.Forms.NumericUpDown();
            this.numericCostService = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescriptionService = new System.Windows.Forms.TextBox();
            this.textBoxNameService = new System.Windows.Forms.TextBox();
            this.textBoxIdService = new System.Windows.Forms.TextBox();
            this.labelDescriptionService = new System.Windows.Forms.Label();
            this.labelSaleService = new System.Windows.Forms.Label();
            this.labelDurationService = new System.Windows.Forms.Label();
            this.labelCostService = new System.Windows.Forms.Label();
            this.labelNameService = new System.Windows.Forms.Label();
            this.labelIdService = new System.Windows.Forms.Label();
            this.panelSubPhoto = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainPhoto)).BeginInit();
            this.panelDataService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCostService)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainPhoto
            // 
            this.pictureBoxMainPhoto.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxMainPhoto.Name = "pictureBoxMainPhoto";
            this.pictureBoxMainPhoto.Size = new System.Drawing.Size(239, 134);
            this.pictureBoxMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMainPhoto.TabIndex = 0;
            this.pictureBoxMainPhoto.TabStop = false;
            // 
            // panelDataService
            // 
            this.panelDataService.Controls.Add(this.buttonSaveService);
            this.panelDataService.Controls.Add(this.buttonAddSubPhoto);
            this.panelDataService.Controls.Add(this.buttonEditMainPhoto);
            this.panelDataService.Controls.Add(this.numericSaleService);
            this.panelDataService.Controls.Add(this.numericDurationService);
            this.panelDataService.Controls.Add(this.numericCostService);
            this.panelDataService.Controls.Add(this.textBoxDescriptionService);
            this.panelDataService.Controls.Add(this.textBoxNameService);
            this.panelDataService.Controls.Add(this.textBoxIdService);
            this.panelDataService.Controls.Add(this.labelDescriptionService);
            this.panelDataService.Controls.Add(this.labelSaleService);
            this.panelDataService.Controls.Add(this.labelDurationService);
            this.panelDataService.Controls.Add(this.labelCostService);
            this.panelDataService.Controls.Add(this.labelNameService);
            this.panelDataService.Controls.Add(this.labelIdService);
            this.panelDataService.Controls.Add(this.pictureBoxMainPhoto);
            this.panelDataService.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataService.Location = new System.Drawing.Point(0, 0);
            this.panelDataService.Name = "panelDataService";
            this.panelDataService.Size = new System.Drawing.Size(704, 310);
            this.panelDataService.TabIndex = 1;
            // 
            // buttonSaveService
            // 
            this.buttonSaveService.FlatAppearance.BorderSize = 0;
            this.buttonSaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveService.Location = new System.Drawing.Point(12, 252);
            this.buttonSaveService.Name = "buttonSaveService";
            this.buttonSaveService.Padding = new System.Windows.Forms.Padding(1);
            this.buttonSaveService.Size = new System.Drawing.Size(239, 43);
            this.buttonSaveService.TabIndex = 18;
            this.buttonSaveService.Text = "Сохранить";
            this.buttonSaveService.UseVisualStyleBackColor = true;
            this.buttonSaveService.Click += new System.EventHandler(this.buttonSaveService_Click);
            // 
            // buttonAddSubPhoto
            // 
            this.buttonAddSubPhoto.FlatAppearance.BorderSize = 0;
            this.buttonAddSubPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubPhoto.Location = new System.Drawing.Point(12, 203);
            this.buttonAddSubPhoto.Name = "buttonAddSubPhoto";
            this.buttonAddSubPhoto.Padding = new System.Windows.Forms.Padding(1);
            this.buttonAddSubPhoto.Size = new System.Drawing.Size(239, 43);
            this.buttonAddSubPhoto.TabIndex = 17;
            this.buttonAddSubPhoto.Text = "Добавить доп изображение";
            this.buttonAddSubPhoto.UseVisualStyleBackColor = true;
            this.buttonAddSubPhoto.Click += new System.EventHandler(this.buttonAddSubPhoto_Click);
            // 
            // buttonEditMainPhoto
            // 
            this.buttonEditMainPhoto.FlatAppearance.BorderSize = 0;
            this.buttonEditMainPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMainPhoto.Location = new System.Drawing.Point(12, 154);
            this.buttonEditMainPhoto.Name = "buttonEditMainPhoto";
            this.buttonEditMainPhoto.Padding = new System.Windows.Forms.Padding(1);
            this.buttonEditMainPhoto.Size = new System.Drawing.Size(239, 43);
            this.buttonEditMainPhoto.TabIndex = 16;
            this.buttonEditMainPhoto.Text = "Изменить главное изображение";
            this.buttonEditMainPhoto.UseVisualStyleBackColor = true;
            this.buttonEditMainPhoto.Click += new System.EventHandler(this.buttonEditMainPhoto_Click);
            // 
            // numericSaleService
            // 
            this.numericSaleService.Location = new System.Drawing.Point(415, 142);
            this.numericSaleService.Name = "numericSaleService";
            this.numericSaleService.Size = new System.Drawing.Size(276, 26);
            this.numericSaleService.TabIndex = 15;
            // 
            // numericDurationService
            // 
            this.numericDurationService.Location = new System.Drawing.Point(415, 110);
            this.numericDurationService.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericDurationService.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericDurationService.Name = "numericDurationService";
            this.numericDurationService.Size = new System.Drawing.Size(276, 26);
            this.numericDurationService.TabIndex = 14;
            this.numericDurationService.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericCostService
            // 
            this.numericCostService.DecimalPlaces = 2;
            this.numericCostService.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericCostService.Location = new System.Drawing.Point(415, 78);
            this.numericCostService.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCostService.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCostService.Name = "numericCostService";
            this.numericCostService.Size = new System.Drawing.Size(276, 26);
            this.numericCostService.TabIndex = 13;
            this.numericCostService.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxDescriptionService
            // 
            this.textBoxDescriptionService.Location = new System.Drawing.Point(260, 200);
            this.textBoxDescriptionService.Multiline = true;
            this.textBoxDescriptionService.Name = "textBoxDescriptionService";
            this.textBoxDescriptionService.Size = new System.Drawing.Size(431, 95);
            this.textBoxDescriptionService.TabIndex = 12;
            // 
            // textBoxNameService
            // 
            this.textBoxNameService.Location = new System.Drawing.Point(415, 45);
            this.textBoxNameService.Name = "textBoxNameService";
            this.textBoxNameService.Size = new System.Drawing.Size(276, 26);
            this.textBoxNameService.TabIndex = 8;
            // 
            // textBoxIdService
            // 
            this.textBoxIdService.Location = new System.Drawing.Point(415, 13);
            this.textBoxIdService.Name = "textBoxIdService";
            this.textBoxIdService.Size = new System.Drawing.Size(276, 26);
            this.textBoxIdService.TabIndex = 7;
            // 
            // labelDescriptionService
            // 
            this.labelDescriptionService.AutoSize = true;
            this.labelDescriptionService.Location = new System.Drawing.Point(257, 179);
            this.labelDescriptionService.Name = "labelDescriptionService";
            this.labelDescriptionService.Size = new System.Drawing.Size(70, 18);
            this.labelDescriptionService.TabIndex = 6;
            this.labelDescriptionService.Text = "Описание";
            // 
            // labelSaleService
            // 
            this.labelSaleService.AutoSize = true;
            this.labelSaleService.Location = new System.Drawing.Point(257, 144);
            this.labelSaleService.Name = "labelSaleService";
            this.labelSaleService.Size = new System.Drawing.Size(76, 18);
            this.labelSaleService.TabIndex = 5;
            this.labelSaleService.Text = "Скидка (%)";
            // 
            // labelDurationService
            // 
            this.labelDurationService.AutoSize = true;
            this.labelDurationService.Location = new System.Drawing.Point(257, 112);
            this.labelDurationService.Name = "labelDurationService";
            this.labelDurationService.Size = new System.Drawing.Size(134, 18);
            this.labelDurationService.TabIndex = 4;
            this.labelDurationService.Text = "Длительность (мин)";
            // 
            // labelCostService
            // 
            this.labelCostService.AutoSize = true;
            this.labelCostService.Location = new System.Drawing.Point(257, 80);
            this.labelCostService.Name = "labelCostService";
            this.labelCostService.Size = new System.Drawing.Size(110, 18);
            this.labelCostService.TabIndex = 3;
            this.labelCostService.Text = "Стоимость (руб)";
            // 
            // labelNameService
            // 
            this.labelNameService.AutoSize = true;
            this.labelNameService.Location = new System.Drawing.Point(257, 53);
            this.labelNameService.Name = "labelNameService";
            this.labelNameService.Size = new System.Drawing.Size(101, 18);
            this.labelNameService.TabIndex = 2;
            this.labelNameService.Text = "Наименование";
            // 
            // labelIdService
            // 
            this.labelIdService.AutoSize = true;
            this.labelIdService.Location = new System.Drawing.Point(257, 21);
            this.labelIdService.Name = "labelIdService";
            this.labelIdService.Size = new System.Drawing.Size(32, 18);
            this.labelIdService.TabIndex = 1;
            this.labelIdService.Text = "Код";
            // 
            // panelSubPhoto
            // 
            this.panelSubPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubPhoto.Location = new System.Drawing.Point(0, 310);
            this.panelSubPhoto.Name = "panelSubPhoto";
            this.panelSubPhoto.Size = new System.Drawing.Size(704, 154);
            this.panelSubPhoto.TabIndex = 2;
            // 
            // ViewServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 464);
            this.Controls.Add(this.panelSubPhoto);
            this.Controls.Add(this.panelDataService);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewServiceForm";
            this.Text = "ViewServiceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewServiceForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainPhoto)).EndInit();
            this.panelDataService.ResumeLayout(false);
            this.panelDataService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDurationService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCostService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainPhoto;
        private System.Windows.Forms.Panel panelDataService;
        private System.Windows.Forms.Button buttonSaveService;
        private System.Windows.Forms.Button buttonAddSubPhoto;
        private System.Windows.Forms.Button buttonEditMainPhoto;
        private System.Windows.Forms.NumericUpDown numericSaleService;
        private System.Windows.Forms.NumericUpDown numericDurationService;
        private System.Windows.Forms.NumericUpDown numericCostService;
        private System.Windows.Forms.TextBox textBoxDescriptionService;
        private System.Windows.Forms.TextBox textBoxNameService;
        private System.Windows.Forms.TextBox textBoxIdService;
        private System.Windows.Forms.Label labelDescriptionService;
        private System.Windows.Forms.Label labelSaleService;
        private System.Windows.Forms.Label labelDurationService;
        private System.Windows.Forms.Label labelCostService;
        private System.Windows.Forms.Label labelNameService;
        private System.Windows.Forms.Label labelIdService;
        private System.Windows.Forms.Panel panelSubPhoto;
    }
}