
namespace student_mannagement_system
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.ac_cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.classno = new System.Windows.Forms.ComboBox();
            this.sexplain = new System.Windows.Forms.TextBox();
            this.sage = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.sno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ssex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sphone = new System.Windows.Forms.TextBox();
            this.sloc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ac_cancel
            // 
            this.ac_cancel.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ac_cancel.Image = ((System.Drawing.Image)(resources.GetObject("ac_cancel.Image")));
            this.ac_cancel.Location = new System.Drawing.Point(254, 347);
            this.ac_cancel.Name = "ac_cancel";
            this.ac_cancel.Size = new System.Drawing.Size(75, 40);
            this.ac_cancel.TabIndex = 27;
            this.ac_cancel.Text = "取消";
            this.ac_cancel.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(94, 347);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 40);
            this.add.TabIndex = 26;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // classno
            // 
            this.classno.FormattingEnabled = true;
            this.classno.Location = new System.Drawing.Point(94, 191);
            this.classno.Name = "classno";
            this.classno.Size = new System.Drawing.Size(121, 20);
            this.classno.TabIndex = 25;
            // 
            // sexplain
            // 
            this.sexplain.Location = new System.Drawing.Point(94, 233);
            this.sexplain.Multiline = true;
            this.sexplain.Name = "sexplain";
            this.sexplain.Size = new System.Drawing.Size(284, 96);
            this.sexplain.TabIndex = 24;
            // 
            // sage
            // 
            this.sage.Location = new System.Drawing.Point(94, 64);
            this.sage.Name = "sage";
            this.sage.Size = new System.Drawing.Size(100, 21);
            this.sage.TabIndex = 22;
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(268, 21);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(121, 21);
            this.sname.TabIndex = 21;
            // 
            // sno
            // 
            this.sno.Location = new System.Drawing.Point(94, 21);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(100, 21);
            this.sno.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(21, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "学生描述";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(21, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "所属班级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(225, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(195, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "学生姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "学生编号";
            // 
            // ssex
            // 
            this.ssex.FormattingEnabled = true;
            this.ssex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ssex.Location = new System.Drawing.Point(268, 65);
            this.ssex.Name = "ssex";
            this.ssex.Size = new System.Drawing.Size(121, 20);
            this.ssex.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(21, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "学生电话";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(200, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 31;
            this.label9.Text = "学生户籍";
            // 
            // sphone
            // 
            this.sphone.Location = new System.Drawing.Point(94, 106);
            this.sphone.Name = "sphone";
            this.sphone.Size = new System.Drawing.Size(100, 21);
            this.sphone.TabIndex = 32;
            // 
            // sloc
            // 
            this.sloc.Location = new System.Drawing.Point(268, 106);
            this.sloc.Multiline = true;
            this.sloc.Name = "sloc";
            this.sloc.Size = new System.Drawing.Size(121, 100);
            this.sloc.TabIndex = 33;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.sloc);
            this.Controls.Add(this.sphone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ssex);
            this.Controls.Add(this.ac_cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.classno);
            this.Controls.Add(this.sexplain);
            this.Controls.Add(this.sage);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学生";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ac_cancel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox classno;
        private System.Windows.Forms.TextBox sexplain;
        private System.Windows.Forms.TextBox sage;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox sno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ssex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sphone;
        private System.Windows.Forms.TextBox sloc;
    }
}