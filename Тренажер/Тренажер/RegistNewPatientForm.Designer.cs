namespace Тренажер
{
    partial class RegistNewPatientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.manRadioBtn = new System.Windows.Forms.RadioButton();
            this.womanRadioBtn = new System.Windows.Forms.RadioButton();
            this.ageField = new System.Windows.Forms.NumericUpDown();
            this.registNewPatientBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.dadnameField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация нового пациента";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол";
           // this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возраст";
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(113, 103);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(211, 20);
            this.surnameField.TabIndex = 4;
            // 
            // manRadioBtn
            // 
            this.manRadioBtn.AutoSize = true;
            this.manRadioBtn.Checked = true;
            this.manRadioBtn.Location = new System.Drawing.Point(113, 201);
            this.manRadioBtn.Name = "manRadioBtn";
            this.manRadioBtn.Size = new System.Drawing.Size(34, 17);
            this.manRadioBtn.TabIndex = 5;
            this.manRadioBtn.TabStop = true;
            this.manRadioBtn.Text = "М";
            this.manRadioBtn.UseVisualStyleBackColor = true;
            // 
            // womanRadioBtn
            // 
            this.womanRadioBtn.AutoSize = true;
            this.womanRadioBtn.Location = new System.Drawing.Point(153, 201);
            this.womanRadioBtn.Name = "womanRadioBtn";
            this.womanRadioBtn.Size = new System.Drawing.Size(36, 17);
            this.womanRadioBtn.TabIndex = 6;
            this.womanRadioBtn.Text = "Ж";
            this.womanRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(113, 237);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(43, 20);
            this.ageField.TabIndex = 7;
            this.ageField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registNewPatientBtn
            // 
            this.registNewPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registNewPatientBtn.Location = new System.Drawing.Point(113, 281);
            this.registNewPatientBtn.Name = "registNewPatientBtn";
            this.registNewPatientBtn.Size = new System.Drawing.Size(156, 40);
            this.registNewPatientBtn.TabIndex = 8;
            this.registNewPatientBtn.Text = "Зарегистрировать";
            this.registNewPatientBtn.UseVisualStyleBackColor = true;
            this.registNewPatientBtn.Click += new System.EventHandler(this.registNewPatientBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отчество";
           // this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(113, 129);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(211, 20);
            this.nameField.TabIndex = 11;
           // this.nameField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dadnameField
            // 
            this.dadnameField.Location = new System.Drawing.Point(113, 155);
            this.dadnameField.Name = "dadnameField";
            this.dadnameField.Size = new System.Drawing.Size(211, 20);
            this.dadnameField.TabIndex = 12;
            // 
            // RegistNewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 349);
            this.Controls.Add(this.dadnameField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registNewPatientBtn);
            this.Controls.Add(this.ageField);
            this.Controls.Add(this.womanRadioBtn);
            this.Controls.Add(this.manRadioBtn);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "RegistNewPatientForm";
            this.Text = "RegistNewPatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.ageField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.RadioButton manRadioBtn;
        private System.Windows.Forms.RadioButton womanRadioBtn;
        private System.Windows.Forms.NumericUpDown ageField;
        private System.Windows.Forms.Button registNewPatientBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox dadnameField;
    }
}