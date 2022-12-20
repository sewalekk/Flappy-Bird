namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kus = new System.Windows.Forms.PictureBox();
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // kus
            // 
            this.kus.Image = ((System.Drawing.Image)(resources.GetObject("kus.Image")));
            this.kus.Location = new System.Drawing.Point(36, 232);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(69, 49);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 0;
            this.kus.TabStop = false;
            this.kus.Click += new System.EventHandler(this.kus_Click);
            // 
            // boruUst
            // 
            this.boruUst.Image = ((System.Drawing.Image)(resources.GetObject("boruUst.Image")));
            this.boruUst.Location = new System.Drawing.Point(529, -8);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(100, 233);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst.TabIndex = 1;
            this.boruUst.TabStop = false;
            // 
            // boruAlt
            // 
            this.boruAlt.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt.Image")));
            this.boruAlt.Location = new System.Drawing.Point(320, 323);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(100, 228);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 2;
            this.boruAlt.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(-5, 512);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(748, 121);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoretext.Location = new System.Drawing.Point(12, 9);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(93, 26);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(741, 633);
            this.Controls.Add(this.kus);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.boruUst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gameTimer;
    }
}

