namespace employeeindecs
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
            this.label4 = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.outputlistView = new System.Windows.Forms.ListView();
            this.idcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salarycolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(110, 40);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(223, 20);
            this.idtextBox.TabIndex = 4;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(110, 75);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(223, 20);
            this.nametextBox.TabIndex = 5;
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(110, 112);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(223, 20);
            this.salarytextBox.TabIndex = 6;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(110, 145);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(223, 20);
            this.addresstextBox.TabIndex = 7;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(238, 183);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // outputlistView
            // 
            this.outputlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcolumnHeader,
            this.namecolumnHeader,
            this.salarycolumnHeader});
            this.outputlistView.FullRowSelect = true;
            this.outputlistView.GridLines = true;
            this.outputlistView.HideSelection = false;
            this.outputlistView.Location = new System.Drawing.Point(12, 245);
            this.outputlistView.Name = "outputlistView";
            this.outputlistView.Size = new System.Drawing.Size(364, 139);
            this.outputlistView.TabIndex = 9;
            this.outputlistView.UseCompatibleStateImageBehavior = false;
            this.outputlistView.View = System.Windows.Forms.View.Details;
            this.outputlistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.outputlistView_MouseDoubleClick);
            // 
            // idcolumnHeader
            // 
            this.idcolumnHeader.Text = "Id";
            // 
            // namecolumnHeader
            // 
            this.namecolumnHeader.Text = "Name";
            this.namecolumnHeader.Width = 85;
            // 
            // salarycolumnHeader
            // 
            this.salarycolumnHeader.Text = "salary";
            this.salarycolumnHeader.Width = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 396);
            this.Controls.Add(this.outputlistView);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ListView outputlistView;
        private System.Windows.Forms.ColumnHeader idcolumnHeader;
        private System.Windows.Forms.ColumnHeader namecolumnHeader;
        private System.Windows.Forms.ColumnHeader salarycolumnHeader;
    }
}

