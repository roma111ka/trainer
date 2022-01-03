using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тренажер
{
    public partial class registNewExaminationForm : Form
    {
        private string typeOfPhis;
        private string dateTime;
        public DtoPatient DtoPatient;

        public registNewExaminationForm()
        {
           
            InitializeComponent();
        }


        private void regNewExamBtn_Click(object sender, EventArgs e)
        {
            string dateTime = dateTimeExamin.Value.Date.ToString("dd/MM/yyyy");

            if (radioBtnRun.TabStop == true)
            {
                typeOfPhis = radioBtnRun.Text;
            }
            else if (radioBtnWalk.TabStop == true)
            {
                typeOfPhis = radioBtnWalk.Text;
            }
            else if (radioBtnVelo.TabStop == true)
            {
                typeOfPhis = radioBtnVelo.Text;
            }
            else if (radioBtnVelo.TabStop == true)
            {
                typeOfPhis = radioBtnVelo.Text;
            }
            else if (radioBtnHighLvl.TabStop == true)
            {
                typeOfPhis = radioBtnHighLvl.Text;
            }
            else
                typeOfPhis = "";

            List<string> listBoxForSensors= new List<string>();
            List<bool> indexItem = new List<bool> { false,false,false,false,false };
            if (checkBoxPres.Checked == true)
            {
                listBoxForSensors.Add(checkBoxPres.Text);
                indexItem[0] = true;
            }
            if (checkBoxTemp.Checked == true)
            {
                listBoxForSensors.Add(checkBoxTemp.Text);
                indexItem[1] = true;
            }
            if (checkBoxConduct.Checked == true)
            {
                listBoxForSensors.Add(checkBoxConduct.Text);
                indexItem[3] = true;
            }
            if (checkBoxHumd.Checked == true)
            {
                listBoxForSensors.Add(checkBoxHumd.Text);
                indexItem[2] = true;
            }
            if (checkBoxFreq.Checked == true)
            {
                listBoxForSensors.Add(checkBoxFreq.Text);
                indexItem[4] = true;
            }
            else
                listBoxForSensors.Add("");


            var dto = new Dto();
            sessionExamination sessionExamination = new sessionExamination();
          
            dto.cheked = typeOfPhis;
            dto.Items = listBoxForSensors;
            dto.IndexItems = indexItem;
            dto.dateTime = dateTime;
            sessionExamination.Dto = dto;
            sessionExamination.DtoPatient = DtoPatient;
            this.Hide();
           
          
           
            sessionExamination.Show();
            
            
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
