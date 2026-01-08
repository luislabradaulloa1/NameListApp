namespace NameListApp
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
            lblName = new Label();
            lblGender = new Label();
            tbxName = new TextBox();
            comboGender = new ComboBox();
            btnSubmit = new Button();
            lbxNames = new ListBox();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            radioAll = new RadioButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(79, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(79, 157);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 1;
            lblGender.Text = "Gender";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(171, 79);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(151, 27);
            tbxName.TabIndex = 2;
            // 
            // comboGender
            // 
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGender.FormattingEnabled = true;
            comboGender.Location = new Point(171, 149);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(151, 28);
            comboGender.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(112, 232);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(155, 65);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Add Name";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // lbxNames
            // 
            lbxNames.FormattingEnabled = true;
            lbxNames.Location = new Point(489, 79);
            lbxNames.Name = "lbxNames";
            lbxNames.Size = new Size(231, 264);
            lbxNames.TabIndex = 8;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(489, 384);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(63, 24);
            radioMale.TabIndex = 9;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            radioMale.CheckedChanged += RadioGenders_CheckedChanged;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(570, 384);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(78, 24);
            radioFemale.TabIndex = 10;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            radioFemale.CheckedChanged += RadioGenders_CheckedChanged;
            // 
            // radioAll
            // 
            radioAll.AutoSize = true;
            radioAll.Location = new Point(657, 384);
            radioAll.Name = "radioAll";
            radioAll.Size = new Size(48, 24);
            radioAll.TabIndex = 11;
            radioAll.TabStop = true;
            radioAll.Text = "All";
            radioAll.UseVisualStyleBackColor = true;
            radioAll.CheckedChanged += RadioGenders_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioAll);
            Controls.Add(radioFemale);
            Controls.Add(radioMale);
            Controls.Add(lbxNames);
            Controls.Add(btnSubmit);
            Controls.Add(comboGender);
            Controls.Add(tbxName);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Information";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblGender;
        private TextBox tbxName;
        private ComboBox comboGender;
        private Button btnSubmit;
        private ListBox lbxNames;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private RadioButton radioAll;
    }
}
