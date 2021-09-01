
namespace WindowsFormsAppWebApi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textUserId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textUserId
            // 
            this.textUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUserId.Location = new System.Drawing.Point(12, 12);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(399, 20);
            this.textUserId.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(437, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textResponse
            // 
            this.textResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResponse.Location = new System.Drawing.Point(13, 39);
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(398, 218);
            this.textResponse.TabIndex = 2;
            this.textResponse.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 273);
            this.Controls.Add(this.textResponse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textUserId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textResponse;
    }
}

