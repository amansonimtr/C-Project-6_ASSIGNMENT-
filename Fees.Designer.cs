namespace project2
{
    partial class Fees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.txtstudent = new System.Windows.Forms.TextBox();
            this.txtFeel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultydatabaseFees = new project2.FacultydatabaseFees();
            this.feesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.feesTableAdapter = new project2.FacultydatabaseFeesTableAdapters.FeesTableAdapter();
            this.feeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultydatabaseFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feeIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.feeTypeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(144, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 203);
            this.dataGridView1.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(397, 563);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpayment
            // 
            this.txtpayment.Location = new System.Drawing.Point(408, 119);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(181, 22);
            this.txtpayment.TabIndex = 24;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(408, 78);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(181, 22);
            this.txtAmount.TabIndex = 23;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(408, 41);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(181, 22);
            this.txtfee.TabIndex = 22;
            // 
            // txtstudent
            // 
            this.txtstudent.Location = new System.Drawing.Point(408, 2);
            this.txtstudent.Name = "txtstudent";
            this.txtstudent.Size = new System.Drawing.Size(181, 22);
            this.txtstudent.TabIndex = 21;
            // 
            // txtFeel
            // 
            this.txtFeel.Location = new System.Drawing.Point(408, -34);
            this.txtFeel.Name = "txtFeel";
            this.txtFeel.Size = new System.Drawing.Size(181, 22);
            this.txtFeel.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "PaymentDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "FeeType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "StudentID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "FeeID";
            // 
            // feesBindingSource
            // 
            this.feesBindingSource.DataMember = "Fees";
            // 
            // facultydatabaseFees
            // 
            this.facultydatabaseFees.DataSetName = "FacultydatabaseFees";
            this.facultydatabaseFees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feesBindingSource1
            // 
            this.feesBindingSource1.DataMember = "Fees";
            this.feesBindingSource1.DataSource = this.facultydatabaseFees;
            // 
            // feesTableAdapter
            // 
            this.feesTableAdapter.ClearBeforeFill = true;
            // 
            // feeIDDataGridViewTextBoxColumn
            // 
            this.feeIDDataGridViewTextBoxColumn.DataPropertyName = "FeeID";
            this.feeIDDataGridViewTextBoxColumn.HeaderText = "FeeID";
            this.feeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feeIDDataGridViewTextBoxColumn.Name = "feeIDDataGridViewTextBoxColumn";
            this.feeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // feeTypeDataGridViewTextBoxColumn
            // 
            this.feeTypeDataGridViewTextBoxColumn.DataPropertyName = "FeeType";
            this.feeTypeDataGridViewTextBoxColumn.HeaderText = "FeeType";
            this.feeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feeTypeDataGridViewTextBoxColumn.Name = "feeTypeDataGridViewTextBoxColumn";
            this.feeTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpayment);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.txtstudent);
            this.Controls.Add(this.txtFeel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultydatabaseFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource feesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.TextBox txtstudent;
        private System.Windows.Forms.TextBox txtFeel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FacultydatabaseFees facultydatabaseFees;
        private System.Windows.Forms.BindingSource feesBindingSource1;
        private FacultydatabaseFeesTableAdapters.FeesTableAdapter feesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
    }
}