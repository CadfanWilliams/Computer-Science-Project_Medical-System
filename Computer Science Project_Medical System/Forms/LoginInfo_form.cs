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
    public partial class LoginInfo_form : Form
    {
        public LoginInfo_form()
        {
            InitializeComponent();
        }

        private void LoginInfo_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Login_Table' table. You can move, or remove it, as needed.
            this.login_TableTableAdapter.Fill(this.database1DataSet1.Login_Table);


        }

        private void login_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.login_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }
    }
}
