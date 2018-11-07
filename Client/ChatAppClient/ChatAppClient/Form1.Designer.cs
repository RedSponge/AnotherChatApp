namespace ChatAppClient
{
    partial class ChatForm
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
            System.Windows.Forms.Label status_display;
            this.title_label = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.userBox = new System.Windows.Forms.ListView();
            this.status_title_label = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connected_users_label = new System.Windows.Forms.Label();
            this.chat_label = new System.Windows.Forms.Label();
            status_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.ForeColor = System.Drawing.Color.Black;
            this.title_label.Location = new System.Drawing.Point(13, 13);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(100, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Welcome, Traveler!";
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(16, 82);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(343, 335);
            this.chatBox.TabIndex = 1;
            this.chatBox.Text = "";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(366, 82);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(106, 287);
            this.userBox.TabIndex = 2;
            this.userBox.UseCompatibleStateImageBehavior = false;
            // 
            // status_title_label
            // 
            this.status_title_label.AutoSize = true;
            this.status_title_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_title_label.ForeColor = System.Drawing.Color.Black;
            this.status_title_label.Location = new System.Drawing.Point(366, 376);
            this.status_title_label.Name = "status_title_label";
            this.status_title_label.Size = new System.Drawing.Size(60, 20);
            this.status_title_label.TabIndex = 3;
            this.status_title_label.Text = "Status:";
            // 
            // status_display
            // 
            status_display.AutoSize = true;
            status_display.Location = new System.Drawing.Point(367, 396);
            status_display.Name = "status_display";
            status_display.Size = new System.Drawing.Size(35, 13);
            status_display.TabIndex = 4;
            status_display.Text = "label1";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(366, 431);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(106, 23);
            this.send_button.TabIndex = 5;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 431);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 6;
            // 
            // connected_users_label
            // 
            this.connected_users_label.AutoSize = true;
            this.connected_users_label.Location = new System.Drawing.Point(366, 63);
            this.connected_users_label.Name = "connected_users_label";
            this.connected_users_label.Size = new System.Drawing.Size(92, 13);
            this.connected_users_label.TabIndex = 7;
            this.connected_users_label.Text = "Connected Users:";
            // 
            // chat_label
            // 
            this.chat_label.AutoSize = true;
            this.chat_label.Location = new System.Drawing.Point(16, 62);
            this.chat_label.Name = "chat_label";
            this.chat_label.Size = new System.Drawing.Size(32, 13);
            this.chat_label.TabIndex = 8;
            this.chat_label.Text = "Chat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 466);
            this.Controls.Add(this.chat_label);
            this.Controls.Add(this.connected_users_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.send_button);
            this.Controls.Add(status_display);
            this.Controls.Add(this.status_title_label);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.title_label);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Chat App By RedSponge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.ListView userBox;
        private System.Windows.Forms.Label status_title_label;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label connected_users_label;
        private System.Windows.Forms.Label chat_label;
    }
}

