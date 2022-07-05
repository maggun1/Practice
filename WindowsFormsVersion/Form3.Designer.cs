namespace WindowsFormsVersion
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ralof_bn = new System.Windows.Forms.Button();
            this.hadvar_bn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 411);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 78);
            this.label1.TabIndex = 14;
            this.label1.Text = "Необходимо бежать из Хелгена, пока не стало слишком поздно!\r\nВыберите за кем след" +
    "овать:";
            // 
            // ralof_bn
            // 
            this.ralof_bn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ralof_bn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ralof_bn.Location = new System.Drawing.Point(589, 376);
            this.ralof_bn.Name = "ralof_bn";
            this.ralof_bn.Size = new System.Drawing.Size(183, 31);
            this.ralof_bn.TabIndex = 13;
            this.ralof_bn.Text = "Ралоф - Брат Бури";
            this.ralof_bn.UseVisualStyleBackColor = false;
            this.ralof_bn.Click += new System.EventHandler(this.ralof_bn_Click);
            // 
            // hadvar_bn
            // 
            this.hadvar_bn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hadvar_bn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hadvar_bn.Location = new System.Drawing.Point(12, 376);
            this.hadvar_bn.Name = "hadvar_bn";
            this.hadvar_bn.Size = new System.Drawing.Size(180, 31);
            this.hadvar_bn.TabIndex = 13;
            this.hadvar_bn.Text = "Легионер Хадвар";
            this.hadvar_bn.UseVisualStyleBackColor = false;
            this.hadvar_bn.Click += new System.EventHandler(this.hadvar_bn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hadvar_bn);
            this.Controls.Add(this.ralof_bn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ralof_bn;
        private System.Windows.Forms.Button hadvar_bn;
    }
}