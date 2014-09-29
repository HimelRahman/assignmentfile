namespace employeesalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.showlistBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amounttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salay Amount";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(106, 24);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(224, 20);
            this.nametextBox.TabIndex = 4;
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(106, 56);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(224, 20);
            this.idtextBox.TabIndex = 5;
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(106, 86);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(224, 20);
            this.salarytextBox.TabIndex = 6;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(140, 123);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(255, 123);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 8;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // showlistBox
            // 
            this.showlistBox.FormattingEnabled = true;
            this.showlistBox.Location = new System.Drawing.Point(106, 168);
            this.showlistBox.Name = "showlistBox";
            this.showlistBox.Size = new System.Drawing.Size(224, 95);
            this.showlistBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Amount";
            // 
            // amounttextBox
            // 
            this.amounttextBox.Location = new System.Drawing.Point(203, 287);
            this.amounttextBox.Name = "amounttextBox";
            this.amounttextBox.Size = new System.Drawing.Size(127, 20);
            this.amounttextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 319);
            this.Controls.Add(this.amounttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showlistBox);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee fun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.ListBox showlistBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amounttextBox;
    }
}

