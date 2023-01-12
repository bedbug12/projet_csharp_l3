namespace projet_csharp_l3.views
{
    partial class MenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.btnConsultationAnnuler = new System.Windows.Forms.Button();
            this.mcalDate = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeconnexion);
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.btnConsultation);
            this.panel1.Controls.Add(this.btnConsultationAnnuler);
            this.panel1.Controls.Add(this.mcalDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 603);
            this.panel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "UserConnect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clinique221";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(-2, 557);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(230, 39);
            this.btnDeconnexion.TabIndex = 4;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(0, 399);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(230, 39);
            this.btnPatient.TabIndex = 3;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            this.btnConsultation.Location = new System.Drawing.Point(0, 310);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(230, 39);
            this.btnConsultation.TabIndex = 2;
            this.btnConsultation.Text = "Rendez-Vous";
            this.btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnConsultationAnnuler
            // 
            this.btnConsultationAnnuler.Location = new System.Drawing.Point(0, 354);
            this.btnConsultationAnnuler.Name = "btnConsultationAnnuler";
            this.btnConsultationAnnuler.Size = new System.Drawing.Size(230, 39);
            this.btnConsultationAnnuler.TabIndex = 1;
            this.btnConsultationAnnuler.Text = "Consultation Annuler";
            this.btnConsultationAnnuler.UseVisualStyleBackColor = true;
            // 
            // mcalDate
            // 
            this.mcalDate.Location = new System.Drawing.Point(1, 131);
            this.mcalDate.Name = "mcalDate";
            this.mcalDate.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 603);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinique221";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Button btnConsultationAnnuler;
        private System.Windows.Forms.MonthCalendar mcalDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
    }
}