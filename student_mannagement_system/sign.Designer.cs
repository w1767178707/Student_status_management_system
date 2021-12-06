
namespace student_mannagement_system
{
    partial class sign
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stextBox_username = new System.Windows.Forms.TextBox();
            this.stextBox_password = new System.Windows.Forms.TextBox();
            this.stextBox_againpassword = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // stextBox_username
            // 
            this.stextBox_username.Location = new System.Drawing.Point(117, 100);
            this.stextBox_username.Name = "stextBox_username";
            this.stextBox_username.Size = new System.Drawing.Size(242, 21);
            this.stextBox_username.TabIndex = 3;
            this.stextBox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stextBox_username_KeyPress);
            // 
            // stextBox_password
            // 
            this.stextBox_password.Location = new System.Drawing.Point(117, 151);
            this.stextBox_password.Name = "stextBox_password";
            this.stextBox_password.Size = new System.Drawing.Size(242, 21);
            this.stextBox_password.TabIndex = 4;
            this.stextBox_password.TextChanged += new System.EventHandler(this.stextBox_password_TextChanged);
            this.stextBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stextBox_password_KeyPress);
            // 
            // stextBox_againpassword
            // 
            this.stextBox_againpassword.Location = new System.Drawing.Point(117, 202);
            this.stextBox_againpassword.Name = "stextBox_againpassword";
            this.stextBox_againpassword.Size = new System.Drawing.Size(242, 21);
            this.stextBox_againpassword.TabIndex = 5;
            this.stextBox_againpassword.TextChanged += new System.EventHandler(this.stextBox_againpassword_TextChanged);
            this.stextBox_againpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stextBox_againpassword_KeyPress);
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(177, 279);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(75, 23);
            this.reg.TabIndex = 6;
            this.reg.Text = "注册";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(284, 279);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Location = new System.Drawing.Point(281, 243);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(72, 16);
            this.show.TabIndex = 8;
            this.show.Text = "显示密码";
            this.show.UseVisualStyleBackColor = true;
            this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
            // 
            // sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 342);
            this.Controls.Add(this.show);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.stextBox_againpassword);
            this.Controls.Add(this.stextBox_password);
            this.Controls.Add(this.stextBox_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sign";
            this.Load += new System.EventHandler(this.sign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stextBox_username;
        private System.Windows.Forms.TextBox stextBox_password;
        private System.Windows.Forms.TextBox stextBox_againpassword;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.CheckBox show;
    }
}