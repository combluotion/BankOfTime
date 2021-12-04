
namespace BankOfTime
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.LogoHolder = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.btnPeticiones = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.ProfileSplit = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProfileImage = new System.Windows.Forms.PictureBox();
            this.DataSplit = new System.Windows.Forms.SplitContainer();
            this.usersDashboard = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.LogoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileSplit)).BeginInit();
            this.ProfileSplit.Panel1.SuspendLayout();
            this.ProfileSplit.Panel2.SuspendLayout();
            this.ProfileSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSplit)).BeginInit();
            this.DataSplit.Panel1.SuspendLayout();
            this.DataSplit.Panel2.SuspendLayout();
            this.DataSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplit
            // 
            this.MainSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(0, 0);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(2);
            this.MainSplit.Name = "MainSplit";
            this.MainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.LogoHolder);
            this.MainSplit.Panel1.Controls.Add(this.btnPeticiones);
            this.MainSplit.Panel1.Controls.Add(this.btnAyuda);
            this.MainSplit.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.ProfileSplit);
            this.MainSplit.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.MainSplit.Size = new System.Drawing.Size(706, 595);
            this.MainSplit.SplitterDistance = 49;
            this.MainSplit.SplitterWidth = 3;
            this.MainSplit.TabIndex = 0;
            // 
            // LogoHolder
            // 
            this.LogoHolder.Controls.Add(this.Logo);
            this.LogoHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoHolder.Location = new System.Drawing.Point(0, 0);
            this.LogoHolder.Margin = new System.Windows.Forms.Padding(2);
            this.LogoHolder.Name = "LogoHolder";
            this.LogoHolder.Size = new System.Drawing.Size(111, 45);
            this.LogoHolder.TabIndex = 3;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(102, 45);
            this.Logo.TabIndex = 3;
            this.Logo.Text = "Bank Of Time";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPeticiones
            // 
            this.btnPeticiones.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeticiones.Location = new System.Drawing.Point(416, 0);
            this.btnPeticiones.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeticiones.Name = "btnPeticiones";
            this.btnPeticiones.Size = new System.Drawing.Size(142, 45);
            this.btnPeticiones.TabIndex = 0;
            this.btnPeticiones.Text = "Petitions";
            this.btnPeticiones.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(558, 0);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(144, 45);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "Help";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // ProfileSplit
            // 
            this.ProfileSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProfileSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ProfileSplit.IsSplitterFixed = true;
            this.ProfileSplit.Location = new System.Drawing.Point(0, 0);
            this.ProfileSplit.Margin = new System.Windows.Forms.Padding(2);
            this.ProfileSplit.Name = "ProfileSplit";
            // 
            // ProfileSplit.Panel1
            // 
            this.ProfileSplit.Panel1.Controls.Add(this.pictureBox1);
            this.ProfileSplit.Panel1.Controls.Add(this.ProfileImage);
            // 
            // ProfileSplit.Panel2
            // 
            this.ProfileSplit.Panel2.Controls.Add(this.DataSplit);
            this.ProfileSplit.Size = new System.Drawing.Size(706, 543);
            this.ProfileSplit.SplitterDistance = 162;
            this.ProfileSplit.SplitterWidth = 3;
            this.ProfileSplit.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 453);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ProfileImage
            // 
            this.ProfileImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImage.Image")));
            this.ProfileImage.Location = new System.Drawing.Point(0, 0);
            this.ProfileImage.Margin = new System.Windows.Forms.Padding(2);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.Size = new System.Drawing.Size(158, 77);
            this.ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileImage.TabIndex = 0;
            this.ProfileImage.TabStop = false;
            // 
            // DataSplit
            // 
            this.DataSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataSplit.Location = new System.Drawing.Point(0, 0);
            this.DataSplit.Margin = new System.Windows.Forms.Padding(2);
            this.DataSplit.Name = "DataSplit";
            // 
            // DataSplit.Panel1
            // 
            this.DataSplit.Panel1.Controls.Add(this.usersDashboard);
            // 
            // DataSplit.Panel2
            // 
            this.DataSplit.Panel2.Controls.Add(this.dataGridView1);
            this.DataSplit.Size = new System.Drawing.Size(541, 543);
            this.DataSplit.SplitterDistance = 340;
            this.DataSplit.SplitterWidth = 3;
            this.DataSplit.TabIndex = 0;
            // 
            // usersDashboard
            // 
            this.usersDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDashboard.Location = new System.Drawing.Point(0, 0);
            this.usersDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.usersDashboard.Name = "usersDashboard";
            this.usersDashboard.RowHeadersWidth = 51;
            this.usersDashboard.RowTemplate.Height = 24;
            this.usersDashboard.Size = new System.Drawing.Size(336, 539);
            this.usersDashboard.TabIndex = 0;
            this.usersDashboard.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDashboard_CellDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(194, 539);
            this.dataGridView1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 595);
            this.Controls.Add(this.MainSplit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.LogoHolder.ResumeLayout(false);
            this.ProfileSplit.Panel1.ResumeLayout(false);
            this.ProfileSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileSplit)).EndInit();
            this.ProfileSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            this.DataSplit.Panel1.ResumeLayout(false);
            this.DataSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSplit)).EndInit();
            this.DataSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.SplitContainer ProfileSplit;
        private System.Windows.Forms.SplitContainer DataSplit;
        private System.Windows.Forms.Button btnPeticiones;
        private System.Windows.Forms.PictureBox ProfileImage;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel LogoHolder;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView usersDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}