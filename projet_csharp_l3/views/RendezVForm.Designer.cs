namespace projet_csharp_l3.views
{
    partial class RendezVForm
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
            this.dtgvRV = new System.Windows.Forms.DataGridView();
            this.btnAddRV = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.btnRM = new System.Windows.Forms.Button();
            this.btnValide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dtgvMedDisp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRV
            // 
            this.dtgvRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRV.Location = new System.Drawing.Point(280, 110);
            this.dtgvRV.Name = "dtgvRV";
            this.dtgvRV.Size = new System.Drawing.Size(637, 321);
            this.dtgvRV.TabIndex = 0;
            // 
            // btnAddRV
            // 
            this.btnAddRV.Location = new System.Drawing.Point(923, 151);
            this.btnAddRV.Name = "btnAddRV";
            this.btnAddRV.Size = new System.Drawing.Size(105, 35);
            this.btnAddRV.TabIndex = 1;
            this.btnAddRV.Text = "Planifier";
            this.btnAddRV.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(565, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(818, 63);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(75, 23);
            this.btnFiltre.TabIndex = 6;
            this.btnFiltre.Text = "OK";
            this.btnFiltre.UseVisualStyleBackColor = true;
            // 
            // btnRM
            // 
            this.btnRM.Location = new System.Drawing.Point(923, 192);
            this.btnRM.Name = "btnRM";
            this.btnRM.Size = new System.Drawing.Size(105, 35);
            this.btnRM.TabIndex = 7;
            this.btnRM.Text = "Annuler";
            this.btnRM.UseVisualStyleBackColor = true;
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(923, 110);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(105, 35);
            this.btnValide.TabIndex = 8;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rechercher Patient";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(923, 233);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(105, 35);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // dtgvMedDisp
            // 
            this.dtgvMedDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedDisp.Location = new System.Drawing.Point(12, 110);
            this.dtgvMedDisp.Name = "dtgvMedDisp";
            this.dtgvMedDisp.Size = new System.Drawing.Size(251, 321);
            this.dtgvMedDisp.TabIndex = 11;
            // 
            // RendezVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 453);
            this.Controls.Add(this.dtgvMedDisp);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.btnRM);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddRV);
            this.Controls.Add(this.dtgvRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RendezVForm";
            this.Text = "ConsultationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRV;
        private System.Windows.Forms.Button btnAddRV;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Button btnRM;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dtgvMedDisp;
    }
}