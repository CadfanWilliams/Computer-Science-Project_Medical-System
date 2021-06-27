
namespace Computer_Science_Project_Medical_System
{
    partial class LoginInfo_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInfo_form));
            System.Windows.Forms.Label login_IDLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label doctor_Label;
            this.database1DataSet1 = new Computer_Science_Project_Medical_System.Database1DataSet1();
            this.login_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_TableTableAdapter = new Computer_Science_Project_Medical_System.Database1DataSet1TableAdapters.Login_TableTableAdapter();
            this.tableAdapterManager = new Computer_Science_Project_Medical_System.Database1DataSet1TableAdapters.TableAdapterManager();
            this.login_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.login_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.login_IDTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.doctor_CheckBox = new System.Windows.Forms.CheckBox();
            login_IDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            doctor_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_TableBindingNavigator)).BeginInit();
            this.login_TableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // login_TableBindingSource
            // 
            this.login_TableBindingSource.DataMember = "Login Table";
            this.login_TableBindingSource.DataSource = this.database1DataSet1;
            // 
            // login_TableTableAdapter
            // 
            this.login_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Login_TableTableAdapter = this.login_TableTableAdapter;
            this.tableAdapterManager.Patient_tblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Computer_Science_Project_Medical_System.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // login_TableBindingNavigator
            // 
            this.login_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.login_TableBindingNavigator.BindingSource = this.login_TableBindingSource;
            this.login_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.login_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.login_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.login_TableBindingNavigatorSaveItem});
            this.login_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.login_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.login_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.login_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.login_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.login_TableBindingNavigator.Name = "login_TableBindingNavigator";
            this.login_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.login_TableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.login_TableBindingNavigator.TabIndex = 0;
            this.login_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // login_TableBindingNavigatorSaveItem
            // 
            this.login_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.login_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("login_TableBindingNavigatorSaveItem.Image")));
            this.login_TableBindingNavigatorSaveItem.Name = "login_TableBindingNavigatorSaveItem";
            this.login_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.login_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.login_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.login_TableBindingNavigatorSaveItem_Click);
            // 
            // login_IDLabel
            // 
            login_IDLabel.AutoSize = true;
            login_IDLabel.Location = new System.Drawing.Point(45, 50);
            login_IDLabel.Name = "login_IDLabel";
            login_IDLabel.Size = new System.Drawing.Size(50, 13);
            login_IDLabel.TabIndex = 1;
            login_IDLabel.Text = "Login ID:";
            // 
            // login_IDTextBox
            // 
            this.login_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.login_TableBindingSource, "Login ID", true));
            this.login_IDTextBox.Location = new System.Drawing.Point(114, 47);
            this.login_IDTextBox.Name = "login_IDTextBox";
            this.login_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.login_IDTextBox.TabIndex = 2;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(45, 76);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.login_TableBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(114, 73);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.userNameTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(45, 102);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.login_TableBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(114, 99);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(104, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // doctor_Label
            // 
            doctor_Label.AutoSize = true;
            doctor_Label.Location = new System.Drawing.Point(45, 130);
            doctor_Label.Name = "doctor_Label";
            doctor_Label.Size = new System.Drawing.Size(48, 13);
            doctor_Label.TabIndex = 7;
            doctor_Label.Text = "Doctor?:";
            // 
            // doctor_CheckBox
            // 
            this.doctor_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.login_TableBindingSource, "Doctor?", true));
            this.doctor_CheckBox.Location = new System.Drawing.Point(114, 125);
            this.doctor_CheckBox.Name = "doctor_CheckBox";
            this.doctor_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.doctor_CheckBox.TabIndex = 8;
            this.doctor_CheckBox.Text = "checkBox1";
            this.doctor_CheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginInfo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(login_IDLabel);
            this.Controls.Add(this.login_IDTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(doctor_Label);
            this.Controls.Add(this.doctor_CheckBox);
            this.Controls.Add(this.login_TableBindingNavigator);
            this.Name = "LoginInfo_form";
            this.Text = "LoginInfo_form";
            this.Load += new System.EventHandler(this.LoginInfo_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_TableBindingNavigator)).EndInit();
            this.login_TableBindingNavigator.ResumeLayout(false);
            this.login_TableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource login_TableBindingSource;
        private Database1DataSet1TableAdapters.Login_TableTableAdapter login_TableTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator login_TableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton login_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox login_IDTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox doctor_CheckBox;
    }
}