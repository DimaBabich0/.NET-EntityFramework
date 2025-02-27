namespace WinFormsApp
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
            groupBox = new GroupBox();
            label5 = new Label();
            comboBoxContitent = new ComboBox();
            textBoxArea = new TextBox();
            label3 = new Label();
            textBoxPopulation = new TextBox();
            label4 = new Label();
            textBoxCapital = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            comboBoxCountries = new ComboBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(comboBoxContitent);
            groupBox.Controls.Add(textBoxArea);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(textBoxPopulation);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(textBoxCapital);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(textBoxName);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(btnChange);
            groupBox.Controls.Add(btnDelete);
            groupBox.Controls.Add(btnAdd);
            groupBox.Controls.Add(comboBoxCountries);
            groupBox.Location = new Point(13, 13);
            groupBox.Margin = new Padding(4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(4);
            groupBox.Size = new Size(433, 251);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Countries:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 14;
            label5.Text = "Continent:";
            // 
            // comboBoxContitent
            // 
            comboBoxContitent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxContitent.FormattingEnabled = true;
            comboBoxContitent.Location = new Point(92, 202);
            comboBoxContitent.Margin = new Padding(4);
            comboBoxContitent.Name = "comboBoxContitent";
            comboBoxContitent.Size = new Size(326, 27);
            comboBoxContitent.TabIndex = 16;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(91, 167);
            textBoxArea.Margin = new Padding(4);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(326, 27);
            textBoxArea.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 12;
            label3.Text = "Area:";
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(92, 132);
            textBoxPopulation.Margin = new Padding(4);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(326, 27);
            textBoxPopulation.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 136);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 4;
            label4.Text = "Population:";
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(92, 97);
            textBoxCapital.Margin = new Padding(4);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(326, 27);
            textBoxCapital.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Capital:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(92, 62);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(326, 27);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(341, 28);
            btnChange.Margin = new Padding(4);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(76, 27);
            btnChange.TabIndex = 11;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(257, 29);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 27);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(173, 29);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 27);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(9, 28);
            comboBoxCountries.Margin = new Padding(4);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(158, 27);
            comboBoxCountries.TabIndex = 8;
            comboBoxCountries.SelectedIndexChanged += comboBoxCountries_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 278);
            Controls.Add(groupBox);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Country manager";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.TextBox textBoxPopulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label3;
        private ComboBox comboBoxContitent;
    }
}

