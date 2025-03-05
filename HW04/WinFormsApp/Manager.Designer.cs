namespace WinFormsApp
{
    partial class Manager
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
            listViewData = new ListView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxOcupation = new TextBox();
            textBoxSalary = new TextBox();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            comboBoxSearchOption = new ComboBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // listViewData
            // 
            listViewData.AllowColumnReorder = true;
            listViewData.FullRowSelect = true;
            listViewData.GridLines = true;
            listViewData.Location = new Point(264, 12);
            listViewData.Name = "listViewData";
            listViewData.Size = new Size(458, 330);
            listViewData.TabIndex = 1;
            listViewData.UseCompatibleStateImageBehavior = false;
            listViewData.View = View.Details;
            listViewData.SelectedIndexChanged += listViewData_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(46, 150);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 187);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 3;
            label2.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(10, 224);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 5;
            label4.Text = "Ocupation:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(44, 263);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 6;
            label5.Text = "Salary:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(112, 146);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(146, 31);
            textBoxName.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSurname.Location = new Point(112, 183);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(146, 31);
            textBoxSurname.TabIndex = 8;
            // 
            // textBoxOcupation
            // 
            textBoxOcupation.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOcupation.Location = new Point(112, 220);
            textBoxOcupation.Name = "textBoxOcupation";
            textBoxOcupation.Size = new Size(146, 31);
            textBoxOcupation.TabIndex = 10;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSalary.Location = new Point(112, 259);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(146, 31);
            textBoxSalary.TabIndex = 11;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch.Location = new Point(10, 38);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(248, 31);
            textBoxSearch.TabIndex = 12;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(10, 75);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(80, 27);
            buttonSearch.TabIndex = 13;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxSearchOption
            // 
            comboBoxSearchOption.FormattingEnabled = true;
            comboBoxSearchOption.Location = new Point(96, 75);
            comboBoxSearchOption.Name = "comboBoxSearchOption";
            comboBoxSearchOption.Size = new Size(162, 27);
            comboBoxSearchOption.TabIndex = 14;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 296);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 40);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(138, 296);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 40);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(61, 12);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 18;
            label3.Text = "Search employee:";
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 356);
            Controls.Add(label3);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxSearchOption);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxOcupation);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewData);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager";
            Text = "Employee manager";
            FormClosed += Manager_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewData;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxOcupation;
        private TextBox textBoxSalary;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private ComboBox comboBoxSearchOption;
        private Button buttonAdd;
        private Button buttonDelete;
        private Label label3;
    }
}
