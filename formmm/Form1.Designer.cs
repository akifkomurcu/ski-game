
namespace formmm
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
            this.sayaç = new System.Windows.Forms.Timer(this.components);
            this.agac3 = new System.Windows.Forms.PictureBox();
            this.agac2 = new System.Windows.Forms.PictureBox();
            this.agac1 = new System.Windows.Forms.PictureBox();
            this.agac = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.kayak = new System.Windows.Forms.PictureBox();
            this.monster = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agac3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            this.SuspendLayout();
            // 
            // sayaç
            // 
            this.sayaç.Enabled = true;
            this.sayaç.Interval = 10;
            this.sayaç.Tick += new System.EventHandler(this.Sayacevent);
            // 
            // agac3
            // 
            this.agac3.Image = global::formmm.Properties.Resources.agac1;
            this.agac3.Location = new System.Drawing.Point(670, 542);
            this.agac3.Name = "agac3";
            this.agac3.Size = new System.Drawing.Size(45, 88);
            this.agac3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agac3.TabIndex = 10;
            this.agac3.TabStop = false;
            // 
            // agac2
            // 
            this.agac2.Image = global::formmm.Properties.Resources.agac1;
            this.agac2.Location = new System.Drawing.Point(558, 542);
            this.agac2.Name = "agac2";
            this.agac2.Size = new System.Drawing.Size(46, 88);
            this.agac2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agac2.TabIndex = 9;
            this.agac2.TabStop = false;
            // 
            // agac1
            // 
            this.agac1.Image = global::formmm.Properties.Resources.agac1;
            this.agac1.Location = new System.Drawing.Point(214, 542);
            this.agac1.Name = "agac1";
            this.agac1.Size = new System.Drawing.Size(47, 88);
            this.agac1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agac1.TabIndex = 8;
            this.agac1.TabStop = false;
            // 
            // agac
            // 
            this.agac.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.agac.Image = global::formmm.Properties.Resources.agac;
            this.agac.Location = new System.Drawing.Point(44, 542);
            this.agac.Name = "agac";
            this.agac.Size = new System.Drawing.Size(47, 88);
            this.agac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agac.TabIndex = 7;
            this.agac.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(885, 631);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // kayak
            // 
            this.kayak.Image = ((System.Drawing.Image)(resources.GetObject("kayak.Image")));
            this.kayak.Location = new System.Drawing.Point(391, 157);
            this.kayak.Name = "kayak";
            this.kayak.Size = new System.Drawing.Size(47, 88);
            this.kayak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kayak.TabIndex = 11;
            this.kayak.TabStop = false;
            // 
            // monster
            // 
            this.monster.Image = ((System.Drawing.Image)(resources.GetObject("monster.Image")));
            this.monster.Location = new System.Drawing.Point(391, -84);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(47, 88);
            this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster.TabIndex = 12;
            this.monster.TabStop = false;
            // 
            // star1
            // 
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(387, 568);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(51, 50);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 13;
            this.star1.TabStop = false;
            // 
            // star2
            // 
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(489, 568);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(51, 50);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 13;
            this.star2.TabStop = false;
            // 
            // star3
            // 
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(781, 521);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(51, 50);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 13;
            this.star3.TabStop = false;
            // 
            // star
            // 
            this.star.Image = ((System.Drawing.Image)(resources.GetObject("star.Image")));
            this.star.Location = new System.Drawing.Point(110, 521);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(51, 50);
            this.star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star.TabIndex = 13;
            this.star.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 630);
            this.Controls.Add(this.kayak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.agac3);
            this.Controls.Add(this.agac2);
            this.Controls.Add(this.agac1);
            this.Controls.Add(this.agac);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.agac3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer sayaç;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox agac;
        private System.Windows.Forms.PictureBox agac1;
        private System.Windows.Forms.PictureBox agac2;
        private System.Windows.Forms.PictureBox agac3;
        private System.Windows.Forms.PictureBox kayak;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star;
        private System.Windows.Forms.Label label1;
    }
}

