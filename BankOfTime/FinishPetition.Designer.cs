
namespace BankOfTime
{
    partial class FinishPetition
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
            this.header_finish = new System.Windows.Forms.Label();
            this.boxFinished = new System.Windows.Forms.CheckBox();
            this.lblFinished = new System.Windows.Forms.Label();
            this.lblComplain = new System.Windows.Forms.Label();
            this.BoxComplain = new System.Windows.Forms.CheckBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtComplain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // header_finish
            // 
            this.header_finish.AutoSize = true;
            this.header_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header_finish.Font = new System.Drawing.Font("Impact", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_finish.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.header_finish.Location = new System.Drawing.Point(11, 21);
            this.header_finish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.header_finish.Name = "header_finish";
            this.header_finish.Size = new System.Drawing.Size(185, 35);
            this.header_finish.TabIndex = 13;
            this.header_finish.Text = "Finish Petition!";
            // 
            // boxFinished
            // 
            this.boxFinished.AutoSize = true;
            this.boxFinished.Location = new System.Drawing.Point(175, 128);
            this.boxFinished.Name = "boxFinished";
            this.boxFinished.Size = new System.Drawing.Size(15, 14);
            this.boxFinished.TabIndex = 14;
            this.boxFinished.UseVisualStyleBackColor = true;
            // 
            // lblFinished
            // 
            this.lblFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinished.Location = new System.Drawing.Point(11, 115);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(145, 44);
            this.lblFinished.TabIndex = 16;
            this.lblFinished.Text = "Has the petition ended succesfully?";
            // 
            // lblComplain
            // 
            this.lblComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplain.Location = new System.Drawing.Point(11, 179);
            this.lblComplain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplain.Name = "lblComplain";
            this.lblComplain.Size = new System.Drawing.Size(145, 44);
            this.lblComplain.TabIndex = 18;
            this.lblComplain.Text = "Is there any complain?";
            // 
            // BoxComplain
            // 
            this.BoxComplain.AutoSize = true;
            this.BoxComplain.Location = new System.Drawing.Point(175, 192);
            this.BoxComplain.Name = "BoxComplain";
            this.BoxComplain.Size = new System.Drawing.Size(15, 14);
            this.BoxComplain.TabIndex = 17;
            this.BoxComplain.UseVisualStyleBackColor = true;
            this.BoxComplain.CheckedChanged += new System.EventHandler(this.BoxComlplain_CheckedChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.AutoSize = true;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(144, 289);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(103, 30);
            this.btnFinish.TabIndex = 24;
            this.btnFinish.Text = "OK";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtComplain
            // 
            this.txtComplain.Location = new System.Drawing.Point(12, 226);
            this.txtComplain.Multiline = true;
            this.txtComplain.Name = "txtComplain";
            this.txtComplain.Size = new System.Drawing.Size(232, 40);
            this.txtComplain.TabIndex = 25;
            this.txtComplain.Visible = false;
            // 
            // FinishPetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 366);
            this.Controls.Add(this.txtComplain);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblComplain);
            this.Controls.Add(this.BoxComplain);
            this.Controls.Add(this.lblFinished);
            this.Controls.Add(this.boxFinished);
            this.Controls.Add(this.header_finish);
            this.Name = "FinishPetition";
            this.Text = "FinishPetition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header_finish;
        private System.Windows.Forms.CheckBox boxFinished;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Label lblComplain;
        private System.Windows.Forms.CheckBox BoxComplain;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtComplain;
    }
}