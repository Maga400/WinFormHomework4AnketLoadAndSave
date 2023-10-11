namespace WinFormsApp7
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
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            label4 = new Label();
            phoneTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            BirthdayPicker = new DateTimePicker();
            changeButton = new Button();
            addButton = new Button();
            listBox1 = new ListBox();
            fileNameTextBox = new TextBox();
            loadButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(404, -2);
            label1.Name = "label1";
            label1.Size = new Size(131, 40);
            label1.TabIndex = 0;
            label1.Text = "ANket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 1;
            label2.Text = "name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(146, 89);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(260, 27);
            nameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(146, 132);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(260, 27);
            surnameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 132);
            label3.Name = "label3";
            label3.Size = new Size(116, 24);
            label3.TabIndex = 3;
            label3.Text = "surname:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(146, 178);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(260, 27);
            emailTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 177);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 5;
            label4.Text = "email:";
            label4.Click += label4_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(146, 221);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(260, 27);
            phoneTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 223);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 7;
            label5.Text = "phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 268);
            label6.Name = "label6";
            label6.Size = new Size(124, 24);
            label6.TabIndex = 9;
            label6.Text = "birthday:";
            // 
            // BirthdayPicker
            // 
            BirthdayPicker.Location = new Point(156, 265);
            BirthdayPicker.Name = "BirthdayPicker";
            BirthdayPicker.Size = new Size(250, 27);
            BirthdayPicker.TabIndex = 10;
            // 
            // changeButton
            // 
            changeButton.BackColor = Color.White;
            changeButton.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            changeButton.ForeColor = Color.Blue;
            changeButton.Location = new Point(303, 346);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(103, 49);
            changeButton.TabIndex = 11;
            changeButton.Text = "change";
            changeButton.UseVisualStyleBackColor = false;
            changeButton.Click += changeButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.Blue;
            addButton.Location = new Point(156, 346);
            addButton.Name = "addButton";
            addButton.Size = new Size(103, 49);
            addButton.TabIndex = 12;
            addButton.Text = "add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(576, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 344);
            listBox1.TabIndex = 13;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(576, 375);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(293, 27);
            fileNameTextBox.TabIndex = 14;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.White;
            loadButton.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.ForeColor = Color.Blue;
            loadButton.Location = new Point(576, 415);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(135, 31);
            loadButton.TabIndex = 15;
            loadButton.Text = "load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = Color.Blue;
            saveButton.Location = new Point(734, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(135, 31);
            saveButton.TabIndex = 16;
            saveButton.Text = "save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(900, 462);
            Controls.Add(saveButton);
            Controls.Add(loadButton);
            Controls.Add(fileNameTextBox);
            Controls.Add(listBox1);
            Controls.Add(addButton);
            Controls.Add(changeButton);
            Controls.Add(BirthdayPicker);
            Controls.Add(label6);
            Controls.Add(phoneTextBox);
            Controls.Add(label5);
            Controls.Add(emailTextBox);
            Controls.Add(label4);
            Controls.Add(surnameTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private Label label4;
        private TextBox phoneTextBox;
        private Label label5;
        private Label label6;
        private DateTimePicker BirthdayPicker;
        private Button changeButton;
        private Button addButton;
        private ListBox listBox1;
        private TextBox fileNameTextBox;
        private Button loadButton;
        private Button saveButton;
    }
}