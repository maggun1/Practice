namespace WindowsFormsVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ork_button = new System.Windows.Forms.Button();
            this.elven_button = new System.Windows.Forms.Button();
            this.nord_button = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список приговоренных заканчивается, но нашего имени там нет.\r\nХадвар спрашивает н" +
    "ас: “А кто ты?”";
            // 
            // ork_button
            // 
            this.ork_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ork_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ork_button.Location = new System.Drawing.Point(665, 373);
            this.ork_button.Name = "ork_button";
            this.ork_button.Size = new System.Drawing.Size(107, 31);
            this.ork_button.TabIndex = 5;
            this.ork_button.Text = "Орк";
            this.ork_button.UseVisualStyleBackColor = false;
            this.ork_button.Click += new System.EventHandler(this.ork_button_Click);
            // 
            // elven_button
            // 
            this.elven_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.elven_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elven_button.Location = new System.Drawing.Point(348, 373);
            this.elven_button.Name = "elven_button";
            this.elven_button.Size = new System.Drawing.Size(107, 31);
            this.elven_button.TabIndex = 6;
            this.elven_button.Text = "Эльф";
            this.elven_button.UseVisualStyleBackColor = false;
            this.elven_button.Click += new System.EventHandler(this.elven_button_Click);
            // 
            // nord_button
            // 
            this.nord_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nord_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nord_button.Location = new System.Drawing.Point(12, 373);
            this.nord_button.Name = "nord_button";
            this.nord_button.Size = new System.Drawing.Size(107, 31);
            this.nord_button.TabIndex = 7;
            this.nord_button.Text = "Норд";
            this.nord_button.UseVisualStyleBackColor = false;
            this.nord_button.Click += new System.EventHandler(this.nord_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ork_button);
            this.Controls.Add(this.elven_button);
            this.Controls.Add(this.nord_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ork_button;
        private System.Windows.Forms.Button elven_button;
        private System.Windows.Forms.Button nord_button;
    }
}

