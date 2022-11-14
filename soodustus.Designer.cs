namespace DB_valkrusman
{
    partial class soodustus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tootehind = new System.Windows.Forms.TextBox();
            this.muugiHind = new System.Windows.Forms.TextBox();
            this.hindAlla = new System.Windows.Forms.TextBox();
            this.soodus = new System.Windows.Forms.TextBox();
            this.arvuta = new System.Windows.Forms.Button();
            this.valju = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toote õige hind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soodustus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soodustus %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müügihind";
            // 
            // tootehind
            // 
            this.tootehind.Location = new System.Drawing.Point(236, 75);
            this.tootehind.Name = "tootehind";
            this.tootehind.Size = new System.Drawing.Size(100, 20);
            this.tootehind.TabIndex = 4;
            // 
            // muugiHind
            // 
            this.muugiHind.Enabled = false;
            this.muugiHind.Location = new System.Drawing.Point(236, 284);
            this.muugiHind.Name = "muugiHind";
            this.muugiHind.Size = new System.Drawing.Size(100, 20);
            this.muugiHind.TabIndex = 5;
            // 
            // hindAlla
            // 
            this.hindAlla.Enabled = false;
            this.hindAlla.Location = new System.Drawing.Point(236, 240);
            this.hindAlla.Name = "hindAlla";
            this.hindAlla.Size = new System.Drawing.Size(100, 20);
            this.hindAlla.TabIndex = 6;
            // 
            // soodus
            // 
            this.soodus.Location = new System.Drawing.Point(236, 117);
            this.soodus.Name = "soodus";
            this.soodus.Size = new System.Drawing.Size(100, 20);
            this.soodus.TabIndex = 7;
            // 
            // arvuta
            // 
            this.arvuta.Location = new System.Drawing.Point(125, 174);
            this.arvuta.Name = "arvuta";
            this.arvuta.Size = new System.Drawing.Size(75, 23);
            this.arvuta.TabIndex = 8;
            this.arvuta.Text = "Arvuta";
            this.arvuta.UseVisualStyleBackColor = true;
            this.arvuta.Click += new System.EventHandler(this.arvuta_Click);
            // 
            // valju
            // 
            this.valju.Location = new System.Drawing.Point(236, 174);
            this.valju.Name = "valju";
            this.valju.Size = new System.Drawing.Size(75, 23);
            this.valju.TabIndex = 9;
            this.valju.Text = "Välju";
            this.valju.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tee meie kliendikaart ja saa kuni 50% soodustust!!";
            // 
            // soodustus
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valju);
            this.Controls.Add(this.arvuta);
            this.Controls.Add(this.soodus);
            this.Controls.Add(this.hindAlla);
            this.Controls.Add(this.muugiHind);
            this.Controls.Add(this.tootehind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "soodustus";
            this.Text = "Soodustused";
            this.Load += new System.EventHandler(this.soodustus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tootehind;
        private System.Windows.Forms.TextBox muugiHind;
        private System.Windows.Forms.TextBox hindAlla;
        private System.Windows.Forms.TextBox soodus;
        private System.Windows.Forms.Button arvuta;
        private System.Windows.Forms.Button valju;
        private System.Windows.Forms.Label label5;
    }
}