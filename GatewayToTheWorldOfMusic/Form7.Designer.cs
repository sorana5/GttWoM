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
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(332, 53);
            username.Name = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 0;
            // 
            // register
            // 
            register.Location = new Point(485, 194);
            register.Name = "register";
            register.Size = new Size(75, 23);
            register.TabIndex = 1;
            register.Text = "register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // password
            // 
            password.Location = new Point(332, 110);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 2;
            // 
            // name
            // 
            name.Location = new Point(332, 163);
            name.Name = "name";
            name.Size = new Size(100, 23);
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
            // Authentification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}