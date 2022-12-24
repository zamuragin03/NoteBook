
namespace NoteBook_
{
    partial class ObserveForm
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.seldatelabel = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.titlelabel.Location = new System.Drawing.Point(546, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(87, 30);
            this.titlelabel.TabIndex = 21;
            this.titlelabel.Text = "titlelabe";
            // 
            // seldatelabel
            // 
            this.seldatelabel.AutoSize = true;
            this.seldatelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.seldatelabel.Location = new System.Drawing.Point(262, 9);
            this.seldatelabel.Name = "seldatelabel";
            this.seldatelabel.Size = new System.Drawing.Size(79, 30);
            this.seldatelabel.TabIndex = 20;
            this.seldatelabel.Text = "seldate";
            // 
            // descBox
            // 
            this.descBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.descBox.Location = new System.Drawing.Point(12, 42);
            this.descBox.Name = "descBox";
            this.descBox.ReadOnly = true;
            this.descBox.Size = new System.Drawing.Size(609, 228);
            this.descBox.TabIndex = 19;
            this.descBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.Location = new System.Drawing.Point(451, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Дата";
            // 
            // ObserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 283);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.seldatelabel);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ObserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObserveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label seldatelabel;
        private System.Windows.Forms.RichTextBox descBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}