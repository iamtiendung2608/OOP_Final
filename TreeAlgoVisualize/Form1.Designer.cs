
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
            this.components = new System.ComponentModel.Container();
            this.Run = new System.Windows.Forms.Timer(this.components);
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
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Interval = 20;
            this.Run.Tick += new System.EventHandler(this.Run_Tick);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insert.Location = new System.Drawing.Point(8, 385);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(79, 35);
            this.Insert.TabIndex = 0;
            this.Insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(8, 444);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(79, 35);
            this.Delete.TabIndex = 1;
            this.Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.Location = new System.Drawing.Point(115, 385);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(163, 35);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(115, 444);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 35);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // Rank
            // 
            this.Rank.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rank.Location = new System.Drawing.Point(322, 385);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(97, 35);
            this.Rank.TabIndex = 5;
            this.Rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RankButton
            // 
            this.RankButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RankButton.Location = new System.Drawing.Point(451, 385);
            this.RankButton.Name = "RankButton";
            this.RankButton.Size = new System.Drawing.Size(115, 35);
            this.RankButton.TabIndex = 6;
            this.RankButton.Text = "Rank";
            this.RankButton.UseVisualStyleBackColor = true;
            this.RankButton.Click += new System.EventHandler(this.RankButton_Click);
            // 
            // CeilingButton
            // 
            this.CeilingButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CeilingButton.Location = new System.Drawing.Point(451, 444);
            this.CeilingButton.Name = "CeilingButton";
            this.CeilingButton.Size = new System.Drawing.Size(115, 36);
            this.CeilingButton.TabIndex = 7;
            this.CeilingButton.Text = "Ceiling";
            this.CeilingButton.UseVisualStyleBackColor = true;
            this.CeilingButton.Click += new System.EventHandler(this.CeilingButton_Click);
            // 
            // Ceiling
            // 
            this.Ceiling.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ceiling.Location = new System.Drawing.Point(322, 444);
            this.Ceiling.Name = "Ceiling";
            this.Ceiling.Size = new System.Drawing.Size(97, 35);
            this.Ceiling.TabIndex = 8;
            this.Ceiling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FindMax
            // 
            this.FindMax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindMax.Location = new System.Drawing.Point(613, 385);
            this.FindMax.Name = "FindMax";
            this.FindMax.Size = new System.Drawing.Size(110, 35);
            this.FindMax.TabIndex = 9;
            this.FindMax.Text = "Max";
            this.FindMax.UseVisualStyleBackColor = true;
            this.FindMax.Click += new System.EventHandler(this.FindMax_Click);
            // 
            // FindMin
            // 
            this.FindMin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindMin.Location = new System.Drawing.Point(613, 444);
            this.FindMin.Name = "FindMin";
            this.FindMin.Size = new System.Drawing.Size(110, 34);
            this.FindMin.TabIndex = 10;
            this.FindMin.Text = "Min";
            this.FindMin.UseVisualStyleBackColor = true;
            this.FindMin.Click += new System.EventHandler(this.FindMin_Click);
            // 
            // Travelsal
            // 
            this.Travelsal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Travelsal.Location = new System.Drawing.Point(753, 385);
            this.Travelsal.Name = "Travelsal";
            this.Travelsal.Size = new System.Drawing.Size(107, 93);
            this.Travelsal.TabIndex = 11;
            this.Travelsal.Text = "Print";
            this.Travelsal.UseVisualStyleBackColor = true;
            this.Travelsal.Click += new System.EventHandler(this.Travelsal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 488);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Run;
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
    }
}

