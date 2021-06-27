namespace MouseTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnLeftClick = new System.Windows.Forms.Button();
            this.btnMiddleClick = new System.Windows.Forms.Button();
            this.btnRightClick = new System.Windows.Forms.Button();
            this.lblLeftClick = new System.Windows.Forms.Label();
            this.lblMiddleClick = new System.Windows.Forms.Label();
            this.lblRightClick = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnLeftClick
            // 
            this.btnLeftClick.BackColor = System.Drawing.Color.Red;
            this.btnLeftClick.Enabled = false;
            this.btnLeftClick.FlatAppearance.BorderSize = 0;
            this.btnLeftClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftClick.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftClick.Location = new System.Drawing.Point(12, 12);
            this.btnLeftClick.Name = "btnLeftClick";
            this.btnLeftClick.Size = new System.Drawing.Size(203, 191);
            this.btnLeftClick.TabIndex = 0;
            this.btnLeftClick.Text = "Left Click";
            this.btnLeftClick.UseVisualStyleBackColor = false;
            // 
            // btnMiddleClick
            // 
            this.btnMiddleClick.BackColor = System.Drawing.Color.Red;
            this.btnMiddleClick.Enabled = false;
            this.btnMiddleClick.FlatAppearance.BorderSize = 0;
            this.btnMiddleClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleClick.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiddleClick.Location = new System.Drawing.Point(221, 12);
            this.btnMiddleClick.Name = "btnMiddleClick";
            this.btnMiddleClick.Size = new System.Drawing.Size(203, 191);
            this.btnMiddleClick.TabIndex = 1;
            this.btnMiddleClick.Text = "Middle Click";
            this.btnMiddleClick.UseVisualStyleBackColor = false;
            // 
            // btnRightClick
            // 
            this.btnRightClick.BackColor = System.Drawing.Color.Red;
            this.btnRightClick.Enabled = false;
            this.btnRightClick.FlatAppearance.BorderSize = 0;
            this.btnRightClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightClick.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightClick.Location = new System.Drawing.Point(430, 12);
            this.btnRightClick.Name = "btnRightClick";
            this.btnRightClick.Size = new System.Drawing.Size(203, 191);
            this.btnRightClick.TabIndex = 2;
            this.btnRightClick.Text = "Right Click";
            this.btnRightClick.UseVisualStyleBackColor = false;
            // 
            // lblLeftClick
            // 
            this.lblLeftClick.AutoSize = true;
            this.lblLeftClick.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftClick.Location = new System.Drawing.Point(12, 210);
            this.lblLeftClick.Name = "lblLeftClick";
            this.lblLeftClick.Size = new System.Drawing.Size(69, 25);
            this.lblLeftClick.TabIndex = 3;
            this.lblLeftClick.Text = "Clicks: ";
            // 
            // lblMiddleClick
            // 
            this.lblMiddleClick.AutoSize = true;
            this.lblMiddleClick.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleClick.Location = new System.Drawing.Point(218, 210);
            this.lblMiddleClick.Name = "lblMiddleClick";
            this.lblMiddleClick.Size = new System.Drawing.Size(69, 25);
            this.lblMiddleClick.TabIndex = 4;
            this.lblMiddleClick.Text = "Clicks: ";
            // 
            // lblRightClick
            // 
            this.lblRightClick.AutoSize = true;
            this.lblRightClick.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightClick.Location = new System.Drawing.Point(427, 210);
            this.lblRightClick.Name = "lblRightClick";
            this.lblRightClick.Size = new System.Drawing.Size(69, 25);
            this.lblRightClick.TabIndex = 5;
            this.lblRightClick.Text = "Clicks: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(277, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Counter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRightClick);
            this.Controls.Add(this.lblMiddleClick);
            this.Controls.Add(this.lblLeftClick);
            this.Controls.Add(this.btnRightClick);
            this.Controls.Add(this.btnMiddleClick);
            this.Controls.Add(this.btnLeftClick);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 450);
            this.MinimumSize = new System.Drawing.Size(660, 450);
            this.Name = "Form1";
            this.Text = "MouseTester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnLeftClick;
        private System.Windows.Forms.Button btnMiddleClick;
        private System.Windows.Forms.Button btnRightClick;
        private System.Windows.Forms.Label lblLeftClick;
        private System.Windows.Forms.Label lblMiddleClick;
        private System.Windows.Forms.Label lblRightClick;
        private System.Windows.Forms.Button btnReset;
    }
}

