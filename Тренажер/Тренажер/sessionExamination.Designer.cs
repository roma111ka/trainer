namespace Тренажер
{
    partial class sessionExamination
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedSensors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startSession = new System.Windows.Forms.Button();
            this.parametrsView = new System.Windows.Forms.Label();
            this.activateSensors = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Активизация сеанса обследования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Установка датчиков:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Кровяное давление",
            "Температура кожи",
            "Влажность кожи",
            "Электрическая проводимость кожи",
            "Частота пульса сердечного ритма"});
            this.checkedListBox1.Location = new System.Drawing.Point(35, 199);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(257, 79);
            this.checkedListBox1.TabIndex = 1;
            // 
            // checkedSensors
            // 
            this.checkedSensors.Location = new System.Drawing.Point(168, 302);
            this.checkedSensors.Name = "checkedSensors";
            this.checkedSensors.Size = new System.Drawing.Size(127, 38);
            this.checkedSensors.TabIndex = 3;
            this.checkedSensors.Text = "Проверка датчиков";
            this.checkedSensors.UseVisualStyleBackColor = true;
            this.checkedSensors.Click += new System.EventHandler(this.checkedSensors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(358, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Измеряемые физиологические показатели";
            // 
            // startSession
            // 
            this.startSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startSession.Location = new System.Drawing.Point(354, 451);
            this.startSession.Name = "startSession";
            this.startSession.Size = new System.Drawing.Size(306, 72);
            this.startSession.TabIndex = 5;
            this.startSession.Text = "НАЧАТЬ СЕАНС";
            this.startSession.UseVisualStyleBackColor = true;
            this.startSession.Click += new System.EventHandler(this.startSession_Click);
            // 
            // parametrsView
            // 
            this.parametrsView.AutoSize = true;
            this.parametrsView.Location = new System.Drawing.Point(369, 199);
            this.parametrsView.Name = "parametrsView";
            this.parametrsView.Size = new System.Drawing.Size(0, 13);
            this.parametrsView.TabIndex = 6;
            // 
            // activateSensors
            // 
            this.activateSensors.Location = new System.Drawing.Point(35, 302);
            this.activateSensors.Name = "activateSensors";
            this.activateSensors.Size = new System.Drawing.Size(127, 38);
            this.activateSensors.TabIndex = 7;
            this.activateSensors.Text = "Активировать датчики";
            this.activateSensors.UseVisualStyleBackColor = true;
            this.activateSensors.Click += new System.EventHandler(this.activateSensors_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // sessionExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.activateSensors);
            this.Controls.Add(this.parametrsView);
            this.Controls.Add(this.startSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedSensors);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sessionExamination";
            this.Text = "sessionExamination";
            this.Load += new System.EventHandler(this.sessionExamination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button checkedSensors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startSession;
        private System.Windows.Forms.Label parametrsView;
        private System.Windows.Forms.Button activateSensors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}