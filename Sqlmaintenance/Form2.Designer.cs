namespace Sqlmaintenance
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btn_shrink = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_sorgular = new System.Windows.Forms.Button();
            this.btn_index = new System.Windows.Forms.Button();
            this.btn_task = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_shrink
            // 
            this.btn_shrink.BackColor = System.Drawing.Color.Transparent;
            this.btn_shrink.FlatAppearance.BorderSize = 0;
            this.btn_shrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(207)))), ((int)(((byte)(56)))));
            this.btn_shrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shrink.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_shrink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_shrink.Location = new System.Drawing.Point(1153, 9);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Size = new System.Drawing.Size(230, 75);
            this.btn_shrink.TabIndex = 3;
            this.btn_shrink.Text = "VERİ TABANI BOYUT KÜÇÜLTME";
            this.btn_shrink.UseVisualStyleBackColor = false;
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.Transparent;
            this.btn_backup.FlatAppearance.BorderSize = 0;
            this.btn_backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(207)))), ((int)(((byte)(56)))));
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_backup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_backup.Location = new System.Drawing.Point(855, 3);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(282, 77);
            this.btn_backup.TabIndex = 3;
            this.btn_backup.Text = "YEDEKLEME İŞLEMLERİ";
            this.btn_backup.UseVisualStyleBackColor = false;
            // 
            // btn_sorgular
            // 
            this.btn_sorgular.BackColor = System.Drawing.Color.Transparent;
            this.btn_sorgular.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_sorgular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sorgular.FlatAppearance.BorderSize = 0;
            this.btn_sorgular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(207)))), ((int)(((byte)(56)))));
            this.btn_sorgular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorgular.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_sorgular.Location = new System.Drawing.Point(110, 3);
            this.btn_sorgular.Name = "btn_sorgular";
            this.btn_sorgular.Size = new System.Drawing.Size(217, 80);
            this.btn_sorgular.TabIndex = 2;
            this.btn_sorgular.Text = "ÇALIŞAN SORGULARI GÖRÜNTÜLE";
            this.btn_sorgular.UseVisualStyleBackColor = false;
            this.btn_sorgular.Click += new System.EventHandler(this.btn_sorgular_Click);
            // 
            // btn_index
            // 
            this.btn_index.BackColor = System.Drawing.Color.Transparent;
            this.btn_index.FlatAppearance.BorderSize = 0;
            this.btn_index.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(207)))), ((int)(((byte)(56)))));
            this.btn_index.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_index.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_index.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_index.Location = new System.Drawing.Point(580, 12);
            this.btn_index.Name = "btn_index";
            this.btn_index.Size = new System.Drawing.Size(257, 68);
            this.btn_index.TabIndex = 3;
            this.btn_index.Text = "INDEX İŞLEMLERİ";
            this.btn_index.UseVisualStyleBackColor = false;
            // 
            // btn_task
            // 
            this.btn_task.BackColor = System.Drawing.Color.Transparent;
            this.btn_task.FlatAppearance.BorderSize = 0;
            this.btn_task.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(207)))), ((int)(((byte)(56)))));
            this.btn_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_task.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_task.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_task.Location = new System.Drawing.Point(333, 3);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(250, 80);
            this.btn_task.TabIndex = 3;
            this.btn_task.Text = "GÖREV YÖNETİCİSİ";
            this.btn_task.UseVisualStyleBackColor = false;
            this.btn_task.Click += new System.EventHandler(this.btn_task_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_sorgular);
            this.panel2.Controls.Add(this.btn_shrink);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_task);
            this.panel2.Controls.Add(this.btn_backup);
            this.panel2.Controls.Add(this.btn_index);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1691, 83);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sqlmaintenance.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 688);
            this.panel1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_shrink;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_index;
        private System.Windows.Forms.Button btn_task;
        private System.Windows.Forms.Button btn_sorgular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}