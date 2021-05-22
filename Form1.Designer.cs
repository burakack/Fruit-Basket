
namespace Meyvesepeti
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
            this.baslabutton = new System.Windows.Forms.Button();
            this.agirliklabel = new System.Windows.Forms.Label();
            this.vitaminalabel = new System.Windows.Forms.Label();
            this.sivilabel = new System.Windows.Forms.Label();
            this.vitaminclabel = new System.Windows.Forms.Label();
            this.purelabel = new System.Windows.Forms.Label();
            this.sonmeyvelabel = new System.Windows.Forms.Label();
            this.toplamlabel = new System.Windows.Forms.Label();
            this.agirliksonuclabel = new System.Windows.Forms.Label();
            this.tagirliksonuclabel = new System.Windows.Forms.Label();
            this.vitaminasonuclabel = new System.Windows.Forms.Label();
            this.vitamincsonuclabel = new System.Windows.Forms.Label();
            this.tvitaminasonuclabel = new System.Windows.Forms.Label();
            this.tvitamincsonuclabel = new System.Windows.Forms.Label();
            this.sivisonuclabel = new System.Windows.Forms.Label();
            this.tsivisonuclabel = new System.Windows.Forms.Label();
            this.puresonuclabel = new System.Windows.Forms.Label();
            this.tpuresonuclabel = new System.Windows.Forms.Label();
            this.uyarilabel = new System.Windows.Forms.Label();
            this.sıvısıkacak = new System.Windows.Forms.RadioButton();
            this.katısıkacak = new System.Windows.Forms.RadioButton();
            this.radiogroup = new System.Windows.Forms.GroupBox();
            this.suremeyvelabel = new System.Windows.Forms.Label();
            this.surelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.resimler = new System.Windows.Forms.PictureBox();
            this.resimlist = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radiogroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimler)).BeginInit();
            this.SuspendLayout();
            // 
            // baslabutton
            // 
            this.baslabutton.Location = new System.Drawing.Point(701, 530);
            this.baslabutton.Name = "baslabutton";
            this.baslabutton.Size = new System.Drawing.Size(119, 60);
            this.baslabutton.TabIndex = 0;
            this.baslabutton.Text = "Başla";
            this.baslabutton.UseVisualStyleBackColor = true;
            this.baslabutton.Click += new System.EventHandler(this.BaslaButton_Click);
            // 
            // agirliklabel
            // 
            this.agirliklabel.AutoSize = true;
            this.agirliklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.agirliklabel.Location = new System.Drawing.Point(610, 159);
            this.agirliklabel.Name = "agirliklabel";
            this.agirliklabel.Size = new System.Drawing.Size(64, 22);
            this.agirliklabel.TabIndex = 1;
            this.agirliklabel.Text = "Ağırlık:";
            // 
            // vitaminalabel
            // 
            this.vitaminalabel.AutoSize = true;
            this.vitaminalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.vitaminalabel.Location = new System.Drawing.Point(583, 188);
            this.vitaminalabel.Name = "vitaminalabel";
            this.vitaminalabel.Size = new System.Drawing.Size(91, 22);
            this.vitaminalabel.TabIndex = 2;
            this.vitaminalabel.Text = "Vitamin A:";
            // 
            // sivilabel
            // 
            this.sivilabel.AutoSize = true;
            this.sivilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.sivilabel.Location = new System.Drawing.Point(630, 248);
            this.sivilabel.Name = "sivilabel";
            this.sivilabel.Size = new System.Drawing.Size(44, 22);
            this.sivilabel.TabIndex = 4;
            this.sivilabel.Text = "Sıvı:";
            // 
            // vitaminclabel
            // 
            this.vitaminclabel.AutoSize = true;
            this.vitaminclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.vitaminclabel.Location = new System.Drawing.Point(582, 218);
            this.vitaminclabel.Name = "vitaminclabel";
            this.vitaminclabel.Size = new System.Drawing.Size(92, 22);
            this.vitaminclabel.TabIndex = 3;
            this.vitaminclabel.Text = "Vitamin C:";
            // 
            // purelabel
            // 
            this.purelabel.AutoSize = true;
            this.purelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.purelabel.Location = new System.Drawing.Point(621, 281);
            this.purelabel.Name = "purelabel";
            this.purelabel.Size = new System.Drawing.Size(53, 22);
            this.purelabel.TabIndex = 5;
            this.purelabel.Text = "Püre:";
            // 
            // sonmeyvelabel
            // 
            this.sonmeyvelabel.AutoSize = true;
            this.sonmeyvelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.sonmeyvelabel.Location = new System.Drawing.Point(697, 117);
            this.sonmeyvelabel.Name = "sonmeyvelabel";
            this.sonmeyvelabel.Size = new System.Drawing.Size(99, 22);
            this.sonmeyvelabel.TabIndex = 6;
            this.sonmeyvelabel.Text = "Son Meyve";
            // 
            // toplamlabel
            // 
            this.toplamlabel.AutoSize = true;
            this.toplamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.toplamlabel.Location = new System.Drawing.Point(813, 117);
            this.toplamlabel.Name = "toplamlabel";
            this.toplamlabel.Size = new System.Drawing.Size(70, 22);
            this.toplamlabel.TabIndex = 7;
            this.toplamlabel.Text = "Toplam";
            // 
            // agirliksonuclabel
            // 
            this.agirliksonuclabel.AutoSize = true;
            this.agirliksonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.agirliksonuclabel.Location = new System.Drawing.Point(725, 165);
            this.agirliksonuclabel.Name = "agirliksonuclabel";
            this.agirliksonuclabel.Size = new System.Drawing.Size(12, 16);
            this.agirliksonuclabel.TabIndex = 8;
            this.agirliksonuclabel.Text = "-";
            // 
            // tagirliksonuclabel
            // 
            this.tagirliksonuclabel.AutoSize = true;
            this.tagirliksonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tagirliksonuclabel.Location = new System.Drawing.Point(831, 165);
            this.tagirliksonuclabel.Name = "tagirliksonuclabel";
            this.tagirliksonuclabel.Size = new System.Drawing.Size(12, 16);
            this.tagirliksonuclabel.TabIndex = 9;
            this.tagirliksonuclabel.Text = "-";
            // 
            // vitaminasonuclabel
            // 
            this.vitaminasonuclabel.AutoSize = true;
            this.vitaminasonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.vitaminasonuclabel.Location = new System.Drawing.Point(725, 194);
            this.vitaminasonuclabel.Name = "vitaminasonuclabel";
            this.vitaminasonuclabel.Size = new System.Drawing.Size(12, 16);
            this.vitaminasonuclabel.TabIndex = 10;
            this.vitaminasonuclabel.Text = "-";
            // 
            // vitamincsonuclabel
            // 
            this.vitamincsonuclabel.AutoSize = true;
            this.vitamincsonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.vitamincsonuclabel.Location = new System.Drawing.Point(725, 224);
            this.vitamincsonuclabel.Name = "vitamincsonuclabel";
            this.vitamincsonuclabel.Size = new System.Drawing.Size(12, 16);
            this.vitamincsonuclabel.TabIndex = 11;
            this.vitamincsonuclabel.Text = "-";
            // 
            // tvitaminasonuclabel
            // 
            this.tvitaminasonuclabel.AutoSize = true;
            this.tvitaminasonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tvitaminasonuclabel.Location = new System.Drawing.Point(831, 194);
            this.tvitaminasonuclabel.Name = "tvitaminasonuclabel";
            this.tvitaminasonuclabel.Size = new System.Drawing.Size(12, 16);
            this.tvitaminasonuclabel.TabIndex = 12;
            this.tvitaminasonuclabel.Text = "-";
            // 
            // tvitamincsonuclabel
            // 
            this.tvitamincsonuclabel.AutoSize = true;
            this.tvitamincsonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tvitamincsonuclabel.Location = new System.Drawing.Point(831, 224);
            this.tvitamincsonuclabel.Name = "tvitamincsonuclabel";
            this.tvitamincsonuclabel.Size = new System.Drawing.Size(12, 16);
            this.tvitamincsonuclabel.TabIndex = 13;
            this.tvitamincsonuclabel.Text = "-";
            // 
            // sivisonuclabel
            // 
            this.sivisonuclabel.AutoSize = true;
            this.sivisonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.sivisonuclabel.Location = new System.Drawing.Point(725, 253);
            this.sivisonuclabel.Name = "sivisonuclabel";
            this.sivisonuclabel.Size = new System.Drawing.Size(12, 16);
            this.sivisonuclabel.TabIndex = 14;
            this.sivisonuclabel.Text = "-";
            // 
            // tsivisonuclabel
            // 
            this.tsivisonuclabel.AutoSize = true;
            this.tsivisonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tsivisonuclabel.Location = new System.Drawing.Point(831, 254);
            this.tsivisonuclabel.Name = "tsivisonuclabel";
            this.tsivisonuclabel.Size = new System.Drawing.Size(12, 16);
            this.tsivisonuclabel.TabIndex = 15;
            this.tsivisonuclabel.Text = "-";
            // 
            // puresonuclabel
            // 
            this.puresonuclabel.AutoSize = true;
            this.puresonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.puresonuclabel.Location = new System.Drawing.Point(725, 287);
            this.puresonuclabel.Name = "puresonuclabel";
            this.puresonuclabel.Size = new System.Drawing.Size(12, 16);
            this.puresonuclabel.TabIndex = 16;
            this.puresonuclabel.Text = "-";
            // 
            // tpuresonuclabel
            // 
            this.tpuresonuclabel.AutoSize = true;
            this.tpuresonuclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tpuresonuclabel.Location = new System.Drawing.Point(831, 286);
            this.tpuresonuclabel.Name = "tpuresonuclabel";
            this.tpuresonuclabel.Size = new System.Drawing.Size(12, 16);
            this.tpuresonuclabel.TabIndex = 17;
            this.tpuresonuclabel.Text = "-";
            // 
            // uyarilabel
            // 
            this.uyarilabel.AutoSize = true;
            this.uyarilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.uyarilabel.ForeColor = System.Drawing.Color.Red;
            this.uyarilabel.Location = new System.Drawing.Point(582, 405);
            this.uyarilabel.Name = "uyarilabel";
            this.uyarilabel.Size = new System.Drawing.Size(0, 25);
            this.uyarilabel.TabIndex = 18;
            // 
            // sıvısıkacak
            // 
            this.sıvısıkacak.AutoSize = true;
            this.sıvısıkacak.Location = new System.Drawing.Point(6, 28);
            this.sıvısıkacak.Name = "sıvısıkacak";
            this.sıvısıkacak.Size = new System.Drawing.Size(121, 17);
            this.sıvısıkacak.TabIndex = 19;
            this.sıvısıkacak.TabStop = true;
            this.sıvısıkacak.Text = "Sıvı Meyve Sıkacağı";
            this.sıvısıkacak.UseVisualStyleBackColor = true;
            // 
            // katısıkacak
            // 
            this.katısıkacak.AutoSize = true;
            this.katısıkacak.Location = new System.Drawing.Point(149, 28);
            this.katısıkacak.Name = "katısıkacak";
            this.katısıkacak.Size = new System.Drawing.Size(122, 17);
            this.katısıkacak.TabIndex = 20;
            this.katısıkacak.TabStop = true;
            this.katısıkacak.Text = "Katı Meyve Sıkacağı";
            this.katısıkacak.UseVisualStyleBackColor = true;
            // 
            // radiogroup
            // 
            this.radiogroup.Controls.Add(this.sıvısıkacak);
            this.radiogroup.Controls.Add(this.katısıkacak);
            this.radiogroup.Controls.Add(this.suremeyvelabel);
            this.radiogroup.Location = new System.Drawing.Point(101, 501);
            this.radiogroup.Name = "radiogroup";
            this.radiogroup.Size = new System.Drawing.Size(417, 89);
            this.radiogroup.TabIndex = 21;
            this.radiogroup.TabStop = false;
            this.radiogroup.Text = "Sıkacak seç";
            // 
            // suremeyvelabel
            // 
            this.suremeyvelabel.AutoSize = true;
            this.suremeyvelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.suremeyvelabel.Location = new System.Drawing.Point(336, 29);
            this.suremeyvelabel.Name = "suremeyvelabel";
            this.suremeyvelabel.Size = new System.Drawing.Size(19, 25);
            this.suremeyvelabel.TabIndex = 23;
            this.suremeyvelabel.Text = "-";
            // 
            // surelabel
            // 
            this.surelabel.AutoSize = true;
            this.surelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.surelabel.Location = new System.Drawing.Point(749, 501);
            this.surelabel.Name = "surelabel";
            this.surelabel.Size = new System.Drawing.Size(19, 25);
            this.surelabel.TabIndex = 22;
            this.surelabel.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.ToplamTimer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.MeyveTimer_Tick);
            // 
            // resimler
            // 
            this.resimler.BackColor = System.Drawing.SystemColors.Control;
            this.resimler.Location = new System.Drawing.Point(101, 117);
            this.resimler.Name = "resimler";
            this.resimler.Size = new System.Drawing.Size(334, 331);
            this.resimler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimler.TabIndex = 24;
            this.resimler.TabStop = false;
            // 
            // resimlist
            // 
            this.resimlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("resimlist.ImageStream")));
            this.resimlist.TransparentColor = System.Drawing.Color.Transparent;
            this.resimlist.Images.SetKeyName(0, "Portakal.jpg");
            this.resimlist.Images.SetKeyName(1, "Mandalina.jpg");
            this.resimlist.Images.SetKeyName(2, "Greyfurt.jpg");
            this.resimlist.Images.SetKeyName(3, "Elma.jpg");
            this.resimlist.Images.SetKeyName(4, "Armut.jpg");
            this.resimlist.Images.SetKeyName(5, "Çilek.jpg");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(85, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Her bir meyve için 6 saniyen var. Süre dolmadan her periyotta sıkacak seç!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(396, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "Meyve Sepeti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resimler);
            this.Controls.Add(this.surelabel);
            this.Controls.Add(this.radiogroup);
            this.Controls.Add(this.uyarilabel);
            this.Controls.Add(this.tpuresonuclabel);
            this.Controls.Add(this.puresonuclabel);
            this.Controls.Add(this.tsivisonuclabel);
            this.Controls.Add(this.sivisonuclabel);
            this.Controls.Add(this.tvitamincsonuclabel);
            this.Controls.Add(this.tvitaminasonuclabel);
            this.Controls.Add(this.vitamincsonuclabel);
            this.Controls.Add(this.vitaminasonuclabel);
            this.Controls.Add(this.tagirliksonuclabel);
            this.Controls.Add(this.agirliksonuclabel);
            this.Controls.Add(this.toplamlabel);
            this.Controls.Add(this.sonmeyvelabel);
            this.Controls.Add(this.purelabel);
            this.Controls.Add(this.sivilabel);
            this.Controls.Add(this.vitaminclabel);
            this.Controls.Add(this.vitaminalabel);
            this.Controls.Add(this.agirliklabel);
            this.Controls.Add(this.baslabutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.radiogroup.ResumeLayout(false);
            this.radiogroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslabutton;
        private System.Windows.Forms.Label agirliklabel;
        private System.Windows.Forms.Label vitaminalabel;
        private System.Windows.Forms.Label sivilabel;
        private System.Windows.Forms.Label vitaminclabel;
        private System.Windows.Forms.Label purelabel;
        private System.Windows.Forms.Label sonmeyvelabel;
        private System.Windows.Forms.Label toplamlabel;
        private System.Windows.Forms.Label agirliksonuclabel;
        private System.Windows.Forms.Label tagirliksonuclabel;
        private System.Windows.Forms.Label vitaminasonuclabel;
        private System.Windows.Forms.Label vitamincsonuclabel;
        private System.Windows.Forms.Label tvitaminasonuclabel;
        private System.Windows.Forms.Label tvitamincsonuclabel;
        private System.Windows.Forms.Label sivisonuclabel;
        private System.Windows.Forms.Label tsivisonuclabel;
        private System.Windows.Forms.Label puresonuclabel;
        private System.Windows.Forms.Label tpuresonuclabel;
        private System.Windows.Forms.Label uyarilabel;
        private System.Windows.Forms.RadioButton sıvısıkacak;
        private System.Windows.Forms.RadioButton katısıkacak;
        private System.Windows.Forms.GroupBox radiogroup;
        private System.Windows.Forms.Label surelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label suremeyvelabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox resimler;
        private System.Windows.Forms.ImageList resimlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

