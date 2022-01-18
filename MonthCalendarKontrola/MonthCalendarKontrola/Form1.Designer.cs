namespace MonthCalendarKontrola
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
            this.monCal = new System.Windows.Forms.MonthCalendar();
            this.btnTermin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monCal
            // 
            this.monCal.Location = new System.Drawing.Point(18, 18);
            this.monCal.MaxSelectionCount = 14;
            this.monCal.Name = "monCal";
            this.monCal.TabIndex = 0;
            // 
            // btnTermin
            // 
            this.btnTermin.Location = new System.Drawing.Point(18, 202);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(199, 53);
            this.btnTermin.TabIndex = 1;
            this.btnTermin.Text = "Odaberite termin";
            this.btnTermin.UseVisualStyleBackColor = true;
            this.btnTermin.Click += new System.EventHandler(this.btnTermin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 284);
            this.Controls.Add(this.btnTermin);
            this.Controls.Add(this.monCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monCal;
        private System.Windows.Forms.Button btnTermin;
    }
}

