namespace doviz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dolarAlisText = new System.Windows.Forms.Label();
            this.dolarSatisText = new System.Windows.Forms.Label();
            this.euroSatisText = new System.Windows.Forms.Label();
            this.euroAlisText = new System.Windows.Forms.Label();
            this.frankAlisText = new System.Windows.Forms.Label();
            this.sterlinAlisText = new System.Windows.Forms.Label();
            this.frankSatisText = new System.Windows.Forms.Label();
            this.sterlinSatisText = new System.Windows.Forms.Label();
            this.dinarSatisText = new System.Windows.Forms.Label();
            this.dinarAlisText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(65, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Euro Alış :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(65, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(181, 32);
            this.label22.TabIndex = 0;
            this.label22.Text = "Dolar Satış :";
            this.label22.Click += new System.EventHandler(this.dolarSatis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(65, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sterlin Alış :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(65, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Euro Satış :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(65, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sterlin Satış :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(65, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Frank Alış :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(65, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Frank Satış :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(65, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dinar Alış :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(65, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Dinar Satış :";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // dolarAlisText
            // 
            this.dolarAlisText.AutoSize = true;
            this.dolarAlisText.BackColor = System.Drawing.Color.Transparent;
            this.dolarAlisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dolarAlisText.ForeColor = System.Drawing.Color.Yellow;
            this.dolarAlisText.Location = new System.Drawing.Point(328, 63);
            this.dolarAlisText.Name = "dolarAlisText";
            this.dolarAlisText.Size = new System.Drawing.Size(115, 32);
            this.dolarAlisText.TabIndex = 1;
            this.dolarAlisText.Text = "label11";
            // 
            // dolarSatisText
            // 
            this.dolarSatisText.AutoSize = true;
            this.dolarSatisText.BackColor = System.Drawing.Color.Transparent;
            this.dolarSatisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dolarSatisText.ForeColor = System.Drawing.Color.Yellow;
            this.dolarSatisText.Location = new System.Drawing.Point(328, 120);
            this.dolarSatisText.Name = "dolarSatisText";
            this.dolarSatisText.Size = new System.Drawing.Size(115, 32);
            this.dolarSatisText.TabIndex = 1;
            this.dolarSatisText.Text = "label11";
            // 
            // euroSatisText
            // 
            this.euroSatisText.AutoSize = true;
            this.euroSatisText.BackColor = System.Drawing.Color.Transparent;
            this.euroSatisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.euroSatisText.ForeColor = System.Drawing.Color.Yellow;
            this.euroSatisText.Location = new System.Drawing.Point(328, 230);
            this.euroSatisText.Name = "euroSatisText";
            this.euroSatisText.Size = new System.Drawing.Size(115, 32);
            this.euroSatisText.TabIndex = 1;
            this.euroSatisText.Text = "label11";
            // 
            // euroAlisText
            // 
            this.euroAlisText.AutoSize = true;
            this.euroAlisText.BackColor = System.Drawing.Color.Transparent;
            this.euroAlisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.euroAlisText.ForeColor = System.Drawing.Color.Yellow;
            this.euroAlisText.Location = new System.Drawing.Point(328, 176);
            this.euroAlisText.Name = "euroAlisText";
            this.euroAlisText.Size = new System.Drawing.Size(115, 32);
            this.euroAlisText.TabIndex = 1;
            this.euroAlisText.Text = "label11";
            // 
            // frankAlisText
            // 
            this.frankAlisText.AutoSize = true;
            this.frankAlisText.BackColor = System.Drawing.Color.Transparent;
            this.frankAlisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frankAlisText.ForeColor = System.Drawing.Color.Yellow;
            this.frankAlisText.Location = new System.Drawing.Point(328, 406);
            this.frankAlisText.Name = "frankAlisText";
            this.frankAlisText.Size = new System.Drawing.Size(115, 32);
            this.frankAlisText.TabIndex = 1;
            this.frankAlisText.Text = "label11";
            // 
            // sterlinAlisText
            // 
            this.sterlinAlisText.AutoSize = true;
            this.sterlinAlisText.BackColor = System.Drawing.Color.Transparent;
            this.sterlinAlisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sterlinAlisText.ForeColor = System.Drawing.Color.Yellow;
            this.sterlinAlisText.Location = new System.Drawing.Point(328, 290);
            this.sterlinAlisText.Name = "sterlinAlisText";
            this.sterlinAlisText.Size = new System.Drawing.Size(115, 32);
            this.sterlinAlisText.TabIndex = 1;
            this.sterlinAlisText.Text = "label11";
            // 
            // frankSatisText
            // 
            this.frankSatisText.AutoSize = true;
            this.frankSatisText.BackColor = System.Drawing.Color.Transparent;
            this.frankSatisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frankSatisText.ForeColor = System.Drawing.Color.Yellow;
            this.frankSatisText.Location = new System.Drawing.Point(328, 467);
            this.frankSatisText.Name = "frankSatisText";
            this.frankSatisText.Size = new System.Drawing.Size(115, 32);
            this.frankSatisText.TabIndex = 1;
            this.frankSatisText.Text = "label11";
            // 
            // sterlinSatisText
            // 
            this.sterlinSatisText.AutoSize = true;
            this.sterlinSatisText.BackColor = System.Drawing.Color.Transparent;
            this.sterlinSatisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sterlinSatisText.ForeColor = System.Drawing.Color.Yellow;
            this.sterlinSatisText.Location = new System.Drawing.Point(328, 349);
            this.sterlinSatisText.Name = "sterlinSatisText";
            this.sterlinSatisText.Size = new System.Drawing.Size(115, 32);
            this.sterlinSatisText.TabIndex = 1;
            this.sterlinSatisText.Text = "label11";
            // 
            // dinarSatisText
            // 
            this.dinarSatisText.AutoSize = true;
            this.dinarSatisText.BackColor = System.Drawing.Color.Transparent;
            this.dinarSatisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dinarSatisText.ForeColor = System.Drawing.Color.Yellow;
            this.dinarSatisText.Location = new System.Drawing.Point(328, 583);
            this.dinarSatisText.Name = "dinarSatisText";
            this.dinarSatisText.Size = new System.Drawing.Size(115, 32);
            this.dinarSatisText.TabIndex = 1;
            this.dinarSatisText.Text = "label11";
            // 
            // dinarAlisText
            // 
            this.dinarAlisText.AutoSize = true;
            this.dinarAlisText.BackColor = System.Drawing.Color.Transparent;
            this.dinarAlisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dinarAlisText.ForeColor = System.Drawing.Color.Yellow;
            this.dinarAlisText.Location = new System.Drawing.Point(328, 526);
            this.dinarAlisText.Name = "dinarAlisText";
            this.dinarAlisText.Size = new System.Drawing.Size(115, 32);
            this.dinarAlisText.TabIndex = 1;
            this.dinarAlisText.Text = "label11";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(777, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Döviz İşlemler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kalan :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(18, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Miktar :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(18, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tutar :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(18, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 32);
            this.label13.TabIndex = 4;
            this.label13.Text = "Kur :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(203, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(203, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 38);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(203, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 38);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(203, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 38);
            this.textBox4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(271, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "BOZDURMA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(504, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(504, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(504, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(504, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(504, 291);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 40);
            this.button7.TabIndex = 3;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(504, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "...";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(504, 407);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 40);
            this.button9.TabIndex = 3;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(504, 467);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 40);
            this.button10.TabIndex = 3;
            this.button10.Text = "...";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(504, 527);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 40);
            this.button11.TabIndex = 3;
            this.button11.Text = "...";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(504, 584);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 40);
            this.button12.TabIndex = 3;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 689);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.euroAlisText);
            this.Controls.Add(this.dinarAlisText);
            this.Controls.Add(this.dinarSatisText);
            this.Controls.Add(this.sterlinSatisText);
            this.Controls.Add(this.frankSatisText);
            this.Controls.Add(this.sterlinAlisText);
            this.Controls.Add(this.frankAlisText);
            this.Controls.Add(this.euroSatisText);
            this.Controls.Add(this.dolarSatisText);
            this.Controls.Add(this.dolarAlisText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Döviz Kuru İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dolarAlisText;
        private System.Windows.Forms.Label dolarSatisText;
        private System.Windows.Forms.Label euroSatisText;
        private System.Windows.Forms.Label euroAlisText;
        private System.Windows.Forms.Label frankAlisText;
        private System.Windows.Forms.Label sterlinAlisText;
        private System.Windows.Forms.Label frankSatisText;
        private System.Windows.Forms.Label sterlinSatisText;
        private System.Windows.Forms.Label dinarSatisText;
        private System.Windows.Forms.Label dinarAlisText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

