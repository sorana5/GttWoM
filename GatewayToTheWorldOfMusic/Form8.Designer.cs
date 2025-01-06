namespace GatewayToTheWorldOfMusic
{
    partial class ManageClass
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
            listView1 = new ListView();
            id = new ColumnHeader();
            username = new ColumnHeader();
            name = new ColumnHeader();
            highscore = new ColumnHeader();
            delete = new Button();
            studentId = new TextBox();
            instruction = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, username, name, highscore });
            listView1.Location = new Point(95, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(598, 321);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "Id";
            id.Width = 50;
            // 
            // username
            // 
            username.Text = "Username";
            username.Width = 150;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 150;
            // 
            // highscore
            // 
            highscore.Text = "Highscore";
            highscore.Width = 150;
            // 
            // delete
            // 
            delete.BackColor = Color.MediumPurple;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete.Location = new Point(577, 439);
            delete.Name = "delete";
            delete.Size = new Size(116, 35);
            delete.TabIndex = 1;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // studentId
            // 
            studentId.Location = new Point(577, 397);
            studentId.Name = "studentId";
            studentId.Size = new Size(116, 23);
            studentId.TabIndex = 2;
            // 
            // instruction
            // 
            instruction.AutoSize = true;
            instruction.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instruction.Location = new Point(119, 412);
            instruction.Name = "instruction";
            instruction.Size = new Size(75, 20);
            instruction.TabIndex = 3;
            instruction.Text = "Username";
            // 
            // ManageClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 538);
            Controls.Add(instruction);
            Controls.Add(studentId);
            Controls.Add(delete);
            Controls.Add(listView1);
            Name = "ManageClass";
            Text = "Manage";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader username;
        private ColumnHeader name;
        private ColumnHeader highscore;
        private Button delete;
        private TextBox studentId;
        private Label instruction;
    }
}