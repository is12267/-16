
namespace Подай_на_16
{
    partial class Запись_на_услугу
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Запись_на_услугу));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.w1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qaDataSet3 = new Подай_на_16.qaDataSet3();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qaDataSet = new Подай_на_16.qaDataSet();
            this.serviceTableAdapter = new Подай_на_16.qaDataSetTableAdapters.ServiceTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clientsCMBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qaDataSet2 = new Подай_на_16.qaDataSet2();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qaDataSet1 = new Подай_на_16.qaDataSet1();
            this.clientTableAdapter = new Подай_на_16.qaDataSet1TableAdapters.ClientTableAdapter();
            this.Добавить = new System.Windows.Forms.Button();
            this.clientsCMBTableAdapter = new Подай_на_16.qaDataSet2TableAdapters.clientsCMBTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.w1TableAdapter = new Подай_на_16.qaDataSet3TableAdapters.w1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsCMBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(39, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(410, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.w1BindingSource;
            this.comboBox1.DisplayMember = "ser";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID";
            // 
            // w1BindingSource
            // 
            this.w1BindingSource.DataMember = "w1";
            this.w1BindingSource.DataSource = this.qaDataSet3;
            // 
            // qaDataSet3
            // 
            this.qaDataSet3.DataSetName = "qaDataSet3";
            this.qaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.qaDataSet;
            // 
            // qaDataSet
            // 
            this.qaDataSet.DataSetName = "qaDataSet";
            this.qaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.clientsCMBBindingSource;
            this.comboBox2.DisplayMember = "ClientName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(39, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(336, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "ID";
            // 
            // clientsCMBBindingSource
            // 
            this.clientsCMBBindingSource.DataMember = "clientsCMB";
            this.clientsCMBBindingSource.DataSource = this.qaDataSet2;
            // 
            // qaDataSet2
            // 
            this.qaDataSet2.DataSetName = "qaDataSet2";
            this.qaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.qaDataSet1;
            // 
            // qaDataSet1
            // 
            this.qaDataSet1.DataSetName = "qaDataSet1";
            this.qaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.White;
            this.Добавить.Location = new System.Drawing.Point(39, 334);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(87, 52);
            this.Добавить.TabIndex = 4;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // clientsCMBTableAdapter
            // 
            this.clientsCMBTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 286);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(169, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // w1TableAdapter
            // 
            this.w1TableAdapter.ClearBeforeFill = true;
            // 
            // Запись_на_услугу
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Запись_на_услугу";
            this.Text = "Запись_на_услугу";
            this.Load += new System.EventHandler(this.Запись_на_услугу_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsCMBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private qaDataSet qaDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private qaDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private qaDataSet1 qaDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private qaDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button Добавить;
        private qaDataSet2 qaDataSet2;
        private System.Windows.Forms.BindingSource clientsCMBBindingSource;
        private qaDataSet2TableAdapters.clientsCMBTableAdapter clientsCMBTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private qaDataSet3 qaDataSet3;
        private System.Windows.Forms.BindingSource w1BindingSource;
        private qaDataSet3TableAdapters.w1TableAdapter w1TableAdapter;
    }
}