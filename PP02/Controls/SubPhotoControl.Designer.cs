namespace PP02.Controls
{
    partial class SubPhotoControl
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
            this.buttonDeleteSubPhoto = new System.Windows.Forms.Button();
            this.pictureBoxSubPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteSubPhoto
            // 
            this.buttonDeleteSubPhoto.BackgroundImage = global::PP02.Properties.Resources.trashcan1;
            this.buttonDeleteSubPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteSubPhoto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDeleteSubPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSubPhoto.Location = new System.Drawing.Point(0, 156);
            this.buttonDeleteSubPhoto.Name = "buttonDeleteSubPhoto";
            this.buttonDeleteSubPhoto.Size = new System.Drawing.Size(214, 36);
            this.buttonDeleteSubPhoto.TabIndex = 1;
            this.buttonDeleteSubPhoto.UseVisualStyleBackColor = true;
            this.buttonDeleteSubPhoto.Click += new System.EventHandler(this.buttonDeleteSubPhoto_Click);
            // 
            // pictureBoxSubPhoto
            // 
            this.pictureBoxSubPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSubPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSubPhoto.Name = "pictureBoxSubPhoto";
            this.pictureBoxSubPhoto.Size = new System.Drawing.Size(214, 192);
            this.pictureBoxSubPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubPhoto.TabIndex = 0;
            this.pictureBoxSubPhoto.TabStop = false;
            // 
            // SubPhotoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonDeleteSubPhoto);
            this.Controls.Add(this.pictureBoxSubPhoto);
            this.Name = "SubPhotoControl";
            this.Size = new System.Drawing.Size(214, 192);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteSubPhoto;
        public System.Windows.Forms.PictureBox pictureBoxSubPhoto;
    }
}
