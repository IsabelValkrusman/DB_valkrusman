using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_valkrusman
{
    public partial class Soodus: Form
    {


       
        public Soodus()
        {
            InitializeComponent();

        }

  
        private void Soodus_Load(object sender, EventArgs e)
        {

        }


















        private void InitializeComponent()
        {
            this.soodus0 = new System.Windows.Forms.RadioButton();
            this.soodus10 = new System.Windows.Forms.RadioButton();
            this.soodus20 = new System.Windows.Forms.RadioButton();
            this.soodus50 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soodus0
            // 
            this.soodus0.AutoSize = true;
            this.soodus0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soodus0.Location = new System.Drawing.Point(71, 55);
            this.soodus0.Name = "soodus0";
            this.soodus0.Size = new System.Drawing.Size(46, 20);
            this.soodus0.TabIndex = 0;
            this.soodus0.TabStop = true;
            this.soodus0.Text = "0%";
            this.soodus0.UseVisualStyleBackColor = true;
            // 
            // soodus10
            // 
            this.soodus10.AutoSize = true;
            this.soodus10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soodus10.Location = new System.Drawing.Point(71, 100);
            this.soodus10.Name = "soodus10";
            this.soodus10.Size = new System.Drawing.Size(54, 20);
            this.soodus10.TabIndex = 1;
            this.soodus10.TabStop = true;
            this.soodus10.Text = "10%";
            this.soodus10.UseVisualStyleBackColor = true;
            // 
            // soodus20
            // 
            this.soodus20.AutoSize = true;
            this.soodus20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soodus20.Location = new System.Drawing.Point(71, 146);
            this.soodus20.Name = "soodus20";
            this.soodus20.Size = new System.Drawing.Size(54, 20);
            this.soodus20.TabIndex = 2;
            this.soodus20.TabStop = true;
            this.soodus20.Text = "20%";
            this.soodus20.UseVisualStyleBackColor = true;
            // 
            // soodus50
            // 
            this.soodus50.AutoSize = true;
            this.soodus50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soodus50.Location = new System.Drawing.Point(71, 190);
            this.soodus50.Name = "soodus50";
            this.soodus50.Size = new System.Drawing.Size(54, 20);
            this.soodus50.TabIndex = 3;
            this.soodus50.TabStop = true;
            this.soodus50.Text = "50%";
            this.soodus50.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vali soodustus";
            // 
            // Soodus
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soodus50);
            this.Controls.Add(this.soodus20);
            this.Controls.Add(this.soodus10);
            this.Controls.Add(this.soodus0);
            this.Name = "Soodus";
            this.Load += new System.EventHandler(this.Soodus_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Soodus_Load_1(object sender, EventArgs e)
        {

        }
    }
}
