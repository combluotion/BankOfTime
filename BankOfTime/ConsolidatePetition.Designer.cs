
namespace BankOfTime
{
    partial class ConsolidatePetition
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_datapeticio = new System.Windows.Forms.DateTimePicker();
            this.txtPetitionHours = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblPetitionDate = new System.Windows.Forms.Label();
            this.lblPetitionHours = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.header_consolidate = new System.Windows.Forms.Label();
            this.btnConsolidate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt_datapeticio);
            this.panel1.Controls.Add(this.btnConsolidate);
            this.panel1.Controls.Add(this.txtPetitionHours);
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.lblPetitionDate);
            this.panel1.Controls.Add(this.lblPetitionHours);
            this.panel1.Controls.Add(this.lblDetails);
            this.panel1.Controls.Add(this.header_consolidate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 366);
            this.panel1.TabIndex = 13;
            // 
            // dt_datapeticio
            // 
            this.dt_datapeticio.Location = new System.Drawing.Point(130, 282);
            this.dt_datapeticio.Name = "dt_datapeticio";
            this.dt_datapeticio.Size = new System.Drawing.Size(121, 20);
            this.dt_datapeticio.TabIndex = 24;
            // 
            // txtPetitionHours
            // 
            this.txtPetitionHours.Location = new System.Drawing.Point(130, 247);
            this.txtPetitionHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtPetitionHours.Name = "txtPetitionHours";
            this.txtPetitionHours.Size = new System.Drawing.Size(121, 20);
            this.txtPetitionHours.TabIndex = 18;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(130, 122);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(229, 102);
            this.txtDetails.TabIndex = 17;
            // 
            // lblPetitionDate
            // 
            this.lblPetitionDate.AutoSize = true;
            this.lblPetitionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetitionDate.Location = new System.Drawing.Point(54, 283);
            this.lblPetitionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPetitionDate.Name = "lblPetitionDate";
            this.lblPetitionDate.Size = new System.Drawing.Size(37, 16);
            this.lblPetitionDate.TabIndex = 15;
            this.lblPetitionDate.Text = "Date";
            // 
            // lblPetitionHours
            // 
            this.lblPetitionHours.AutoSize = true;
            this.lblPetitionHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetitionHours.Location = new System.Drawing.Point(54, 247);
            this.lblPetitionHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPetitionHours.Name = "lblPetitionHours";
            this.lblPetitionHours.Size = new System.Drawing.Size(44, 16);
            this.lblPetitionHours.TabIndex = 14;
            this.lblPetitionHours.Text = "Hours";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(54, 122);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(50, 16);
            this.lblDetails.TabIndex = 13;
            this.lblDetails.Text = "Details";
            // 
            // header_consolidate
            // 
            this.header_consolidate.AutoSize = true;
            this.header_consolidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header_consolidate.Font = new System.Drawing.Font("Impact", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_consolidate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.header_consolidate.Location = new System.Drawing.Point(76, 41);
            this.header_consolidate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.header_consolidate.Name = "header_consolidate";
            this.header_consolidate.Size = new System.Drawing.Size(255, 35);
            this.header_consolidate.TabIndex = 12;
            this.header_consolidate.Text = "Consolidate Petition!";
            this.header_consolidate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConsolidate
            // 
            this.btnConsolidate.AutoSize = true;
            this.btnConsolidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsolidate.Image = global::BankOfTime.Properties.Resources.exchange;
            this.btnConsolidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsolidate.Location = new System.Drawing.Point(290, 317);
            this.btnConsolidate.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsolidate.Name = "btnConsolidate";
            this.btnConsolidate.Size = new System.Drawing.Size(69, 26);
            this.btnConsolidate.TabIndex = 23;
            this.btnConsolidate.Text = "OK";
            this.btnConsolidate.UseVisualStyleBackColor = true;
            this.btnConsolidate.Click += new System.EventHandler(this.btnConsolidate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConsolidatePetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 366);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsolidatePetition";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consolidate Petition";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_datapeticio;
        private System.Windows.Forms.Button btnConsolidate;
        private System.Windows.Forms.TextBox txtPetitionHours;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblPetitionDate;
        private System.Windows.Forms.Label lblPetitionHours;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label header_consolidate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}