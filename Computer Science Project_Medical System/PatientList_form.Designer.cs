
namespace Computer_Science_Project_Medical_System
{
    partial class PatientList_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientList_form));
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label second_NameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            this.patient_tblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patient_tblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patient_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Computer_Science_Project_Medical_System.Database1DataSet();
            this.patient_tblTableAdapter = new Computer_Science_Project_Medical_System.Database1DataSetTableAdapters.Patient_tblTableAdapter();
            this.tableAdapterManager = new Computer_Science_Project_Medical_System.Database1DataSetTableAdapters.TableAdapterManager();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.second_NameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            patient_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            second_NameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patient_tblBindingNavigator)).BeginInit();
            this.patient_tblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_tblBindingNavigator
            // 
            this.patient_tblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patient_tblBindingNavigator.BindingSource = this.patient_tblBindingSource;
            this.patient_tblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patient_tblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patient_tblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patient_tblBindingNavigatorSaveItem});
            this.patient_tblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patient_tblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patient_tblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patient_tblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patient_tblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patient_tblBindingNavigator.Name = "patient_tblBindingNavigator";
            this.patient_tblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patient_tblBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.patient_tblBindingNavigator.TabIndex = 0;
            this.patient_tblBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // patient_tblBindingNavigatorSaveItem
            // 
            this.patient_tblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patient_tblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patient_tblBindingNavigatorSaveItem.Image")));
            this.patient_tblBindingNavigatorSaveItem.Name = "patient_tblBindingNavigatorSaveItem";
            this.patient_tblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patient_tblBindingNavigatorSaveItem.Text = "Save Data";
            this.patient_tblBindingNavigatorSaveItem.Click += new System.EventHandler(this.patient_tblBindingNavigatorSaveItem_Click_1);
            // 
            // patient_tblBindingSource
            // 
            this.patient_tblBindingSource.DataMember = "Patient_tbl";
            this.patient_tblBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_tblTableAdapter
            // 
            this.patient_tblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Patient_tblTableAdapter = this.patient_tblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Computer_Science_Project_Medical_System.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Location = new System.Drawing.Point(23, 57);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(57, 13);
            patient_IDLabel.TabIndex = 1;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_tblBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(110, 54);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_IDTextBox.TabIndex = 2;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(23, 83);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_tblBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(110, 80);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // second_NameLabel
            // 
            second_NameLabel.AutoSize = true;
            second_NameLabel.Location = new System.Drawing.Point(23, 109);
            second_NameLabel.Name = "second_NameLabel";
            second_NameLabel.Size = new System.Drawing.Size(78, 13);
            second_NameLabel.TabIndex = 5;
            second_NameLabel.Text = "Second Name:";
            // 
            // second_NameTextBox
            // 
            this.second_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_tblBindingSource, "Second Name", true));
            this.second_NameTextBox.Location = new System.Drawing.Point(110, 106);
            this.second_NameTextBox.Name = "second_NameTextBox";
            this.second_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.second_NameTextBox.TabIndex = 6;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(23, 135);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_tblBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(110, 132);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 8;
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(23, 161);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel.TabIndex = 9;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_tblBindingSource, "Phone Number", true));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(110, 158);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_NumberTextBox.TabIndex = 10;
            // 
            // PatientList_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(second_NameLabel);
            this.Controls.Add(this.second_NameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.phone_NumberTextBox);
            this.Controls.Add(this.patient_tblBindingNavigator);
            this.Name = "PatientList_form";
            this.Text = "PatientList_form";
            this.Load += new System.EventHandler(this.PatientList_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patient_tblBindingNavigator)).EndInit();
            this.patient_tblBindingNavigator.ResumeLayout(false);
            this.patient_tblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource patient_tblBindingSource;
        private Database1DataSetTableAdapters.Patient_tblTableAdapter patient_tblTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patient_tblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patient_tblBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox second_NameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
    }
}