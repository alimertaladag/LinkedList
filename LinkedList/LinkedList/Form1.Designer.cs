namespace LinkedListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.NumericUpDown numIndex;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(150, 85);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 30);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(150, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(150, 50);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(120, 20);
            this.txtData.TabIndex = 4;
            // 
            // numIndex
            // 
            this.numIndex.Location = new System.Drawing.Point(150, 170);
            this.numIndex.Name = "numIndex";
            this.numIndex.Size = new System.Drawing.Size(120, 20);
            this.numIndex.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.numIndex);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "LinkedList Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
