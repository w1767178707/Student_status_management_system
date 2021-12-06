
namespace student_mannagement_system
{
    partial class UpdateSocore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSocore));
            this.lab = new System.Windows.Forms.Label();
            this.sno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cno = new System.Windows.Forms.Label();
            this.config = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab.Location = new System.Drawing.Point(85, 60);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(37, 14);
            this.lab.TabIndex = 0;
            this.lab.Text = "学号";
            // 
            // sno
            // 
            this.sno.AutoSize = true;
            this.sno.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sno.Location = new System.Drawing.Point(130, 60);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(0, 14);
            this.sno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(86, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "成绩";
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(129, 149);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(228, 21);
            this.grade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(70, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "课程号";
            // 
            // cno
            // 
            this.cno.AutoSize = true;
            this.cno.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cno.Location = new System.Drawing.Point(130, 103);
            this.cno.Name = "cno";
            this.cno.Size = new System.Drawing.Size(0, 14);
            this.cno.TabIndex = 5;
            // 
            // config
            // 
            this.config.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.config.Image = ((System.Drawing.Image)(resources.GetObject("config.Image")));
            this.config.Location = new System.Drawing.Point(88, 203);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(87, 38);
            this.config.TabIndex = 6;
            this.config.Text = "确认修改";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(286, 203);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 38);
            this.back.TabIndex = 7;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // UpdateSocore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 266);
            this.Controls.Add(this.back);
            this.Controls.Add(this.config);
            this.Controls.Add(this.cno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.lab);
            this.MaximizeBox = false;
            this.Name = "UpdateSocore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新成绩";
            this.Load += new System.EventHandler(this.UpdateSocore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label sno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cno;
        private System.Windows.Forms.Button config;
        private System.Windows.Forms.Button back;
    }
}