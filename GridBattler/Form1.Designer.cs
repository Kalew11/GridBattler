namespace GridBattler
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
            this.btnBuildGrid = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.userControl11 = new GridBattler.UserControl1();
            this.SuspendLayout();
            // 
            // btnBuildGrid
            // 
            this.btnBuildGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildGrid.Location = new System.Drawing.Point(518, 801);
            this.btnBuildGrid.Name = "btnBuildGrid";
            this.btnBuildGrid.Size = new System.Drawing.Size(97, 53);
            this.btnBuildGrid.TabIndex = 1;
            this.btnBuildGrid.Text = "Start";
            this.btnBuildGrid.UseVisualStyleBackColor = true;
            this.btnBuildGrid.Click += new System.EventHandler(this.btnBuildGrid_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTurn.Location = new System.Drawing.Point(1021, 801);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(121, 53);
            this.btnEndTurn.TabIndex = 2;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.Location = new System.Drawing.Point(265, 65);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(100, 41);
            this.txtPlayer1.TabIndex = 4;
            this.txtPlayer1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.Location = new System.Drawing.Point(1313, 65);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(100, 41);
            this.txtPlayer2.TabIndex = 5;
            this.txtPlayer2.TextChanged += new System.EventHandler(this.txtPlayer2_TextChanged);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(749, 727);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(186, 36);
            this.lblTurn.TabIndex = 6;
            this.lblTurn.Text = "Enter Names";
            this.lblTurn.Click += new System.EventHandler(this.lblTurn_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(440, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(809, 712);
            this.userControl11.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 961);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnBuildGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuildGrid;
        private System.Windows.Forms.Button btnEndTurn;
        private UserControl1 userControl11;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblTurn;
    }
}

