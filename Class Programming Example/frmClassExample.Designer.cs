namespace Class_Programming_Example
{
    partial class frmClassExample
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
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(64, 57);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(111, 38);
            this.btnCreateObject.TabIndex = 0;
            this.btnCreateObject.Text = "객체 생성";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClassExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 141);
            this.Controls.Add(this.btnCreateObject);
            this.Name = "frmClassExample";
            this.Text = "Class Programming Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateObject;
    }
}

