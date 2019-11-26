namespace MelrosePayrollSystem
{
    partial class Menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(345, 46);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(60, 13);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Main Menu";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(174, 124);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(76, 13);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "EmployeeData";
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(516, 124);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(23, 13);
            this.lblHR.TabIndex = 2;
            this.lblHR.Text = "HR";
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(175, 169);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(494, 169);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(75, 23);
            this.btnHR.TabIndex = 4;
            this.btnHR.Text = "HR";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnHR;
    }
}