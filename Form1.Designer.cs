namespace WindowsFormsApp2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdOyunAlanı = new System.Windows.Forms.DataGridView();
            this.grpHarita = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSkor = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOyunAlanı)).BeginInit();
            this.grpHarita.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdOyunAlanı
            // 
            this.grdOyunAlanı.AllowUserToAddRows = false;
            this.grdOyunAlanı.AllowUserToDeleteRows = false;
            this.grdOyunAlanı.AllowUserToOrderColumns = true;
            this.grdOyunAlanı.AllowUserToResizeColumns = false;
            this.grdOyunAlanı.AllowUserToResizeRows = false;
            this.grdOyunAlanı.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOyunAlanı.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOyunAlanı.ColumnHeadersHeight = 5;
            this.grdOyunAlanı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdOyunAlanı.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOyunAlanı.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdOyunAlanı.Location = new System.Drawing.Point(12, 12);
            this.grdOyunAlanı.MultiSelect = false;
            this.grdOyunAlanı.Name = "grdOyunAlanı";
            this.grdOyunAlanı.ReadOnly = true;
            this.grdOyunAlanı.RowHeadersVisible = false;
            this.grdOyunAlanı.RowHeadersWidth = 5;
            this.grdOyunAlanı.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grdOyunAlanı.Size = new System.Drawing.Size(314, 314);
            this.grdOyunAlanı.TabIndex = 0;
            this.grdOyunAlanı.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOyunAlanı_CellClick);
            this.grdOyunAlanı.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.grdOyunAlanı_CellStateChanged);
            // 
            // grpHarita
            // 
            this.grpHarita.Controls.Add(this.radioButton5);
            this.grpHarita.Controls.Add(this.radioButton4);
            this.grpHarita.Controls.Add(this.radioButton3);
            this.grpHarita.Controls.Add(this.radioButton2);
            this.grpHarita.Controls.Add(this.radioButton1);
            this.grpHarita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHarita.Location = new System.Drawing.Point(345, 12);
            this.grpHarita.Name = "grpHarita";
            this.grpHarita.Size = new System.Drawing.Size(214, 145);
            this.grpHarita.TabIndex = 1;
            this.grpHarita.TabStop = false;
            this.grpHarita.Text = "Harita";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton5.Location = new System.Drawing.Point(105, 75);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 21);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "9x9";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton4.Location = new System.Drawing.Point(105, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "8x8";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(18, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "7x7";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(18, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "6x6";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(18, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5x5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(345, 209);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(214, 47);
            this.btnBaslat.TabIndex = 5;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnSkor
            // 
            this.btnSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSkor.Location = new System.Drawing.Point(345, 271);
            this.btnSkor.Name = "btnSkor";
            this.btnSkor.Size = new System.Drawing.Size(214, 55);
            this.btnSkor.TabIndex = 6;
            this.btnSkor.Text = "EN İYİ SKORLAR";
            this.btnSkor.UseVisualStyleBackColor = true;
            this.btnSkor.Click += new System.EventHandler(this.btnSkor_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(420, 175);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(139, 20);
            this.txtIsim.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(342, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "İsminiz :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnSkor);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.grpHarita);
            this.Controls.Add(this.grdOyunAlanı);
            this.Name = "Form1";
            this.Text = "999";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOyunAlanı)).EndInit();
            this.grpHarita.ResumeLayout(false);
            this.grpHarita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOyunAlanı;
        private System.Windows.Forms.GroupBox grpHarita;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnSkor;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
    }
}

