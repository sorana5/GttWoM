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
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, username, name, highscore });
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(662, 267);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 150;
            // 
            // username
            // 
            username.Text = "username";
            username.Width = 150;
            // 
            // name
            // 
            name.Text = "name";
            name.Width = 150;
            // 
            // highscore
            // 
            highscore.Text = "highscore";
            highscore.Width = 150;
            // 
            // delete
            // 
            delete.Location = new Point(658, 380);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 1;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // studentId
            // 
            studentId.Location = new Point(529, 381);
            studentId.Name = "studentId";
            studentId.Size = new Size(100, 23);
            studentId.TabIndex = 2;
            // 
            // ManageClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}