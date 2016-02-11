namespace PersonListe.GUI
{
    partial class PersonListeForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbPersonData = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAlder = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblStilling = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.gbPersonData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(88, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // gbPersonData
            // 
            this.gbPersonData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbPersonData.Controls.Add(this.btnClearForm);
            this.gbPersonData.Controls.Add(this.txtAge);
            this.gbPersonData.Controls.Add(this.lblAlder);
            this.gbPersonData.Controls.Add(this.txtPosition);
            this.gbPersonData.Controls.Add(this.lblStilling);
            this.gbPersonData.Controls.Add(this.btnDelete);
            this.gbPersonData.Controls.Add(this.txtLastName);
            this.gbPersonData.Controls.Add(this.btnSave);
            this.gbPersonData.Controls.Add(this.lblLastName);
            this.gbPersonData.Controls.Add(this.btnCreate);
            this.gbPersonData.Controls.Add(this.txtFirstName);
            this.gbPersonData.Controls.Add(this.lblFirstName);
            this.gbPersonData.Location = new System.Drawing.Point(33, 287);
            this.gbPersonData.Name = "gbPersonData";
            this.gbPersonData.Size = new System.Drawing.Size(347, 160);
            this.gbPersonData.TabIndex = 3;
            this.gbPersonData.TabStop = false;
            this.gbPersonData.Text = "Person Data";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(88, 111);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(112, 20);
            this.txtAge.TabIndex = 7;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // lblAlder
            // 
            this.lblAlder.AutoSize = true;
            this.lblAlder.Location = new System.Drawing.Point(16, 115);
            this.lblAlder.Name = "lblAlder";
            this.lblAlder.Size = new System.Drawing.Size(29, 13);
            this.lblAlder.TabIndex = 8;
            this.lblAlder.Text = "Age:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(88, 84);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(112, 20);
            this.txtPosition.TabIndex = 5;
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // lblStilling
            // 
            this.lblStilling.AutoSize = true;
            this.lblStilling.Location = new System.Drawing.Point(16, 87);
            this.lblStilling.Name = "lblStilling";
            this.lblStilling.Size = new System.Drawing.Size(47, 13);
            this.lblStilling.TabIndex = 6;
            this.lblStilling.Text = "Position:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(88, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(112, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(221, 11);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 31);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(221, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.AllowUserToResizeRows = false;
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(3, 46);
            this.dgvPersons.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersons.MultiSelect = false;
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersVisible = false;
            this.dgvPersons.RowTemplate.Height = 24;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(417, 156);
            this.dgvPersons.TabIndex = 17;
            this.dgvPersons.SelectionChanged += new System.EventHandler(this.dgvPersons_SelectionChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(95, 13);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search for Person:";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(221, 123);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 31);
            this.btnClearForm.TabIndex = 21;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // PersonListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.gbPersonData);
            this.MinimizeBox = false;
            this.Name = "PersonListeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PersonListe";
            this.Load += new System.EventHandler(this.PersonListeForm_Load);
            this.Resize += new System.EventHandler(this.PersonListeForm_Resize);
            this.gbPersonData.ResumeLayout(false);
            this.gbPersonData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbPersonData;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAlder;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblStilling;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClearForm;
    }
}

