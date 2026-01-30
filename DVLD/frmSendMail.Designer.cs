namespace DVLD
{
    partial class frmSendMail
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
            this.gradientPanel1 = new DVLD.GradientPanel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.lbl_To = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.btn_Send);
            this.gradientPanel1.Controls.Add(this.txt_Body);
            this.gradientPanel1.Controls.Add(this.lbl_To);
            this.gradientPanel1.Controls.Add(this.txt_Subject);
            this.gradientPanel1.Controls.Add(this.lbl_Subject);
            this.gradientPanel1.Controls.Add(this.txt_To);
            this.gradientPanel1.Controls.Add(this.lbl_Body);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(677, 406);
            this.gradientPanel1.TabIndex = 1;
            // 
            // btn_Send
            // 
            this.btn_Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Send.Location = new System.Drawing.Point(577, 374);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(88, 29);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Body
            // 
            this.txt_Body.Location = new System.Drawing.Point(106, 182);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(495, 184);
            this.txt_Body.TabIndex = 12;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.BackColor = System.Drawing.Color.Transparent;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(3, 54);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(49, 29);
            this.lbl_To.TabIndex = 7;
            this.lbl_To.Text = "To:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.ForeColor = System.Drawing.Color.Black;
            this.txt_Subject.Location = new System.Drawing.Point(106, 113);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(495, 22);
            this.txt_Subject.TabIndex = 11;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(3, 106);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(100, 29);
            this.lbl_Subject.TabIndex = 8;
            this.lbl_Subject.Text = "Subject:";
            // 
            // txt_To
            // 
            this.txt_To.ForeColor = System.Drawing.Color.Black;
            this.txt_To.Location = new System.Drawing.Point(106, 61);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(495, 22);
            this.txt_To.TabIndex = 10;
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Body.Location = new System.Drawing.Point(3, 175);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(74, 29);
            this.lbl_Body.TabIndex = 9;
            this.lbl_Body.Text = "Body:";
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 406);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "frmSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SendMail";
            this.Load += new System.EventHandler(this.frmSendMail_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.Button btn_Send;
    }
}