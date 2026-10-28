namespace bai4._1
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
            components = new System.ComponentModel.Container();
            lblusername = new Label();
            lblpassword = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            btnexit = new Button();
            chkShowpassword = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            btnregister = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(50, 44);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(73, 20);
            lblusername.TabIndex = 0;
            lblusername.Text = "username";
            lblusername.Click += label1_Click;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(50, 123);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(70, 20);
            lblpassword.TabIndex = 0;
            lblpassword.Text = "mat khau";
            lblpassword.Click += label1_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(271, 41);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(217, 27);
            txtusername.TabIndex = 1;
            txtusername.TextChanged += txtemail_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(271, 116);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(217, 27);
            txtpassword.TabIndex = 1;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(401, 205);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(114, 50);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "dang nhap";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += button1_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(643, 205);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(114, 50);
            btnexit.TabIndex = 2;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // chkShowpassword
            // 
            chkShowpassword.AutoSize = true;
            chkShowpassword.Location = new Point(517, 118);
            chkShowpassword.Name = "chkShowpassword";
            chkShowpassword.Size = new Size(67, 24);
            chkShowpassword.TabIndex = 3;
            chkShowpassword.Text = "Show";
            chkShowpassword.UseVisualStyleBackColor = true;
            chkShowpassword.CheckedChanged += chkShowpassword_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnregister
            // 
            btnregister.Location = new Point(523, 205);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(114, 51);
            btnregister.TabIndex = 4;
            btnregister.Text = "dang ki";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnregister);
            Controls.Add(chkShowpassword);
            Controls.Add(txtusername);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private Label lblpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button btnexit;
        private CheckBox chkShowpassword;
        private ErrorProvider errorProvider1;
        private Button btnregister;
    }
}
