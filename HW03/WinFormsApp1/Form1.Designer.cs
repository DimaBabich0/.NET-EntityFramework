namespace WinFormsApp1
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
            comboBoxStudents = new ComboBox();
            textBoxGroup = new TextBox();
            textBoxAge = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(13, 14);
            comboBoxStudents.Margin = new Padding(4, 5, 4, 5);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(323, 31);
            comboBoxStudents.TabIndex = 13;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(110, 137);
            textBoxGroup.Margin = new Padding(4, 5, 4, 5);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(226, 31);
            textBoxGroup.TabIndex = 12;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(110, 96);
            textBoxAge.Margin = new Padding(4, 5, 4, 5);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(226, 31);
            textBoxAge.TabIndex = 11;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(110, 55);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(226, 31);
            textBoxName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 9;
            label3.Text = "Group:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 8;
            label2.Text = "Age:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 7;
            label1.Text = "Full name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 201);
            Controls.Add(comboBoxStudents);
            Controls.Add(textBoxGroup);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStudents;
        private TextBox textBoxGroup;
        private TextBox textBoxAge;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
