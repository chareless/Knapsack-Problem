
namespace Opti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.degerTextBox = new System.Windows.Forms.TextBox();
            this.kiloTextBox = new System.Windows.Forms.TextBox();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.esyaEkleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantaListView = new System.Windows.Forms.ListView();
            this.secilenListView = new System.Windows.Forms.ListView();
            this.sinirTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randomButton = new System.Windows.Forms.Button();
            this.karsilastirListView = new System.Windows.Forms.ListView();
            this.esyaSilButton = new System.Windows.Forms.Button();
            this.cokButton = new System.Windows.Forms.Button();
            this.hizliButton = new System.Windows.Forms.Button();
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.sinirButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iterButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.iterTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rCountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rKiloTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rDegerTextBox = new System.Windows.Forms.TextBox();
            this.cokEsyaButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // degerTextBox
            // 
            this.degerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degerTextBox.Location = new System.Drawing.Point(335, 52);
            this.degerTextBox.Name = "degerTextBox";
            this.degerTextBox.Size = new System.Drawing.Size(100, 22);
            this.degerTextBox.TabIndex = 2;
            this.degerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // kiloTextBox
            // 
            this.kiloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiloTextBox.Location = new System.Drawing.Point(216, 52);
            this.kiloTextBox.Name = "kiloTextBox";
            this.kiloTextBox.Size = new System.Drawing.Size(100, 22);
            this.kiloTextBox.TabIndex = 1;
            this.kiloTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // isimTextBox
            // 
            this.isimTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimTextBox.Location = new System.Drawing.Point(45, 52);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(146, 22);
            this.isimTextBox.TabIndex = 0;
            this.isimTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bosluk_giremez_KeyPress);
            // 
            // esyaEkleButton
            // 
            this.esyaEkleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.esyaEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esyaEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esyaEkleButton.Location = new System.Drawing.Point(335, 83);
            this.esyaEkleButton.Name = "esyaEkleButton";
            this.esyaEkleButton.Size = new System.Drawing.Size(100, 39);
            this.esyaEkleButton.TabIndex = 3;
            this.esyaEkleButton.Text = "Eşya Ekle";
            this.esyaEkleButton.UseVisualStyleBackColor = false;
            this.esyaEkleButton.Click += new System.EventHandler(this.esyaEkleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(337, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Değer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ağırlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eşya Adı";
            // 
            // cantaListView
            // 
            this.cantaListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cantaListView.HideSelection = false;
            this.cantaListView.Location = new System.Drawing.Point(45, 124);
            this.cantaListView.Margin = new System.Windows.Forms.Padding(2);
            this.cantaListView.Name = "cantaListView";
            this.cantaListView.Size = new System.Drawing.Size(271, 233);
            this.cantaListView.TabIndex = 9;
            this.cantaListView.UseCompatibleStateImageBehavior = false;
            this.cantaListView.View = System.Windows.Forms.View.Details;
            // 
            // secilenListView
            // 
            this.secilenListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secilenListView.HideSelection = false;
            this.secilenListView.Location = new System.Drawing.Point(474, 83);
            this.secilenListView.Margin = new System.Windows.Forms.Padding(2);
            this.secilenListView.Name = "secilenListView";
            this.secilenListView.Size = new System.Drawing.Size(490, 233);
            this.secilenListView.TabIndex = 11;
            this.secilenListView.UseCompatibleStateImageBehavior = false;
            this.secilenListView.View = System.Windows.Forms.View.Details;
            // 
            // sinirTextBox
            // 
            this.sinirTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinirTextBox.Location = new System.Drawing.Point(44, 642);
            this.sinirTextBox.Name = "sinirTextBox";
            this.sinirTextBox.Size = new System.Drawing.Size(112, 22);
            this.sinirTextBox.TabIndex = 4;
            this.sinirTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kilo Sınırı";
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomButton.Location = new System.Drawing.Point(340, 311);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(100, 46);
            this.randomButton.TabIndex = 7;
            this.randomButton.Text = "Rastgele Eşya Ekle";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // karsilastirListView
            // 
            this.karsilastirListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karsilastirListView.HideSelection = false;
            this.karsilastirListView.Location = new System.Drawing.Point(474, 381);
            this.karsilastirListView.Margin = new System.Windows.Forms.Padding(2);
            this.karsilastirListView.Name = "karsilastirListView";
            this.karsilastirListView.Size = new System.Drawing.Size(699, 355);
            this.karsilastirListView.TabIndex = 17;
            this.karsilastirListView.UseCompatibleStateImageBehavior = false;
            this.karsilastirListView.View = System.Windows.Forms.View.Details;
            this.karsilastirListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            // 
            // esyaSilButton
            // 
            this.esyaSilButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.esyaSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esyaSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esyaSilButton.Location = new System.Drawing.Point(335, 510);
            this.esyaSilButton.Name = "esyaSilButton";
            this.esyaSilButton.Size = new System.Drawing.Size(100, 38);
            this.esyaSilButton.TabIndex = 6;
            this.esyaSilButton.Text = "Eşyaları Sil";
            this.esyaSilButton.UseVisualStyleBackColor = false;
            this.esyaSilButton.Click += new System.EventHandler(this.esyaSilButton_Click);
            // 
            // cokButton
            // 
            this.cokButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cokButton.Enabled = false;
            this.cokButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cokButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cokButton.Location = new System.Drawing.Point(1042, 259);
            this.cokButton.Name = "cokButton";
            this.cokButton.Size = new System.Drawing.Size(131, 57);
            this.cokButton.TabIndex = 13;
            this.cokButton.Text = "Çoklu Çalıştır (iterasyon)";
            this.cokButton.UseVisualStyleBackColor = false;
            this.cokButton.Click += new System.EventHandler(this.cokButton_Click);
            // 
            // hizliButton
            // 
            this.hizliButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hizliButton.Enabled = false;
            this.hizliButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hizliButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizliButton.Location = new System.Drawing.Point(1042, 84);
            this.hizliButton.Name = "hizliButton";
            this.hizliButton.Size = new System.Drawing.Size(131, 57);
            this.hizliButton.TabIndex = 12;
            this.hizliButton.Text = "Hızlı Çalıştır";
            this.hizliButton.UseVisualStyleBackColor = false;
            this.hizliButton.Click += new System.EventHandler(this.hizliButton_Click);
            // 
            // sifirlaButton
            // 
            this.sifirlaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sifirlaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifirlaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirlaButton.Location = new System.Drawing.Point(335, 560);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(100, 38);
            this.sifirlaButton.TabIndex = 14;
            this.sifirlaButton.Text = "Sıfırla";
            this.sifirlaButton.UseVisualStyleBackColor = false;
            this.sifirlaButton.Click += new System.EventHandler(this.sifirlaButton_Click);
            // 
            // sinirButton
            // 
            this.sinirButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sinirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sinirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinirButton.Location = new System.Drawing.Point(44, 686);
            this.sinirButton.Name = "sinirButton";
            this.sinirButton.Size = new System.Drawing.Size(113, 50);
            this.sinirButton.TabIndex = 5;
            this.sinirButton.Text = "Kilo Sınırı Koy";
            this.sinirButton.UseVisualStyleBackColor = false;
            this.sinirButton.Click += new System.EventHandler(this.sinirButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(468, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Seçilen Rastgele Eşyalar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Eşya Çantası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(468, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sonuç Tablosu";
            // 
            // iterButton
            // 
            this.iterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iterButton.Location = new System.Drawing.Point(204, 686);
            this.iterButton.Name = "iterButton";
            this.iterButton.Size = new System.Drawing.Size(112, 50);
            this.iterButton.TabIndex = 29;
            this.iterButton.Text = "İterasyon Sayısı Değiştir";
            this.iterButton.UseVisualStyleBackColor = false;
            this.iterButton.Click += new System.EventHandler(this.iterButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(201, 623);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "İterasyon Sayısı";
            // 
            // iterTextBox
            // 
            this.iterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iterTextBox.Location = new System.Drawing.Point(204, 642);
            this.iterTextBox.Name = "iterTextBox";
            this.iterTextBox.Size = new System.Drawing.Size(112, 22);
            this.iterTextBox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(337, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Eşya Adedi";
            // 
            // rCountTextBox
            // 
            this.rCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rCountTextBox.Location = new System.Drawing.Point(340, 155);
            this.rCountTextBox.Name = "rCountTextBox";
            this.rCountTextBox.Size = new System.Drawing.Size(100, 22);
            this.rCountTextBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(337, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Maks Kilo";
            // 
            // rKiloTextBox
            // 
            this.rKiloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rKiloTextBox.Location = new System.Drawing.Point(340, 217);
            this.rKiloTextBox.Name = "rKiloTextBox";
            this.rKiloTextBox.Size = new System.Drawing.Size(100, 22);
            this.rKiloTextBox.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(337, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Maks Değer";
            // 
            // rDegerTextBox
            // 
            this.rDegerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rDegerTextBox.Location = new System.Drawing.Point(340, 274);
            this.rDegerTextBox.Name = "rDegerTextBox";
            this.rDegerTextBox.Size = new System.Drawing.Size(100, 22);
            this.rDegerTextBox.TabIndex = 35;
            // 
            // cokEsyaButton
            // 
            this.cokEsyaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cokEsyaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cokEsyaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cokEsyaButton.Location = new System.Drawing.Point(335, 392);
            this.cokEsyaButton.Name = "cokEsyaButton";
            this.cokEsyaButton.Size = new System.Drawing.Size(100, 46);
            this.cokEsyaButton.TabIndex = 37;
            this.cokEsyaButton.Text = "Çoklu Eşya Ekle";
            this.cokEsyaButton.UseVisualStyleBackColor = false;
            this.cokEsyaButton.Click += new System.EventHandler(this.cokEsyaButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(44, 392);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 206);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cokEsyaButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rDegerTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rKiloTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rCountTextBox);
            this.Controls.Add(this.iterButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iterTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sinirButton);
            this.Controls.Add(this.sifirlaButton);
            this.Controls.Add(this.hizliButton);
            this.Controls.Add(this.cokButton);
            this.Controls.Add(this.esyaSilButton);
            this.Controls.Add(this.karsilastirListView);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinirTextBox);
            this.Controls.Add(this.secilenListView);
            this.Controls.Add(this.cantaListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esyaEkleButton);
            this.Controls.Add(this.isimTextBox);
            this.Controls.Add(this.kiloTextBox);
            this.Controls.Add(this.degerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sırt Çantası Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox degerTextBox;
        private System.Windows.Forms.TextBox kiloTextBox;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.Button esyaEkleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView cantaListView;
        private System.Windows.Forms.ListView secilenListView;
        private System.Windows.Forms.TextBox sinirTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.ListView karsilastirListView;
        private System.Windows.Forms.Button esyaSilButton;
        private System.Windows.Forms.Button cokButton;
        private System.Windows.Forms.Button hizliButton;
        private System.Windows.Forms.Button sifirlaButton;
        private System.Windows.Forms.Button sinirButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button iterButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iterTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rCountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rKiloTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rDegerTextBox;
        private System.Windows.Forms.Button cokEsyaButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

