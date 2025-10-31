namespace AppointmentApp
{
    partial class NewAppointment
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
            this.nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.doktorid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newappointmentbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(12, 34);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(210, 20);
            this.nev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neved:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // taj
            // 
            this.taj.Location = new System.Drawing.Point(13, 87);
            this.taj.Name = "taj";
            this.taj.Size = new System.Drawing.Size(210, 20);
            this.taj.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TAJ-számod";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dátum (év-honap-nap óra:perc:másodperc)";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(12, 139);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(210, 20);
            this.datum.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doktor azonitsítója";
            // 
            // doktorid
            // 
            this.doktorid.Location = new System.Drawing.Point(12, 194);
            this.doktorid.Name = "doktorid";
            this.doktorid.Size = new System.Drawing.Size(210, 20);
            this.doktorid.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // newappointmentbutton
            // 
            this.newappointmentbutton.Location = new System.Drawing.Point(12, 392);
            this.newappointmentbutton.Name = "newappointmentbutton";
            this.newappointmentbutton.Size = new System.Drawing.Size(334, 38);
            this.newappointmentbutton.TabIndex = 8;
            this.newappointmentbutton.Text = "Új foglalás";
            this.newappointmentbutton.UseVisualStyleBackColor = true;
            this.newappointmentbutton.Click += new System.EventHandler(this.newappointmentbutton_Click);
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 442);
            this.Controls.Add(this.newappointmentbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doktorid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taj);
            this.Controls.Add(this.nev);
            this.Name = "NewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAppointment";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox doktorid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newappointmentbutton;
    }
}