namespace AppointmentApp
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.dataGridViewFoglalasokad = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFoglalasId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.foglalastorl = new System.Windows.Forms.Button();
            this.txtDoktorId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoktorNev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSzakterulet = new System.Windows.Forms.TextBox();
            this.doktorfelv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoglalasokad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFoglalasokad
            // 
            this.dataGridViewFoglalasokad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoglalasokad.Location = new System.Drawing.Point(220, 12);
            this.dataGridViewFoglalasokad.Name = "dataGridViewFoglalasokad";
            this.dataGridViewFoglalasokad.Size = new System.Drawing.Size(568, 426);
            this.dataGridViewFoglalasokad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Foglalas törlése";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor felvétele";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxFoglalasId
            // 
            this.textBoxFoglalasId.Location = new System.Drawing.Point(85, 32);
            this.textBoxFoglalasId.Name = "textBoxFoglalasId";
            this.textBoxFoglalasId.Size = new System.Drawing.Size(94, 20);
            this.textBoxFoglalasId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Foglalas Id";
            // 
            // foglalastorl
            // 
            this.foglalastorl.Location = new System.Drawing.Point(24, 69);
            this.foglalastorl.Name = "foglalastorl";
            this.foglalastorl.Size = new System.Drawing.Size(155, 38);
            this.foglalastorl.TabIndex = 5;
            this.foglalastorl.Text = "Foglalas torlese";
            this.foglalastorl.UseVisualStyleBackColor = true;
            this.foglalastorl.Click += new System.EventHandler(this.foglalastorl_Click);
            // 
            // txtDoktorId
            // 
            this.txtDoktorId.Location = new System.Drawing.Point(83, 222);
            this.txtDoktorId.Name = "txtDoktorId";
            this.txtDoktorId.Size = new System.Drawing.Size(94, 20);
            this.txtDoktorId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doktor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Doktor neve";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDoktorNev
            // 
            this.txtDoktorNev.Location = new System.Drawing.Point(83, 248);
            this.txtDoktorNev.Name = "txtDoktorNev";
            this.txtDoktorNev.Size = new System.Drawing.Size(94, 20);
            this.txtDoktorNev.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Szakterület";
            // 
            // txtSzakterulet
            // 
            this.txtSzakterulet.Location = new System.Drawing.Point(83, 274);
            this.txtSzakterulet.Name = "txtSzakterulet";
            this.txtSzakterulet.Size = new System.Drawing.Size(94, 20);
            this.txtSzakterulet.TabIndex = 8;
            // 
            // doktorfelv
            // 
            this.doktorfelv.Location = new System.Drawing.Point(22, 300);
            this.doktorfelv.Name = "doktorfelv";
            this.doktorfelv.Size = new System.Drawing.Size(155, 39);
            this.doktorfelv.TabIndex = 10;
            this.doktorfelv.Text = "Doktor felvétele";
            this.doktorfelv.UseVisualStyleBackColor = true;
            this.doktorfelv.Click += new System.EventHandler(this.doktorfelv_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doktorfelv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSzakterulet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDoktorNev);
            this.Controls.Add(this.foglalastorl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoktorId);
            this.Controls.Add(this.textBoxFoglalasId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFoglalasokad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.ShowIcon = false;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoglalasokad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFoglalasokad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFoglalasId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button foglalastorl;
        private System.Windows.Forms.TextBox txtDoktorId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoktorNev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSzakterulet;
        private System.Windows.Forms.Button doktorfelv;
    }
}