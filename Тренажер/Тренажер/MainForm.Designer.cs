namespace Тренажер
{
    partial class MainForm
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
            this.regMainBtn = new System.Windows.Forms.Button();
            this.listPatientViewButton = new System.Windows.Forms.Button();
            this.regNewExaminationBtn = new System.Windows.Forms.Button();
            this.closeApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тренажер";
            // 
            // regMainBtn
            // 
            this.regMainBtn.Location = new System.Drawing.Point(63, 130);
            this.regMainBtn.Name = "regMainBtn";
            this.regMainBtn.Size = new System.Drawing.Size(118, 70);
            this.regMainBtn.TabIndex = 1;
            this.regMainBtn.Text = "Регистрация нового пользователя";
            this.regMainBtn.UseVisualStyleBackColor = true;
            this.regMainBtn.Click += new System.EventHandler(this.regMainBtn_Click);
            // 
            // listPatientViewButton
            // 
            this.listPatientViewButton.Location = new System.Drawing.Point(302, 130);
            this.listPatientViewButton.Name = "listPatientViewButton";
            this.listPatientViewButton.Size = new System.Drawing.Size(118, 70);
            this.listPatientViewButton.TabIndex = 2;
            this.listPatientViewButton.Text = "Список пациентов";
            this.listPatientViewButton.UseVisualStyleBackColor = true;
            this.listPatientViewButton.Click += new System.EventHandler(this.listPatientViewButton_Click);
            // 
            // regNewExaminationBtn
            // 
            this.regNewExaminationBtn.Location = new System.Drawing.Point(183, 234);
            this.regNewExaminationBtn.Name = "regNewExaminationBtn";
            this.regNewExaminationBtn.Size = new System.Drawing.Size(118, 70);
            this.regNewExaminationBtn.TabIndex = 3;
            this.regNewExaminationBtn.Text = "Регистрация нового обследования";
            this.regNewExaminationBtn.UseVisualStyleBackColor = true;
            this.regNewExaminationBtn.Click += new System.EventHandler(this.regNewExaminationBtn_Click);
            // 
            // closeApp
            // 
            this.closeApp.Location = new System.Drawing.Point(183, 346);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(133, 56);
            this.closeApp.TabIndex = 5;
            this.closeApp.Text = "Закрыть";
            this.closeApp.UseVisualStyleBackColor = true;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 423);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.regNewExaminationBtn);
            this.Controls.Add(this.listPatientViewButton);
            this.Controls.Add(this.regMainBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regMainBtn;
        private System.Windows.Forms.Button listPatientViewButton;
        private System.Windows.Forms.Button regNewExaminationBtn;
        private System.Windows.Forms.Button closeApp;
    }
}