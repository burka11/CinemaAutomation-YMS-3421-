namespace Project.FormUI.Raporlama
{
    partial class RaporGenel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporGenel));
            this.btnIntGıse = new System.Windows.Forms.Button();
            this.btnGise = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnSalonRapor = new System.Windows.Forms.Button();
            this.btnSeansGoruntule = new System.Windows.Forms.Button();
            this.btnFilmRapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntGıse
            // 
            this.btnIntGıse.BackColor = System.Drawing.Color.Red;
            this.btnIntGıse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIntGıse.Location = new System.Drawing.Point(738, 310);
            this.btnIntGıse.Name = "btnIntGıse";
            this.btnIntGıse.Size = new System.Drawing.Size(172, 54);
            this.btnIntGıse.TabIndex = 11;
            this.btnIntGıse.Text = "Internet ve Gişe Satışları";
            this.btnIntGıse.UseVisualStyleBackColor = false;
            this.btnIntGıse.Click += new System.EventHandler(this.btnIntGıse_Click);
            // 
            // btnGise
            // 
            this.btnGise.BackColor = System.Drawing.Color.Orange;
            this.btnGise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGise.Location = new System.Drawing.Point(738, 210);
            this.btnGise.Name = "btnGise";
            this.btnGise.Size = new System.Drawing.Size(172, 54);
            this.btnGise.TabIndex = 10;
            this.btnGise.Text = "Gişe Satışlarını Görüntüle";
            this.btnGise.UseVisualStyleBackColor = false;
            this.btnGise.Click += new System.EventHandler(this.btnGise_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInternet.Location = new System.Drawing.Point(738, 103);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(172, 54);
            this.btnInternet.TabIndex = 9;
            this.btnInternet.Text = "İnternet Satışlarını Görüntüle";
            this.btnInternet.UseVisualStyleBackColor = false;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnSalonRapor
            // 
            this.btnSalonRapor.BackColor = System.Drawing.Color.Teal;
            this.btnSalonRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonRapor.Location = new System.Drawing.Point(34, 310);
            this.btnSalonRapor.Name = "btnSalonRapor";
            this.btnSalonRapor.Size = new System.Drawing.Size(172, 54);
            this.btnSalonRapor.TabIndex = 8;
            this.btnSalonRapor.Text = "Salon Raporlarını Görüntüle";
            this.btnSalonRapor.UseVisualStyleBackColor = false;
            this.btnSalonRapor.Click += new System.EventHandler(this.btnSalonRapor_Click);
            // 
            // btnSeansGoruntule
            // 
            this.btnSeansGoruntule.BackColor = System.Drawing.Color.Crimson;
            this.btnSeansGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansGoruntule.Location = new System.Drawing.Point(34, 210);
            this.btnSeansGoruntule.Name = "btnSeansGoruntule";
            this.btnSeansGoruntule.Size = new System.Drawing.Size(172, 54);
            this.btnSeansGoruntule.TabIndex = 7;
            this.btnSeansGoruntule.Text = "Seans Raporlarını Görüntüle";
            this.btnSeansGoruntule.UseVisualStyleBackColor = false;
            this.btnSeansGoruntule.Click += new System.EventHandler(this.btnSeansGoruntule_Click);
            // 
            // btnFilmRapor
            // 
            this.btnFilmRapor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnFilmRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmRapor.Location = new System.Drawing.Point(34, 103);
            this.btnFilmRapor.Name = "btnFilmRapor";
            this.btnFilmRapor.Size = new System.Drawing.Size(172, 54);
            this.btnFilmRapor.TabIndex = 6;
            this.btnFilmRapor.Text = "Film Raporlarını Görüntüle";
            this.btnFilmRapor.UseVisualStyleBackColor = false;
            this.btnFilmRapor.Click += new System.EventHandler(this.btnFilmRapor_Click);
            // 
            // RaporGenel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 466);
            this.Controls.Add(this.btnIntGıse);
            this.Controls.Add(this.btnGise);
            this.Controls.Add(this.btnInternet);
            this.Controls.Add(this.btnSalonRapor);
            this.Controls.Add(this.btnSeansGoruntule);
            this.Controls.Add(this.btnFilmRapor);
            this.Name = "RaporGenel";
            this.Text = "RaporGenel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntGıse;
        private System.Windows.Forms.Button btnGise;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnSalonRapor;
        private System.Windows.Forms.Button btnSeansGoruntule;
        private System.Windows.Forms.Button btnFilmRapor;
    }
}