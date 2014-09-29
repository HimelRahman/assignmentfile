namespace studentinfo
{
    partial class Registrationfrom
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
            this.regtextBox = new System.Windows.Forms.TextBox();
            this.fsttextBox = new System.Windows.Forms.TextBox();
            this.lsttextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.retrivebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // regtextBox
            // 
            this.regtextBox.Location = new System.Drawing.Point(96, 28);
            this.regtextBox.Name = "regtextBox";
            this.regtextBox.Size = new System.Drawing.Size(224, 20);
            this.regtextBox.TabIndex = 3;
            // 
            // fsttextBox
            // 
            this.fsttextBox.Location = new System.Drawing.Point(96, 64);
            this.fsttextBox.Name = "fsttextBox";
            this.fsttextBox.Size = new System.Drawing.Size(224, 20);
            this.fsttextBox.TabIndex = 4;
            // 
            // lsttextBox
            // 
            this.lsttextBox.Location = new System.Drawing.Point(96, 102);
            this.lsttextBox.Name = "lsttextBox";
            this.lsttextBox.Size = new System.Drawing.Size(224, 20);
            this.lsttextBox.TabIndex = 5;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(51, 170);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // retrivebutton
            // 
            this.retrivebutton.Location = new System.Drawing.Point(153, 169);
            this.retrivebutton.Name = "retrivebutton";
            this.retrivebutton.Size = new System.Drawing.Size(75, 23);
            this.retrivebutton.TabIndex = 7;
            this.retrivebutton.Text = "Retrive";
            this.retrivebutton.UseVisualStyleBackColor = true;
            this.retrivebutton.Click += new System.EventHandler(this.retrivebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(245, 170);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 8;
            this.clearbutton.Text = "Clear All";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 262);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.retrivebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.lsttextBox);
            this.Controls.Add(this.fsttextBox);
            this.Controls.Add(this.regtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Registration process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regtextBox;
        private System.Windows.Forms.TextBox fsttextBox;
        private System.Windows.Forms.TextBox lsttextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button retrivebutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

