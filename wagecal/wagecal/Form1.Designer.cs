namespace wagecal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getwage = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cover = new System.Windows.Forms.Panel();
            this.thetable = new System.Windows.Forms.DataGridView();
            this.database1DataSet1 = new wagecal.Database1DataSet1();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerTableAdapter = new wagecal.Database1DataSet1TableAdapters.ownerTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursWorkedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wageGivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extracutsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabl = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Panel();
            this.passbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.conclusion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            this.tabl.SuspendLayout();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // getwage
            // 
            this.getwage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getwage.Location = new System.Drawing.Point(18, 251);
            this.getwage.Name = "getwage";
            this.getwage.Size = new System.Drawing.Size(127, 51);
            this.getwage.TabIndex = 0;
            this.getwage.Text = "get wage";
            this.getwage.UseVisualStyleBackColor = true;
            this.getwage.Click += new System.EventHandler(this.getwage_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(18, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(206, 32);
            this.name.TabIndex = 1;
            this.name.Text = "name               : ";
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametext.Location = new System.Drawing.Point(230, 28);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(258, 38);
            this.nametext.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(12, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(192, 48);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "manager";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(12, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(217, 48);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "supervisor";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(12, 153);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(155, 48);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "worker";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(219, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 221);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "select your";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hours
            // 
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(230, 91);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(258, 38);
            this.hours.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "hours worked : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "position";
            // 
            // cover
            // 
            this.cover.BackColor = System.Drawing.Color.White;
            this.cover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cover.BackgroundImage")));
            this.cover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cover.Location = new System.Drawing.Point(497, 28);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(696, 371);
            this.cover.TabIndex = 12;
            // 
            // thetable
            // 
            this.thetable.AutoGenerateColumns = false;
            this.thetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.hoursWorkedDataGridViewTextBoxColumn,
            this.wageGivenDataGridViewTextBoxColumn,
            this.extracutsDataGridViewTextBoxColumn});
            this.thetable.DataSource = this.ownerBindingSource;
            this.thetable.Location = new System.Drawing.Point(3, 6);
            this.thetable.Name = "thetable";
            this.thetable.RowTemplate.Height = 24;
            this.thetable.Size = new System.Drawing.Size(679, 333);
            this.thetable.TabIndex = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "owner";
            this.ownerBindingSource.DataSource = this.database1DataSet1;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // hoursWorkedDataGridViewTextBoxColumn
            // 
            this.hoursWorkedDataGridViewTextBoxColumn.DataPropertyName = "hours worked";
            this.hoursWorkedDataGridViewTextBoxColumn.HeaderText = "hours worked";
            this.hoursWorkedDataGridViewTextBoxColumn.Name = "hoursWorkedDataGridViewTextBoxColumn";
            // 
            // wageGivenDataGridViewTextBoxColumn
            // 
            this.wageGivenDataGridViewTextBoxColumn.DataPropertyName = "wage given";
            this.wageGivenDataGridViewTextBoxColumn.HeaderText = "wage given";
            this.wageGivenDataGridViewTextBoxColumn.Name = "wageGivenDataGridViewTextBoxColumn";
            // 
            // extracutsDataGridViewTextBoxColumn
            // 
            this.extracutsDataGridViewTextBoxColumn.DataPropertyName = "extra/cuts";
            this.extracutsDataGridViewTextBoxColumn.HeaderText = "extra/cuts";
            this.extracutsDataGridViewTextBoxColumn.Name = "extracutsDataGridViewTextBoxColumn";
            // 
            // tabl
            // 
            this.tabl.BackColor = System.Drawing.Color.White;
            this.tabl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabl.Controls.Add(this.thetable);
            this.tabl.Location = new System.Drawing.Point(508, 63);
            this.tabl.Name = "tabl";
            this.tabl.Size = new System.Drawing.Size(685, 339);
            this.tabl.TabIndex = 14;
            this.tabl.Paint += new System.Windows.Forms.PaintEventHandler(this.tabl_Paint);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Gray;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Controls.Add(this.button4);
            this.login.Controls.Add(this.passbox);
            this.login.Controls.Add(this.label5);
            this.login.Location = new System.Drawing.Point(524, 44);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(666, 345);
            this.login.TabIndex = 15;
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.Location = new System.Drawing.Point(74, 127);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '☻';
            this.passbox.Size = new System.Drawing.Size(414, 38);
            this.passbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(150, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "accountant password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(156, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "get todays wage details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // conclusion
            // 
            this.conclusion.AutoSize = true;
            this.conclusion.BackColor = System.Drawing.Color.Black;
            this.conclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conclusion.ForeColor = System.Drawing.Color.White;
            this.conclusion.Location = new System.Drawing.Point(12, 424);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(983, 39);
            this.conclusion.TabIndex = 16;
            this.conclusion.Text = " --------------------------------------------------------------------------------" +
    "-------";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1048, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 51);
            this.button1.TabIndex = 17;
            this.button1.Text = "admin ?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(19, 316);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(127, 51);
            this.clear.TabIndex = 18;
            this.clear.Text = "done";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1205, 500);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.login);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.tabl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.name);
            this.Controls.Add(this.getwage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "WAGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            this.tabl.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getwage;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel cover;
        private System.Windows.Forms.DataGridView thetable;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private Database1DataSet1TableAdapters.ownerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursWorkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wageGivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extracutsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel tabl;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label conclusion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
    }
}

