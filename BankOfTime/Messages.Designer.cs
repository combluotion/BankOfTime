
namespace BankOfTime
{
    partial class Messages
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_messageSend = new System.Windows.Forms.Button();
            this.txt_MessageToSend = new System.Windows.Forms.TextBox();
            this.MessagesLayout = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MessagesLayout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_messageSend);
            this.splitContainer1.Panel2.Controls.Add(this.txt_MessageToSend);
            this.splitContainer1.Size = new System.Drawing.Size(706, 595);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_messageSend
            // 
            this.btn_messageSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_messageSend.Location = new System.Drawing.Point(623, 0);
            this.btn_messageSend.Name = "btn_messageSend";
            this.btn_messageSend.Size = new System.Drawing.Size(83, 110);
            this.btn_messageSend.TabIndex = 1;
            this.btn_messageSend.Text = "Send";
            this.btn_messageSend.UseVisualStyleBackColor = true;
            this.btn_messageSend.Click += new System.EventHandler(this.btn_messageSend_Click);
            // 
            // txt_MessageToSend
            // 
            this.txt_MessageToSend.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_MessageToSend.Location = new System.Drawing.Point(0, 0);
            this.txt_MessageToSend.Multiline = true;
            this.txt_MessageToSend.Name = "txt_MessageToSend";
            this.txt_MessageToSend.Size = new System.Drawing.Size(626, 110);
            this.txt_MessageToSend.TabIndex = 0;
            this.txt_MessageToSend.TextChanged += new System.EventHandler(this.txt_MessageToSend_TextChanged);
            // 
            // MessagesLayout
            // 
            this.MessagesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MessagesLayout.Location = new System.Drawing.Point(0, 0);
            this.MessagesLayout.Name = "MessagesLayout";
            this.MessagesLayout.Size = new System.Drawing.Size(706, 481);
            this.MessagesLayout.TabIndex = 0;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 595);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Messages";
            this.Text = "Messages";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_messageSend;
        private System.Windows.Forms.TextBox txt_MessageToSend;
        private System.Windows.Forms.FlowLayoutPanel MessagesLayout;
    }
}