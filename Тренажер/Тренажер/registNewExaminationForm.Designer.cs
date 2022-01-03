namespace Тренажер
{
    partial class registNewExaminationForm
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
            this.dateTimeExamin = new System.Windows.Forms.DateTimePicker();
            this.regNewExamBtn = new System.Windows.Forms.Button();
            this.radioBtnRun = new System.Windows.Forms.RadioButton();
            this.radioBtnWalk = new System.Windows.Forms.RadioButton();
            this.radioBtnVelo = new System.Windows.Forms.RadioButton();
            this.radioBtnHighLvl = new System.Windows.Forms.RadioButton();
            this.checkBoxPres = new System.Windows.Forms.CheckBox();
            this.checkBoxTemp = new System.Windows.Forms.CheckBox();
            this.checkBoxHumd = new System.Windows.Forms.CheckBox();
            this.checkBoxConduct = new System.Windows.Forms.CheckBox();
            this.checkBoxFreq = new System.Windows.Forms.CheckBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация нового обследования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата регистрации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип физической нагрузки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(58, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Измеряемые показатели";
            // 
            // dateTimeExamin
            // 
            this.dateTimeExamin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExamin.Location = new System.Drawing.Point(315, 157);
            this.dateTimeExamin.Name = "dateTimeExamin";
            this.dateTimeExamin.Size = new System.Drawing.Size(160, 20);
            this.dateTimeExamin.TabIndex = 6;
            this.dateTimeExamin.Value = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            // 
            // regNewExamBtn
            // 
            this.regNewExamBtn.Location = new System.Drawing.Point(104, 482);
            this.regNewExamBtn.Name = "regNewExamBtn";
            this.regNewExamBtn.Size = new System.Drawing.Size(168, 39);
            this.regNewExamBtn.TabIndex = 7;
            this.regNewExamBtn.Text = "Зарегистировать";
            this.regNewExamBtn.UseVisualStyleBackColor = true;
            this.regNewExamBtn.Click += new System.EventHandler(this.regNewExamBtn_Click);
            // 
            // radioBtnRun
            // 
            this.radioBtnRun.AutoSize = true;
            this.radioBtnRun.Checked = true;
            this.radioBtnRun.Location = new System.Drawing.Point(315, 218);
            this.radioBtnRun.Name = "radioBtnRun";
            this.radioBtnRun.Size = new System.Drawing.Size(42, 17);
            this.radioBtnRun.TabIndex = 8;
            this.radioBtnRun.TabStop = true;
            this.radioBtnRun.Text = "бег";
            this.radioBtnRun.UseVisualStyleBackColor = true;
            // 
            // radioBtnWalk
            // 
            this.radioBtnWalk.AutoSize = true;
            this.radioBtnWalk.Location = new System.Drawing.Point(315, 241);
            this.radioBtnWalk.Name = "radioBtnWalk";
            this.radioBtnWalk.Size = new System.Drawing.Size(60, 17);
            this.radioBtnWalk.TabIndex = 9;
            this.radioBtnWalk.Text = "ходьба";
            this.radioBtnWalk.UseVisualStyleBackColor = true;
            // 
            // radioBtnVelo
            // 
            this.radioBtnVelo.AutoSize = true;
            this.radioBtnVelo.Location = new System.Drawing.Point(315, 264);
            this.radioBtnVelo.Name = "radioBtnVelo";
            this.radioBtnVelo.Size = new System.Drawing.Size(49, 17);
            this.radioBtnVelo.TabIndex = 10;
            this.radioBtnVelo.Text = "вело";
            this.radioBtnVelo.UseVisualStyleBackColor = true;
            // 
            // radioBtnHighLvl
            // 
            this.radioBtnHighLvl.AutoSize = true;
            this.radioBtnHighLvl.Location = new System.Drawing.Point(315, 287);
            this.radioBtnHighLvl.Name = "radioBtnHighLvl";
            this.radioBtnHighLvl.Size = new System.Drawing.Size(133, 17);
            this.radioBtnHighLvl.TabIndex = 11;
            this.radioBtnHighLvl.Text = "силовые упражнения";
            this.radioBtnHighLvl.UseVisualStyleBackColor = true;
            // 
            // checkBoxPres
            // 
            this.checkBoxPres.AutoSize = true;
            this.checkBoxPres.Location = new System.Drawing.Point(315, 332);
            this.checkBoxPres.Name = "checkBoxPres";
            this.checkBoxPres.Size = new System.Drawing.Size(126, 17);
            this.checkBoxPres.TabIndex = 12;
            this.checkBoxPres.Text = "Кровяное давление";
            this.checkBoxPres.UseVisualStyleBackColor = true;
            // 
            // checkBoxTemp
            // 
            this.checkBoxTemp.AutoSize = true;
            this.checkBoxTemp.Location = new System.Drawing.Point(315, 356);
            this.checkBoxTemp.Name = "checkBoxTemp";
            this.checkBoxTemp.Size = new System.Drawing.Size(122, 17);
            this.checkBoxTemp.TabIndex = 13;
            this.checkBoxTemp.Text = "Температура кожи";
            this.checkBoxTemp.UseVisualStyleBackColor = true;
            // 
            // checkBoxHumd
            // 
            this.checkBoxHumd.AutoSize = true;
            this.checkBoxHumd.Location = new System.Drawing.Point(315, 380);
            this.checkBoxHumd.Name = "checkBoxHumd";
            this.checkBoxHumd.Size = new System.Drawing.Size(111, 17);
            this.checkBoxHumd.TabIndex = 14;
            this.checkBoxHumd.Text = "Влажность кожи";
            this.checkBoxHumd.UseVisualStyleBackColor = true;
            // 
            // checkBoxConduct
            // 
            this.checkBoxConduct.AutoSize = true;
            this.checkBoxConduct.Location = new System.Drawing.Point(315, 404);
            this.checkBoxConduct.Name = "checkBoxConduct";
            this.checkBoxConduct.Size = new System.Drawing.Size(214, 17);
            this.checkBoxConduct.TabIndex = 15;
            this.checkBoxConduct.Text = "Элекстрическая проводимость кожи";
            this.checkBoxConduct.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreq
            // 
            this.checkBoxFreq.AutoSize = true;
            this.checkBoxFreq.Location = new System.Drawing.Point(315, 427);
            this.checkBoxFreq.Name = "checkBoxFreq";
            this.checkBoxFreq.Size = new System.Drawing.Size(201, 17);
            this.checkBoxFreq.TabIndex = 16;
            this.checkBoxFreq.Text = "Частота пульса сердечного ритма";
            this.checkBoxFreq.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(307, 482);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(168, 39);
            this.close_btn.TabIndex = 17;
            this.close_btn.Text = "Закрыть";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // registNewExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 533);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.checkBoxFreq);
            this.Controls.Add(this.checkBoxConduct);
            this.Controls.Add(this.checkBoxHumd);
            this.Controls.Add(this.checkBoxTemp);
            this.Controls.Add(this.checkBoxPres);
            this.Controls.Add(this.radioBtnHighLvl);
            this.Controls.Add(this.radioBtnVelo);
            this.Controls.Add(this.radioBtnWalk);
            this.Controls.Add(this.radioBtnRun);
            this.Controls.Add(this.regNewExamBtn);
            this.Controls.Add(this.dateTimeExamin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registNewExaminationForm";
            this.Text = "registNewExaminationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeExamin;
        private System.Windows.Forms.Button regNewExamBtn;
        private System.Windows.Forms.RadioButton radioBtnRun;
        private System.Windows.Forms.RadioButton radioBtnWalk;
        private System.Windows.Forms.RadioButton radioBtnHighLvl;
        private System.Windows.Forms.CheckBox checkBoxPres;
        private System.Windows.Forms.CheckBox checkBoxTemp;
        private System.Windows.Forms.CheckBox checkBoxHumd;
        private System.Windows.Forms.CheckBox checkBoxConduct;
        private System.Windows.Forms.CheckBox checkBoxFreq;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.RadioButton radioBtnVelo;
    }
}