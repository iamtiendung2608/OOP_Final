
namespace TreeAlgoVisualize
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Insert = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Rank = new System.Windows.Forms.TextBox();
            this.RankButton = new System.Windows.Forms.Button();
            this.CeilingButton = new System.Windows.Forms.Button();
            this.Ceiling = new System.Windows.Forms.TextBox();
            this.FindMax = new System.Windows.Forms.Button();
            this.FindMin = new System.Windows.Forms.Button();
            this.Travelsal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insert.Location = new System.Drawing.Point(72, 466);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(79, 35);
            this.Insert.TabIndex = 0;
            this.Insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(72, 525);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(79, 35);
            this.Delete.TabIndex = 1;
            this.Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.InsertButton.FlatAppearance.BorderSize = 2;
            this.InsertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.InsertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.ForeColor = System.Drawing.Color.White;
            this.InsertButton.Location = new System.Drawing.Point(178, 466);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(163, 35);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(179, 525);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 35);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Rank
            // 
            this.Rank.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rank.Location = new System.Drawing.Point(386, 466);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(97, 35);
            this.Rank.TabIndex = 5;
            this.Rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RankButton
            // 
            this.RankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.RankButton.FlatAppearance.BorderSize = 2;
            this.RankButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.RankButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.RankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RankButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RankButton.ForeColor = System.Drawing.Color.White;
            this.RankButton.Location = new System.Drawing.Point(515, 466);
            this.RankButton.Name = "RankButton";
            this.RankButton.Size = new System.Drawing.Size(115, 35);
            this.RankButton.TabIndex = 6;
            this.RankButton.Text = "Rank";
            this.RankButton.UseVisualStyleBackColor = false;
            this.RankButton.Click += new System.EventHandler(this.RankButton_Click);
            // 
            // CeilingButton
            // 
            this.CeilingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.CeilingButton.FlatAppearance.BorderSize = 2;
            this.CeilingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CeilingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CeilingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CeilingButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CeilingButton.ForeColor = System.Drawing.Color.White;
            this.CeilingButton.Location = new System.Drawing.Point(515, 525);
            this.CeilingButton.Name = "CeilingButton";
            this.CeilingButton.Size = new System.Drawing.Size(115, 36);
            this.CeilingButton.TabIndex = 7;
            this.CeilingButton.Text = "Ceiling";
            this.CeilingButton.UseVisualStyleBackColor = false;
            this.CeilingButton.Click += new System.EventHandler(this.CeilingButton_Click);
            // 
            // Ceiling
            // 
            this.Ceiling.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ceiling.Location = new System.Drawing.Point(386, 525);
            this.Ceiling.Name = "Ceiling";
            this.Ceiling.Size = new System.Drawing.Size(97, 35);
            this.Ceiling.TabIndex = 8;
            this.Ceiling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FindMax
            // 
            this.FindMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.FindMax.FlatAppearance.BorderSize = 2;
            this.FindMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.FindMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.FindMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindMax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindMax.ForeColor = System.Drawing.Color.White;
            this.FindMax.Location = new System.Drawing.Point(677, 466);
            this.FindMax.Name = "FindMax";
            this.FindMax.Size = new System.Drawing.Size(110, 35);
            this.FindMax.TabIndex = 9;
            this.FindMax.Text = "Max";
            this.FindMax.UseVisualStyleBackColor = false;
            this.FindMax.Click += new System.EventHandler(this.FindMax_Click);
            // 
            // FindMin
            // 
            this.FindMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.FindMin.FlatAppearance.BorderSize = 2;
            this.FindMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.FindMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.FindMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindMin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindMin.ForeColor = System.Drawing.Color.White;
            this.FindMin.Location = new System.Drawing.Point(677, 525);
            this.FindMin.Name = "FindMin";
            this.FindMin.Size = new System.Drawing.Size(110, 36);
            this.FindMin.TabIndex = 10;
            this.FindMin.Text = "Min";
            this.FindMin.UseVisualStyleBackColor = false;
            this.FindMin.Click += new System.EventHandler(this.FindMin_Click);
            // 
            // Travelsal
            // 
            this.Travelsal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.Travelsal.FlatAppearance.BorderSize = 2;
            this.Travelsal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Travelsal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Travelsal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Travelsal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Travelsal.ForeColor = System.Drawing.Color.White;
            this.Travelsal.Location = new System.Drawing.Point(817, 466);
            this.Travelsal.Name = "Travelsal";
            this.Travelsal.Size = new System.Drawing.Size(107, 93);
            this.Travelsal.TabIndex = 11;
            this.Travelsal.Text = "Print";
            this.Travelsal.UseVisualStyleBackColor = false;
            this.Travelsal.Click += new System.EventHandler(this.Travelsal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 50);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(941, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(991, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Travelsal);
            this.Controls.Add(this.FindMin);
            this.Controls.Add(this.FindMax);
            this.Controls.Add(this.Ceiling);
            this.Controls.Add(this.CeilingButton);
            this.Controls.Add(this.RankButton);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Insert;
        private System.Windows.Forms.TextBox Delete;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox Rank;
        private System.Windows.Forms.Button RankButton;
        private System.Windows.Forms.Button CeilingButton;
        private System.Windows.Forms.TextBox Ceiling;
        private System.Windows.Forms.Button FindMax;
        private System.Windows.Forms.Button FindMin;
        private System.Windows.Forms.Button Travelsal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

