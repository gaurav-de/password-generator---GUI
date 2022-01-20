namespace password
{
    partial class password_generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(password_generator));
            this.text_length = new System.Windows.Forms.Label();
            this.text_speciality = new System.Windows.Forms.Label();
            this.start_generating = new System.Windows.Forms.Button();
            this.options_for_chracter = new System.Windows.Forms.ComboBox();
            this.special_latter_in_password = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_ready = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.up_length = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.up_length)).BeginInit();
            this.SuspendLayout();
            // 
            // text_length
            // 
            this.text_length.AutoSize = true;
            this.text_length.Location = new System.Drawing.Point(9, 7);
            this.text_length.Name = "text_length";
            this.text_length.Size = new System.Drawing.Size(173, 19);
            this.text_length.TabIndex = 0;
            this.text_length.Text = "length of your password: ";
            // 
            // text_speciality
            // 
            this.text_speciality.AutoSize = true;
            this.text_speciality.Location = new System.Drawing.Point(9, 39);
            this.text_speciality.Name = "text_speciality";
            this.text_speciality.Size = new System.Drawing.Size(233, 19);
            this.text_speciality.TabIndex = 1;
            this.text_speciality.Text = "Some special chracter in password";
            // 
            // start_generating
            // 
            this.start_generating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.start_generating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_generating.Location = new System.Drawing.Point(34, 107);
            this.start_generating.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.start_generating.Name = "start_generating";
            this.start_generating.Size = new System.Drawing.Size(156, 43);
            this.start_generating.TabIndex = 2;
            this.start_generating.Text = "generate password";
            this.start_generating.UseVisualStyleBackColor = false;
            this.start_generating.Click += new System.EventHandler(this.start_generating_Click);
            // 
            // options_for_chracter
            // 
            this.options_for_chracter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.options_for_chracter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.options_for_chracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_for_chracter.ForeColor = System.Drawing.Color.White;
            this.options_for_chracter.FormattingEnabled = true;
            this.options_for_chracter.Items.AddRange(new object[] {
            "custom chracter in left",
            "custom chracter in center",
            "custom chracter in right",
            "custom chracter shuffled "});
            this.options_for_chracter.Location = new System.Drawing.Point(248, 65);
            this.options_for_chracter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.options_for_chracter.Name = "options_for_chracter";
            this.options_for_chracter.Size = new System.Drawing.Size(153, 24);
            this.options_for_chracter.TabIndex = 9;
            // 
            // special_latter_in_password
            // 
            this.special_latter_in_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.special_latter_in_password.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special_latter_in_password.ForeColor = System.Drawing.SystemColors.Info;
            this.special_latter_in_password.Location = new System.Drawing.Point(248, 35);
            this.special_latter_in_password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.special_latter_in_password.Name = "special_latter_in_password";
            this.special_latter_in_password.Size = new System.Drawing.Size(153, 23);
            this.special_latter_in_password.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "other options for chracters";
            // 
            // password_ready
            // 
            this.password_ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.password_ready.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_ready.ForeColor = System.Drawing.SystemColors.Window;
            this.password_ready.Location = new System.Drawing.Point(144, 177);
            this.password_ready.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.password_ready.Name = "password_ready";
            this.password_ready.ReadOnly = true;
            this.password_ready.Size = new System.Drawing.Size(159, 27);
            this.password_ready.TabIndex = 13;
            this.password_ready.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "your password is: ";
            // 
            // up_length
            // 
            this.up_length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.up_length.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_length.ForeColor = System.Drawing.Color.White;
            this.up_length.Location = new System.Drawing.Point(248, 8);
            this.up_length.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.up_length.Name = "up_length";
            this.up_length.Size = new System.Drawing.Size(153, 23);
            this.up_length.TabIndex = 15;
            this.up_length.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.button1.Location = new System.Drawing.Point(309, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "copy!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(418, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.up_length);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_ready);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.special_latter_in_password);
            this.Controls.Add(this.options_for_chracter);
            this.Controls.Add(this.start_generating);
            this.Controls.Add(this.text_speciality);
            this.Controls.Add(this.text_length);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "password_generator";
            this.Text = "password generator";
            this.Load += new System.EventHandler(this.password_generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.up_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_length;
        private System.Windows.Forms.Label text_speciality;
        private System.Windows.Forms.Button start_generating;
        private System.Windows.Forms.ComboBox options_for_chracter;
        private System.Windows.Forms.MaskedTextBox special_latter_in_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox password_ready;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown up_length;
        private System.Windows.Forms.Button button1;
    }
}

