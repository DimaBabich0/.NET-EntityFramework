namespace App
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
            listViewData = new ListView();
            comboBoxOptions = new ComboBox();
            btnShow = new Button();
            SuspendLayout();
            // 
            // listViewData
            // 
            listViewData.Location = new Point(12, 12);
            listViewData.Name = "listViewData";
            listViewData.Size = new Size(617, 327);
            listViewData.TabIndex = 0;
            listViewData.UseCompatibleStateImageBehavior = false;
            listViewData.View = View.Details;
            // 
            // comboBoxOptions
            // 
            comboBoxOptions.FormattingEnabled = true;
            comboBoxOptions.Location = new Point(635, 12);
            comboBoxOptions.Name = "comboBoxOptions";
            comboBoxOptions.Size = new Size(192, 31);
            comboBoxOptions.TabIndex = 1;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(684, 49);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 35);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 351);
            Controls.Add(btnShow);
            Controls.Add(comboBoxOptions);
            Controls.Add(listViewData);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewData;
        private ComboBox comboBoxOptions;
        private Button btnShow;
    }
}
