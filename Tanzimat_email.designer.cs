namespace WindowsFormsApplication11_Part_SMS
{
    partial class Tanzimat_email
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newMokhatabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.نامDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.فامیلیDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تلفنهمراهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.رایاننامهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.توضیحاتDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.انتخابDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMokhatabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "save for short time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "hjelovdar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "11336699";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 76);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "pass:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "@gmail.com",
            "@yahoo.com",
            "@ymail.com"});
            this.comboBox1.Location = new System.Drawing.Point(230, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "please input your gmail:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "hjelovdar@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "For eample:  hjelovdar@gmail.com";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.newMokhatabBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(330, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // newMokhatabBindingSource
            // 
            this.newMokhatabBindingSource.DataMember = "New_M";
            // 
            // نامDataGridViewTextBoxColumn
            // 
            this.نامDataGridViewTextBoxColumn.DataPropertyName = "نام";
            this.نامDataGridViewTextBoxColumn.HeaderText = "نام";
            this.نامDataGridViewTextBoxColumn.Name = "نامDataGridViewTextBoxColumn";
            // 
            // فامیلیDataGridViewTextBoxColumn
            // 
            this.فامیلیDataGridViewTextBoxColumn.DataPropertyName = "فامیلی";
            this.فامیلیDataGridViewTextBoxColumn.HeaderText = "فامیلی";
            this.فامیلیDataGridViewTextBoxColumn.Name = "فامیلیDataGridViewTextBoxColumn";
            // 
            // تلفنهمراهDataGridViewTextBoxColumn
            // 
            this.تلفنهمراهDataGridViewTextBoxColumn.DataPropertyName = "شماره_همراه";
            this.تلفنهمراهDataGridViewTextBoxColumn.HeaderText = "شماره_همراه";
            this.تلفنهمراهDataGridViewTextBoxColumn.Name = "تلفنهمراهDataGridViewTextBoxColumn";
            // 
            // رایاننامهDataGridViewTextBoxColumn
            // 
            this.رایاننامهDataGridViewTextBoxColumn.DataPropertyName = "رایان_نامه";
            this.رایاننامهDataGridViewTextBoxColumn.HeaderText = "رایان_نامه";
            this.رایاننامهDataGridViewTextBoxColumn.Name = "رایاننامهDataGridViewTextBoxColumn";
            // 
            // توضیحاتDataGridViewTextBoxColumn
            // 
            this.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات";
            this.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn";
            // 
            // انتخابDataGridViewCheckBoxColumn
            // 
            this.انتخابDataGridViewCheckBoxColumn.DataPropertyName = "انتخاب";
            this.انتخابDataGridViewCheckBoxColumn.HeaderText = "انتخاب";
            this.انتخابDataGridViewCheckBoxColumn.Name = "انتخابDataGridViewCheckBoxColumn";
            // 
            // Tanzimat_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tanzimat_email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات ارسال رایانامه فرستنده";
            this.Load += new System.EventHandler(this.Tanzimat_email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMokhatabBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.BindingSource newMokhatabBindingSource;
   
        private System.Windows.Forms.DataGridViewTextBoxColumn کدمخاطبDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نامDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn فامیلیDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تلفنهمراهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn رایاننامهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn توضیحاتDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn انتخابDataGridViewCheckBoxColumn;
    }
}