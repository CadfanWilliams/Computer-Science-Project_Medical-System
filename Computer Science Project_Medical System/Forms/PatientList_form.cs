using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System
{
    public partial class PatientList_form : Form
    {
        public PatientList_form()
        {
            InitializeComponent();
        }

        private void patient_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void PatientList_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Patient_tbl' table. You can move, or remove it, as needed.
            this.patient_tblTableAdapter.Fill(this.database1DataSet.Patient_tbl);
            // TODO: This line of code loads data into the 'database1DataSet1.Patient_tbl' table. You can move, or remove it, as needed.
            this.patient_tblTableAdapter.Fill(this.database1DataSet.Patient_tbl);

        }

        private void patient_tblBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(genderCheckBox.Checked == true)
            {
                genderCheckBox.Text = "F";
            }
            else
            {
                genderCheckBox.Text = "M";
            }
        }
    }
}
