namespace DB_valkrusman
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toode_txt = new System.Windows.Forms.TextBox();
            this.hind_txt = new System.Windows.Forms.TextBox();
            this.kogus_txt = new System.Windows.Forms.TextBox();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.Kategooria_lbl = new System.Windows.Forms.Label();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Toode_gb = new System.Windows.Forms.PictureBox();
            this.Otsi_btn = new System.Windows.Forms.Button();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.Uuenda_btn = new System.Windows.Forms.Button();
            this.Kustuta_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kat_cbox = new System.Windows.Forms.ComboBox();
            this.Lisa_kat_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_gb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toode_txt
            // 
            this.toode_txt.Location = new System.Drawing.Point(206, 55);
            this.toode_txt.Name = "toode_txt";
            this.toode_txt.Size = new System.Drawing.Size(130, 20);
            this.toode_txt.TabIndex = 0;
            this.toode_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hind_txt
            // 
            this.hind_txt.Location = new System.Drawing.Point(206, 136);
            this.hind_txt.Name = "hind_txt";
            this.hind_txt.Size = new System.Drawing.Size(130, 20);
            this.hind_txt.TabIndex = 1;
            // 
            // kogus_txt
            // 
            this.kogus_txt.Location = new System.Drawing.Point(206, 100);
            this.kogus_txt.Name = "kogus_txt";
            this.kogus_txt.Size = new System.Drawing.Size(130, 20);
            this.kogus_txt.TabIndex = 2;
            this.kogus_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Location = new System.Drawing.Point(71, 60);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(77, 13);
            this.Toode_lbl.TabIndex = 3;
            this.Toode_lbl.Text = "Toode nimetus";
            this.Toode_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kategooria_lbl
            // 
            this.Kategooria_lbl.AutoSize = true;
            this.Kategooria_lbl.Location = new System.Drawing.Point(71, 175);
            this.Kategooria_lbl.Name = "Kategooria_lbl";
            this.Kategooria_lbl.Size = new System.Drawing.Size(58, 13);
            this.Kategooria_lbl.TabIndex = 4;
            this.Kategooria_lbl.Text = "Kategooria";
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Location = new System.Drawing.Point(71, 136);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(29, 13);
            this.Hind_lbl.TabIndex = 5;
            this.Hind_lbl.Text = "Hind";
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Location = new System.Drawing.Point(71, 100);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(37, 13);
            this.Kogus_lbl.TabIndex = 6;
            this.Kogus_lbl.Text = "Kogus";
            this.Kogus_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // Toode_gb
            // 
            this.Toode_gb.Location = new System.Drawing.Point(414, 60);
            this.Toode_gb.Name = "Toode_gb";
            this.Toode_gb.Size = new System.Drawing.Size(224, 152);
            this.Toode_gb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toode_gb.TabIndex = 8;
            this.Toode_gb.TabStop = false;
            this.Toode_gb.Click += new System.EventHandler(this.Toode_gb_Click);
            // 
            // Otsi_btn
            // 
            this.Otsi_btn.Location = new System.Drawing.Point(644, 165);
            this.Otsi_btn.Name = "Otsi_btn";
            this.Otsi_btn.Size = new System.Drawing.Size(92, 30);
            this.Otsi_btn.TabIndex = 9;
            this.Otsi_btn.Text = "Otsi fail";
            this.Otsi_btn.UseVisualStyleBackColor = true;
            this.Otsi_btn.Click += new System.EventHandler(this.Otsi_btn_Click);
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Location = new System.Drawing.Point(405, 218);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(92, 30);
            this.Lisa_btn.TabIndex = 10;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // Uuenda_btn
            // 
            this.Uuenda_btn.Location = new System.Drawing.Point(503, 218);
            this.Uuenda_btn.Name = "Uuenda_btn";
            this.Uuenda_btn.Size = new System.Drawing.Size(92, 30);
            this.Uuenda_btn.TabIndex = 11;
            this.Uuenda_btn.Text = "Uuenda";
            this.Uuenda_btn.UseVisualStyleBackColor = true;
            // 
            // Kustuta_btn
            // 
            this.Kustuta_btn.Location = new System.Drawing.Point(602, 218);
            this.Kustuta_btn.Name = "Kustuta_btn";
            this.Kustuta_btn.Size = new System.Drawing.Size(92, 30);
            this.Kustuta_btn.TabIndex = 12;
            this.Kustuta_btn.Text = "Kustuta";
            this.Kustuta_btn.UseVisualStyleBackColor = true;
            this.Kustuta_btn.Click += new System.EventHandler(this.Kustuta_btn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(56, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 179);
            this.dataGridView1.TabIndex = 13;
            // 
            // Kat_cbox
            // 
            this.Kat_cbox.FormattingEnabled = true;
            this.Kat_cbox.Location = new System.Drawing.Point(206, 175);
            this.Kat_cbox.Name = "Kat_cbox";
            this.Kat_cbox.Size = new System.Drawing.Size(130, 21);
            this.Kat_cbox.TabIndex = 14;
            // 
            // Lisa_kat_btn
            // 
            this.Lisa_kat_btn.Location = new System.Drawing.Point(307, 218);
            this.Lisa_kat_btn.Name = "Lisa_kat_btn";
            this.Lisa_kat_btn.Size = new System.Drawing.Size(92, 30);
            this.Lisa_kat_btn.TabIndex = 15;
            this.Lisa_kat_btn.Text = "Lisa kategooria";
            this.Lisa_kat_btn.UseVisualStyleBackColor = true;
            this.Lisa_kat_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.Lisa_kat_btn);
            this.Controls.Add(this.Kat_cbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Kustuta_btn);
            this.Controls.Add(this.Uuenda_btn);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.Otsi_btn);
            this.Controls.Add(this.Toode_gb);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Kategooria_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Controls.Add(this.kogus_txt);
            this.Controls.Add(this.hind_txt);
            this.Controls.Add(this.toode_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Name = "Form1";
            this.Text = "Tooded";
            ((System.ComponentModel.ISupportInitialize)(this.Toode_gb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toode_txt;
        private System.Windows.Forms.TextBox hind_txt;
        private System.Windows.Forms.TextBox kogus_txt;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Label Kategooria_lbl;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.PictureBox Toode_gb;
        private System.Windows.Forms.Button Otsi_btn;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Button Uuenda_btn;
        private System.Windows.Forms.Button Kustuta_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Kat_cbox;
        private System.Windows.Forms.Button Lisa_kat_btn;
    }
}

