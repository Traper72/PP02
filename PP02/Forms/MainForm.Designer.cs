namespace PP02
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.buttonUpcomingEntries = new System.Windows.Forms.Button();
            this.buttonAdminPanel = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelResultSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.comboBoxSale = new System.Windows.Forms.ComboBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonAddService);
            this.panelMenu.Controls.Add(this.buttonUpcomingEntries);
            this.panelMenu.Controls.Add(this.buttonAdminPanel);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(274, 591);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonAddService
            // 
            this.buttonAddService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddService.FlatAppearance.BorderSize = 0;
            this.buttonAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddService.Location = new System.Drawing.Point(0, 474);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Padding = new System.Windows.Forms.Padding(1);
            this.buttonAddService.Size = new System.Drawing.Size(274, 39);
            this.buttonAddService.TabIndex = 3;
            this.buttonAddService.Text = "Добавить услугу";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // buttonUpcomingEntries
            // 
            this.buttonUpcomingEntries.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUpcomingEntries.FlatAppearance.BorderSize = 0;
            this.buttonUpcomingEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpcomingEntries.Location = new System.Drawing.Point(0, 513);
            this.buttonUpcomingEntries.Name = "buttonUpcomingEntries";
            this.buttonUpcomingEntries.Padding = new System.Windows.Forms.Padding(1);
            this.buttonUpcomingEntries.Size = new System.Drawing.Size(274, 39);
            this.buttonUpcomingEntries.TabIndex = 2;
            this.buttonUpcomingEntries.Text = "Ближайшие записи";
            this.buttonUpcomingEntries.UseVisualStyleBackColor = true;
            this.buttonUpcomingEntries.Click += new System.EventHandler(this.buttonUpcomingEntries_Click);
            // 
            // buttonAdminPanel
            // 
            this.buttonAdminPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdminPanel.FlatAppearance.BorderSize = 0;
            this.buttonAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminPanel.Location = new System.Drawing.Point(0, 552);
            this.buttonAdminPanel.Name = "buttonAdminPanel";
            this.buttonAdminPanel.Padding = new System.Windows.Forms.Padding(1);
            this.buttonAdminPanel.Size = new System.Drawing.Size(274, 39);
            this.buttonAdminPanel.TabIndex = 1;
            this.buttonAdminPanel.Text = "Админ режим";
            this.buttonAdminPanel.UseVisualStyleBackColor = true;
            this.buttonAdminPanel.Click += new System.EventHandler(this.buttonAdminPanel_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(274, 97);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonReset);
            this.panelHeader.Controls.Add(this.labelSort);
            this.panelHeader.Controls.Add(this.comboBoxSort);
            this.panelHeader.Controls.Add(this.labelResultSearch);
            this.panelHeader.Controls.Add(this.textBoxSearch);
            this.panelHeader.Controls.Add(this.labelSearch);
            this.panelHeader.Controls.Add(this.labelSale);
            this.panelHeader.Controls.Add(this.comboBoxSale);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(274, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(898, 97);
            this.panelHeader.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(326, 60);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 31);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(323, 15);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(106, 18);
            this.labelSort.TabIndex = 6;
            this.labelSort.Text = "Сортировать по";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(435, 12);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(182, 26);
            this.comboBoxSort.TabIndex = 5;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // labelResultSearch
            // 
            this.labelResultSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResultSearch.Location = new System.Drawing.Point(607, 57);
            this.labelResultSearch.Name = "labelResultSearch";
            this.labelResultSearch.Size = new System.Drawing.Size(276, 32);
            this.labelResultSearch.TabIndex = 4;
            this.labelResultSearch.Text = "Количество результатов поиска";
            this.labelResultSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(120, 63);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(182, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(15, 66);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(49, 18);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Поиск";
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(15, 15);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(99, 18);
            this.labelSale.TabIndex = 1;
            this.labelSale.Text = "Размер скидки";
            // 
            // comboBoxSale
            // 
            this.comboBoxSale.FormattingEnabled = true;
            this.comboBoxSale.Location = new System.Drawing.Point(120, 12);
            this.comboBoxSale.Name = "comboBoxSale";
            this.comboBoxSale.Size = new System.Drawing.Size(182, 26);
            this.comboBoxSale.TabIndex = 0;
            this.comboBoxSale.SelectedIndexChanged += new System.EventHandler(this.comboBoxSale_SelectedIndexChanged);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(274, 97);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(898, 494);
            this.panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 591);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Список услуг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonAdminPanel;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelResultSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.ComboBox comboBoxSale;
        private System.Windows.Forms.Button buttonUpcomingEntries;
        private System.Windows.Forms.Button buttonAddService;
    }
}

