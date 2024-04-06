namespace Sudoku
{
    partial class SudokuMainForm
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
            this.basePanel = new System.Windows.Forms.Panel();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.txtBx2 = new System.Windows.Forms.TextBox();
            this.txtBx3 = new System.Windows.Forms.TextBox();
            this.txtBx4 = new System.Windows.Forms.TextBox();
            this.txtBx7 = new System.Windows.Forms.TextBox();
            this.txtBx5 = new System.Windows.Forms.TextBox();
            this.txtBx6 = new System.Windows.Forms.TextBox();
            this.txtBx8 = new System.Windows.Forms.TextBox();
            this.txtBx9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.AutoSize = true;
            this.basePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(0, 0);
            this.basePanel.TabIndex = 0;
            // 
            // txtBx1
            // 
            this.txtBx1.Location = new System.Drawing.Point(12, 34);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(91, 23);
            this.txtBx1.TabIndex = 1;
            // 
            // txtBx2
            // 
            this.txtBx2.Location = new System.Drawing.Point(145, 34);
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.Size = new System.Drawing.Size(91, 23);
            this.txtBx2.TabIndex = 2;
            // 
            // txtBx3
            // 
            this.txtBx3.Location = new System.Drawing.Point(275, 34);
            this.txtBx3.Name = "txtBx3";
            this.txtBx3.Size = new System.Drawing.Size(91, 23);
            this.txtBx3.TabIndex = 3;
            // 
            // txtBx4
            // 
            this.txtBx4.Location = new System.Drawing.Point(12, 170);
            this.txtBx4.Name = "txtBx4";
            this.txtBx4.Size = new System.Drawing.Size(91, 23);
            this.txtBx4.TabIndex = 4;
            // 
            // txtBx7
            // 
            this.txtBx7.Location = new System.Drawing.Point(12, 285);
            this.txtBx7.Name = "txtBx7";
            this.txtBx7.Size = new System.Drawing.Size(91, 23);
            this.txtBx7.TabIndex = 5;
            // 
            // txtBx5
            // 
            this.txtBx5.Location = new System.Drawing.Point(145, 170);
            this.txtBx5.Name = "txtBx5";
            this.txtBx5.Size = new System.Drawing.Size(91, 23);
            this.txtBx5.TabIndex = 6;
            // 
            // txtBx6
            // 
            this.txtBx6.Location = new System.Drawing.Point(275, 170);
            this.txtBx6.Name = "txtBx6";
            this.txtBx6.Size = new System.Drawing.Size(91, 23);
            this.txtBx6.TabIndex = 7;
            // 
            // txtBx8
            // 
            this.txtBx8.Location = new System.Drawing.Point(145, 285);
            this.txtBx8.Name = "txtBx8";
            this.txtBx8.Size = new System.Drawing.Size(91, 23);
            this.txtBx8.TabIndex = 8;
            // 
            // txtBx9
            // 
            this.txtBx9.Location = new System.Drawing.Point(275, 285);
            this.txtBx9.Name = "txtBx9";
            this.txtBx9.Size = new System.Drawing.Size(91, 23);
            this.txtBx9.TabIndex = 9;
            // 
            // SudokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 372);
            this.Controls.Add(this.txtBx9);
            this.Controls.Add(this.txtBx8);
            this.Controls.Add(this.txtBx6);
            this.Controls.Add(this.txtBx5);
            this.Controls.Add(this.txtBx7);
            this.Controls.Add(this.txtBx4);
            this.Controls.Add(this.txtBx3);
            this.Controls.Add(this.txtBx2);
            this.Controls.Add(this.txtBx1);
            this.Controls.Add(this.basePanel);
            this.Name = "SudokuMainForm";
            this.Text = "Sudoku 2";
            this.Load += new System.EventHandler(this.SudokuMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.TextBox txtBx2;
        private System.Windows.Forms.TextBox txtBx3;
        private System.Windows.Forms.TextBox txtBx4;
        private System.Windows.Forms.TextBox txtBx7;
        private System.Windows.Forms.TextBox txtBx5;
        private System.Windows.Forms.TextBox txtBx6;
        private System.Windows.Forms.TextBox txtBx8;
        private System.Windows.Forms.TextBox txtBx9;
    }
}
