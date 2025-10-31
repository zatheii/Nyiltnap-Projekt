using System;

namespace AppointmentApp
{
    partial class UserInterface
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
            this.DarkModeButton = new System.Windows.Forms.Button();
            this.NewAppointment = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.LanguageChange = new System.Windows.Forms.Button();
            this.dataGridViewFoglalasok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoglalasok)).BeginInit();
            this.SuspendLayout();
            // 
            // DarkModeButton
            // 
            this.DarkModeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DarkModeButton.Location = new System.Drawing.Point(36, 247);
            this.DarkModeButton.Name = "DarkModeButton";
            this.DarkModeButton.Size = new System.Drawing.Size(110, 46);
            this.DarkModeButton.TabIndex = 0;
            this.DarkModeButton.Text = "Sötét mód";
            this.DarkModeButton.UseVisualStyleBackColor = true;
            this.DarkModeButton.Click += new System.EventHandler(this.DarkModeButton_Click);
            // 
            // NewAppointment
            // 
            this.NewAppointment.Location = new System.Drawing.Point(35, 195);
            this.NewAppointment.Name = "NewAppointment";
            this.NewAppointment.Size = new System.Drawing.Size(227, 46);
            this.NewAppointment.TabIndex = 4;
            this.NewAppointment.Text = "Új foglalás";
            this.NewAppointment.UseVisualStyleBackColor = true;
            this.NewAppointment.Click += new System.EventHandler(this.NewAppointment_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(35, 21);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 5;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // LanguageChange
            // 
            this.LanguageChange.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LanguageChange.Location = new System.Drawing.Point(152, 247);
            this.LanguageChange.Name = "LanguageChange";
            this.LanguageChange.Size = new System.Drawing.Size(110, 46);
            this.LanguageChange.TabIndex = 6;
            this.LanguageChange.Text = "Change to English language";
            this.LanguageChange.UseVisualStyleBackColor = true;
            this.LanguageChange.Click += new System.EventHandler(this.LanguageChange_Click);
            // 
            // dataGridViewFoglalasok
            // 
            this.dataGridViewFoglalasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoglalasok.Location = new System.Drawing.Point(274, 21);
            this.dataGridViewFoglalasok.Name = "dataGridViewFoglalasok";
            this.dataGridViewFoglalasok.Size = new System.Drawing.Size(447, 272);
            this.dataGridViewFoglalasok.TabIndex = 7;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 326);
            this.Controls.Add(this.dataGridViewFoglalasok);
            this.Controls.Add(this.LanguageChange);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.NewAppointment);
            this.Controls.Add(this.DarkModeButton);
            this.Name = "UserInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Időpont Foglaló";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoglalasok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DarkModeButton;
        private System.Windows.Forms.Button NewAppointment;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button LanguageChange;
        private System.Windows.Forms.DataGridView dataGridViewFoglalasok;
    }
}

