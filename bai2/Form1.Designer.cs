namespace bai4_2
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
            cbokhoahoc = new ComboBox();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            dtpBirthDate = new DateTimePicker();
            mtxtPhone = new MaskedTextBox();
            btndangki = new Button();
            SuspendLayout();
            // 
            // cbokhoahoc
            // 
            cbokhoahoc.FormattingEnabled = true;
            cbokhoahoc.Location = new Point(31, 12);
            cbokhoahoc.Name = "cbokhoahoc";
            cbokhoahoc.Size = new Size(184, 28);
            cbokhoahoc.TabIndex = 0;
            cbokhoahoc.Text = "chon khoa hoc";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(31, 166);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(31, 220);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(31, 64);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 3;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(31, 115);
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(125, 27);
            mtxtPhone.TabIndex = 4;
            mtxtPhone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // btndangki
            // 
            btndangki.Location = new Point(444, 284);
            btndangki.Name = "btndangki";
            btndangki.Size = new Size(188, 85);
            btndangki.TabIndex = 5;
            btndangki.Text = "dang ki";
            btndangki.UseVisualStyleBackColor = true;
            btndangki.Click += btndangki_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndangki);
            Controls.Add(mtxtPhone);
            Controls.Add(dtpBirthDate);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(cbokhoahoc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbokhoahoc;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private DateTimePicker dtpBirthDate;
        private MaskedTextBox mtxtPhone;
        private Button btndangki;
    }
}
