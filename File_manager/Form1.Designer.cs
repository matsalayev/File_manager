
namespace File_manager
{
    partial class File_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChiqish = new System.Windows.Forms.Button();
            this.txtManzil = new System.Windows.Forms.TextBox();
            this.btnOrqaga = new System.Windows.Forms.Button();
            this.btnUy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ochirishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnChiqish);
            this.panel1.Controls.Add(this.txtManzil);
            this.panel1.Controls.Add(this.btnOrqaga);
            this.panel1.Controls.Add(this.btnUy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 54);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(851, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 54);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChiqish
            // 
            this.btnChiqish.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChiqish.FlatAppearance.BorderSize = 0;
            this.btnChiqish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiqish.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChiqish.ForeColor = System.Drawing.Color.Red;
            this.btnChiqish.Location = new System.Drawing.Point(901, 0);
            this.btnChiqish.Name = "btnChiqish";
            this.btnChiqish.Size = new System.Drawing.Size(50, 54);
            this.btnChiqish.TabIndex = 3;
            this.btnChiqish.Text = "×";
            this.btnChiqish.UseVisualStyleBackColor = true;
            this.btnChiqish.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtManzil
            // 
            this.txtManzil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtManzil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManzil.ForeColor = System.Drawing.Color.Silver;
            this.txtManzil.Location = new System.Drawing.Point(107, 10);
            this.txtManzil.Name = "txtManzil";
            this.txtManzil.Size = new System.Drawing.Size(738, 34);
            this.txtManzil.TabIndex = 2;
            // 
            // btnOrqaga
            // 
            this.btnOrqaga.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrqaga.FlatAppearance.BorderSize = 0;
            this.btnOrqaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrqaga.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrqaga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOrqaga.Location = new System.Drawing.Point(50, 0);
            this.btnOrqaga.Name = "btnOrqaga";
            this.btnOrqaga.Size = new System.Drawing.Size(50, 54);
            this.btnOrqaga.TabIndex = 1;
            this.btnOrqaga.Text = "←";
            this.btnOrqaga.UseVisualStyleBackColor = true;
            this.btnOrqaga.Click += new System.EventHandler(this.btnOrqaga_Click);
            // 
            // btnUy
            // 
            this.btnUy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUy.FlatAppearance.BorderSize = 0;
            this.btnUy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUy.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUy.Location = new System.Drawing.Point(0, 0);
            this.btnUy.Name = "btnUy";
            this.btnUy.Size = new System.Drawing.Size(50, 54);
            this.btnUy.TabIndex = 0;
            this.btnUy.Text = "⌂";
            this.btnUy.UseVisualStyleBackColor = true;
            this.btnUy.Click += new System.EventHandler(this.btnUy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 523);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(0, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Matn tahrirlovchi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 523);
            this.panel3.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ochirishToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
            // 
            // ochirishToolStripMenuItem
            // 
            this.ochirishToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ochirishToolStripMenuItem.Name = "ochirishToolStripMenuItem";
            this.ochirishToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.ochirishToolStripMenuItem.Text = "O\'chirish";
            this.ochirishToolStripMenuItem.Click += new System.EventHandler(this.ochirishToolStripMenuItem_Click);
            // 
            // Fayllar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Fayllar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtManzil;
        private System.Windows.Forms.Button btnOrqaga;
        private System.Windows.Forms.Button btnUy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChiqish;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ochirishToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

