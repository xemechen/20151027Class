namespace Example02
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.guy1give = new System.Windows.Forms.Button();
            this.guy2give = new System.Windows.Forms.Button();
            this.guy2cash = new System.Windows.Forms.Label();
            this.guy2name = new System.Windows.Forms.Label();
            this.guy1name = new System.Windows.Forms.Label();
            this.guy1cash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guy1give
            // 
            this.guy1give.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guy1give.Location = new System.Drawing.Point(110, 362);
            this.guy1give.Name = "guy1give";
            this.guy1give.Size = new System.Drawing.Size(237, 112);
            this.guy1give.TabIndex = 0;
            this.guy1give.Text = "Guy1Give";
            this.guy1give.UseVisualStyleBackColor = true;
            this.guy1give.Click += new System.EventHandler(this.guy1give_Click);
            // 
            // guy2give
            // 
            this.guy2give.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guy2give.Location = new System.Drawing.Point(465, 362);
            this.guy2give.Name = "guy2give";
            this.guy2give.Size = new System.Drawing.Size(237, 112);
            this.guy2give.TabIndex = 0;
            this.guy2give.Text = "Guy2Give";
            this.guy2give.UseVisualStyleBackColor = true;
            this.guy2give.Click += new System.EventHandler(this.guy2give_Click);
            // 
            // guy2cash
            // 
            this.guy2cash.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guy2cash.Location = new System.Drawing.Point(465, 171);
            this.guy2cash.Name = "guy2cash";
            this.guy2cash.Size = new System.Drawing.Size(237, 103);
            this.guy2cash.TabIndex = 1;
            this.guy2cash.Text = "G2Cash: ";
            this.guy2cash.Click += new System.EventHandler(this.guy2cash_Click);
            // 
            // guy2name
            // 
            this.guy2name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guy2name.Location = new System.Drawing.Point(465, 38);
            this.guy2name.Name = "guy2name";
            this.guy2name.Size = new System.Drawing.Size(237, 106);
            this.guy2name.TabIndex = 1;
            this.guy2name.Text = "G2Name: ";
            this.guy2name.Click += new System.EventHandler(this.guy2name_Click);
            // 
            // guy1name
            // 
            this.guy1name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guy1name.Location = new System.Drawing.Point(110, 38);
            this.guy1name.Name = "guy1name";
            this.guy1name.Size = new System.Drawing.Size(237, 106);
            this.guy1name.TabIndex = 2;
            this.guy1name.Text = "G1Name: ";
            this.guy1name.Click += new System.EventHandler(this.guy1name_Click_1);
            // 
            // guy1cash
            // 
            this.guy1cash.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guy1cash.Location = new System.Drawing.Point(110, 171);
            this.guy1cash.Name = "guy1cash";
            this.guy1cash.Size = new System.Drawing.Size(237, 106);
            this.guy1cash.TabIndex = 2;
            this.guy1cash.Text = "G2Cash: ";
            this.guy1cash.Click += new System.EventHandler(this.guy1cash_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 605);
            this.Controls.Add(this.guy1cash);
            this.Controls.Add(this.guy1name);
            this.Controls.Add(this.guy2name);
            this.Controls.Add(this.guy2cash);
            this.Controls.Add(this.guy2give);
            this.Controls.Add(this.guy1give);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guy1give;
        private System.Windows.Forms.Button guy2give;
        private System.Windows.Forms.Label guy2cash;
        private System.Windows.Forms.Label guy2name;
        private System.Windows.Forms.Label guy1name;
        private System.Windows.Forms.Label guy1cash;
    }
}

