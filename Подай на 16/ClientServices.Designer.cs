
namespace Подай_на_16
{
    partial class Услуги_гость_
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Выход = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // Выход
            // 
            this.Выход.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Выход.Location = new System.Drawing.Point(255, 229);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(117, 33);
            this.Выход.TabIndex = 1;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = false;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // Услуги_гость_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 274);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Услуги_гость_";
            this.Text = "Услуги_гость_";
            this.Load += new System.EventHandler(this.Услуги_гость__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Выход;
    }
}