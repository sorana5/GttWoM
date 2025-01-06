namespace GatewayToTheWorldOfMusic
{
    partial class Authentification
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
            username = new TextBox();
            register = new Button();
            password = new TextBox();
            name = new TextBox();
            switchButton = new SButton();
            logIn = new Button();
            showPassword = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(200, 78);
            username.Name = "username";
            username.Size = new Size(116, 23);
            username.TabIndex = 0;
            // 
            // register
            // 
            register.BackColor = Color.MediumPurple;
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register.Location = new Point(485, 226);
            register.Name = "register";
            register.Size = new Size(116, 35);
            register.TabIndex = 1;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // password
            // 
            password.Location = new Point(200, 129);
            password.Name = "password";
            password.Size = new Size(116, 23);
            password.TabIndex = 2;
            // 
            // name
            // 
            name.Location = new Point(485, 132);
            name.Name = "name";
            name.Size = new Size(116, 23);
            name.TabIndex = 3;
            // 
            // switchButton
            // 
            switchButton.AutoSize = true;
            switchButton.Location = new Point(382, 305);
            switchButton.MinimumSize = new Size(45, 22);
            switchButton.Name = "switchButton";
            switchButton.OffBackColor = Color.MediumPurple;
            switchButton.OffToggleColor = Color.Gainsboro;
            switchButton.OnBackColor = Color.MediumPurple;
            switchButton.OnToggleColor = Color.WhiteSmoke;
            switchButton.Size = new Size(45, 22);
            switchButton.TabIndex = 4;
            switchButton.UseVisualStyleBackColor = true;
            // 
            // logIn
            // 
            logIn.BackColor = Color.MediumPurple;
            logIn.FlatStyle = FlatStyle.Flat;
            logIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logIn.Location = new Point(200, 226);
            logIn.Name = "logIn";
            logIn.Size = new Size(116, 35);
            logIn.TabIndex = 5;
            logIn.Text = "Log in";
            logIn.UseVisualStyleBackColor = false;
            logIn.Click += logIn_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPassword.Location = new Point(200, 167);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(119, 21);
            showPassword.TabIndex = 6;
            showPassword.Text = "Show password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 86);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 7;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 132);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(441, 78);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 9;
            label3.Text = "If you";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(441, 308);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 10;
            label4.Text = "Teacher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(319, 308);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 11;
            label5.Text = "Student";
            // 
            // Authentification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showPassword);
            Controls.Add(logIn);
            Controls.Add(switchButton);
            Controls.Add(name);
            Controls.Add(password);
            Controls.Add(register);
            Controls.Add(username);
            Name = "Authentification";
            Text = "Authentification";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private Button register;
        private TextBox password;
        private TextBox name;
        private SButton switchButton;
        private Button logIn;
        private CheckBox showPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}