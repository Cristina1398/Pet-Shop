namespace DogShop
{
    partial class BazaDeDate
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
            this.rasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.culoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.greutatekgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inaltimecmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaluniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new DogShop.Database1DataSet();
            this.c1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1TableAdapter = new DogShop.Database1DataSetTableAdapters.C1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rasaDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.origineDataGridViewTextBoxColumn,
            this.culoareDataGridViewTextBoxColumn,
            this.greutatekgDataGridViewTextBoxColumn,
            this.inaltimecmDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.varstaluniDataGridViewTextBoxColumn,
            this.imagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.c1BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // rasaDataGridViewTextBoxColumn
            // 
            this.rasaDataGridViewTextBoxColumn.DataPropertyName = "Rasa";
            this.rasaDataGridViewTextBoxColumn.HeaderText = "Rasa";
            this.rasaDataGridViewTextBoxColumn.Name = "rasaDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // origineDataGridViewTextBoxColumn
            // 
            this.origineDataGridViewTextBoxColumn.DataPropertyName = "Origine";
            this.origineDataGridViewTextBoxColumn.HeaderText = "Origine";
            this.origineDataGridViewTextBoxColumn.Name = "origineDataGridViewTextBoxColumn";
            // 
            // culoareDataGridViewTextBoxColumn
            // 
            this.culoareDataGridViewTextBoxColumn.DataPropertyName = "Culoare";
            this.culoareDataGridViewTextBoxColumn.HeaderText = "Culoare";
            this.culoareDataGridViewTextBoxColumn.Name = "culoareDataGridViewTextBoxColumn";
            // 
            // greutatekgDataGridViewTextBoxColumn
            // 
            this.greutatekgDataGridViewTextBoxColumn.DataPropertyName = "Greutate(kg)";
            this.greutatekgDataGridViewTextBoxColumn.HeaderText = "Greutate(kg)";
            this.greutatekgDataGridViewTextBoxColumn.Name = "greutatekgDataGridViewTextBoxColumn";
            // 
            // inaltimecmDataGridViewTextBoxColumn
            // 
            this.inaltimecmDataGridViewTextBoxColumn.DataPropertyName = "Inaltime(cm)";
            this.inaltimecmDataGridViewTextBoxColumn.HeaderText = "Inaltime(cm)";
            this.inaltimecmDataGridViewTextBoxColumn.Name = "inaltimecmDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // varstaluniDataGridViewTextBoxColumn
            // 
            this.varstaluniDataGridViewTextBoxColumn.DataPropertyName = "Varsta(luni)";
            this.varstaluniDataGridViewTextBoxColumn.HeaderText = "Varsta(luni)";
            this.varstaluniDataGridViewTextBoxColumn.Name = "varstaluniDataGridViewTextBoxColumn";
            // 
            // imagineDataGridViewTextBoxColumn
            // 
            this.imagineDataGridViewTextBoxColumn.DataPropertyName = "Imagine";
            this.imagineDataGridViewTextBoxColumn.HeaderText = "Imagine";
            this.imagineDataGridViewTextBoxColumn.Name = "imagineDataGridViewTextBoxColumn";
            // 
            // c1BindingSource1
            // 
            this.c1BindingSource1.DataMember = "C1";
            this.c1BindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1BindingSource
            // 
            this.c1BindingSource.DataMember = "C1";
            this.c1BindingSource.DataSource = this.database1DataSet;
            // 
            // c1TableAdapter
            // 
            this.c1TableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 402);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare câini";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource c1BindingSource;
        private System.Windows.Forms.BindingSource c1BindingSource1;
        private Database1DataSetTableAdapters.C1TableAdapter c1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn culoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn greutatekgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inaltimecmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaluniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagineDataGridViewTextBoxColumn;
    }
}