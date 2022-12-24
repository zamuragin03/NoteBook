
namespace NoteBook_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Date,
            this.Title,
            this.Description,
            this.IsDone});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1063, 457);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Note_Id";
            this.Id.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 199;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 500;
            // 
            // IsDone
            // 
            this.IsDone.Text = "IsDone";
            this.IsDone.Width = 180;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.button1.Location = new System.Drawing.Point(790, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.button2.Location = new System.Drawing.Point(966, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.button3.Location = new System.Drawing.Point(10, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Отобразить все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.button4.Location = new System.Drawing.Point(174, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Сегодня";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.button5.Location = new System.Drawing.Point(273, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "Статистика";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 542);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader IsDone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

