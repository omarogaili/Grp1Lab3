namespace SqlInjection
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            lblStatus = new Label();
            lblQuerry = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 94);
            label2.Name = "label2";
            label2.Size = new Size(126, 29);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(148, 34);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(291, 35);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(148, 89);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(291, 35);
            txtPass.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(43, 198);
            button1.Name = "button1";
            button1.Size = new Size(199, 61);
            button1.TabIndex = 4;
            button1.Text = "Logga in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(38, 285);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(170, 29);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Du är utloggad";
            // 
            // lblQuerry
            // 
            lblQuerry.AutoSize = true;
            lblQuerry.Location = new Point(38, 148);
            lblQuerry.Name = "lblQuerry";
            lblQuerry.Size = new Size(118, 29);
            lblQuerry.TabIndex = 6;
            lblQuerry.Text = "sqlQuerry";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 407);
            Controls.Add(lblQuerry);
            Controls.Add(lblStatus);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuerry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
