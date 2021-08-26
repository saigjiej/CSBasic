
namespace Chapter6_FormPrac
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMessageBox1 = new System.Windows.Forms.Button();
            this.btnMessageBox2 = new System.Windows.Forms.Button();
            this.btnMessageBox3 = new System.Windows.Forms.Button();
            this.btnModeless = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox1
            // 
            this.btnMessageBox1.Location = new System.Drawing.Point(50, 60);
            this.btnMessageBox1.Name = "btnMessageBox1";
            this.btnMessageBox1.Size = new System.Drawing.Size(227, 56);
            this.btnMessageBox1.TabIndex = 0;
            this.btnMessageBox1.Text = "메세지 박스 보기";
            this.btnMessageBox1.UseVisualStyleBackColor = true;
            this.btnMessageBox1.Click += new System.EventHandler(this.btnMessageBox1_Click);
            // 
            // btnMessageBox2
            // 
            this.btnMessageBox2.Location = new System.Drawing.Point(50, 132);
            this.btnMessageBox2.Name = "btnMessageBox2";
            this.btnMessageBox2.Size = new System.Drawing.Size(227, 56);
            this.btnMessageBox2.TabIndex = 1;
            this.btnMessageBox2.Text = "메세지 박스 보기";
            this.btnMessageBox2.UseVisualStyleBackColor = true;
            this.btnMessageBox2.Click += new System.EventHandler(this.btnMessageBox1_Click);
            // 
            // btnMessageBox3
            // 
            this.btnMessageBox3.Location = new System.Drawing.Point(50, 205);
            this.btnMessageBox3.Name = "btnMessageBox3";
            this.btnMessageBox3.Size = new System.Drawing.Size(227, 56);
            this.btnMessageBox3.TabIndex = 2;
            this.btnMessageBox3.Text = "메세지 박스 보기";
            this.btnMessageBox3.UseVisualStyleBackColor = true;
            this.btnMessageBox3.Click += new System.EventHandler(this.btnMessageBox1_Click);
            // 
            // btnModeless
            // 
            this.btnModeless.Location = new System.Drawing.Point(283, 60);
            this.btnModeless.Name = "btnModeless";
            this.btnModeless.Size = new System.Drawing.Size(241, 128);
            this.btnModeless.TabIndex = 3;
            this.btnModeless.Text = "모달리스 창 열기";
            this.btnModeless.UseVisualStyleBackColor = true;
            this.btnModeless.Click += new System.EventHandler(this.btnModeless_Click);
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(283, 194);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(241, 67);
            this.btnModel.TabIndex = 4;
            this.btnModel.Text = "모달 창 열기";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModeless_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 317);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.btnModeless);
            this.Controls.Add(this.btnMessageBox3);
            this.Controls.Add(this.btnMessageBox2);
            this.Controls.Add(this.btnMessageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox1;
        private System.Windows.Forms.Button btnMessageBox2;
        private System.Windows.Forms.Button btnMessageBox3;
        private System.Windows.Forms.Button btnModeless;
        private System.Windows.Forms.Button btnModel;
    }
}

