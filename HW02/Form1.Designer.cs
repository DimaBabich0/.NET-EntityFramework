namespace HW02
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
            buttonConnect = new Button();
            comboBoxOption = new ComboBox();
            buttonSelect = new Button();
            listView1 = new ListView();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(13, 14);
            buttonConnect.Margin = new Padding(4, 5, 4, 5);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(605, 35);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Check Connection";
            buttonConnect.UseVisualStyleBackColor = true;
            // 
            // comboBoxOption
            // 
            comboBoxOption.FormattingEnabled = true;
            comboBoxOption.Location = new Point(13, 66);
            comboBoxOption.Margin = new Padding(4, 5, 4, 5);
            comboBoxOption.Name = "comboBoxOption";
            comboBoxOption.Size = new Size(479, 31);
            comboBoxOption.TabIndex = 1;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(500, 66);
            buttonSelect.Margin = new Padding(4, 5, 4, 5);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(118, 35);
            buttonSelect.TabIndex = 2;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(13, 148);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(605, 278);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox
            // 
            textBox.Location = new Point(13, 107);
            textBox.Margin = new Padding(4, 5, 4, 5);
            textBox.Name = "textBox";
            textBox.Size = new Size(605, 31);
            textBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 440);
            Controls.Add(textBox);
            Controls.Add(listView1);
            Controls.Add(buttonSelect);
            Controls.Add(comboBoxOption);
            Controls.Add(buttonConnect);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConnect;
        private ComboBox comboBoxOption;
        private Button buttonSelect;
        private ListView listView1;
        private TextBox textBox;
    }
}
