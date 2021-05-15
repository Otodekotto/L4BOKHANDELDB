
namespace Lab3DatabaseWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.LabelBokTitel = new System.Windows.Forms.Label();
            this.textBoxButik = new System.Windows.Forms.TextBox();
            this.labelButikId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Språk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utgivningsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Författare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1177, 624);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(388, 624);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddRow);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxAdress);
            this.splitContainer2.Panel1.Controls.Add(this.LabelBokTitel);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxButik);
            this.splitContainer2.Panel1.Controls.Add(this.labelButikId);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(785, 624);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddRow.Location = new System.Drawing.Point(37, 190);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRow.TabIndex = 2;
            this.buttonAddRow.Text = "Add Book";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(28, 96);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(212, 23);
            this.textBoxAdress.TabIndex = 1;
            // 
            // LabelBokTitel
            // 
            this.LabelBokTitel.AutoSize = true;
            this.LabelBokTitel.Location = new System.Drawing.Point(28, 78);
            this.LabelBokTitel.Name = "LabelBokTitel";
            this.LabelBokTitel.Size = new System.Drawing.Size(42, 15);
            this.LabelBokTitel.TabIndex = 0;
            this.LabelBokTitel.Text = "Adress";
            // 
            // textBoxButik
            // 
            this.textBoxButik.Location = new System.Drawing.Point(28, 45);
            this.textBoxButik.Name = "textBoxButik";
            this.textBoxButik.Size = new System.Drawing.Size(212, 23);
            this.textBoxButik.TabIndex = 1;
            // 
            // labelButikId
            // 
            this.labelButikId.AutoSize = true;
            this.labelButikId.Location = new System.Drawing.Point(28, 27);
            this.labelButikId.Name = "labelButikId";
            this.labelButikId.Size = new System.Drawing.Size(34, 15);
            this.labelButikId.TabIndex = 0;
            this.labelButikId.Text = "Butik";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titel,
            this.ISBN,
            this.Språk,
            this.Pris,
            this.Utgivningsdatum,
            this.Författare,
            this.Antal});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Titel";
            this.Titel.Name = "Titel";
            this.Titel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Titel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Språk
            // 
            this.Språk.HeaderText = "Språk";
            this.Språk.Name = "Språk";
            this.Språk.ReadOnly = true;
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            this.Pris.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Utgivningsdatum
            // 
            this.Utgivningsdatum.HeaderText = "Utgivningsdatum";
            this.Utgivningsdatum.Name = "Utgivningsdatum";
            this.Utgivningsdatum.ReadOnly = true;
            this.Utgivningsdatum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Utgivningsdatum.Width = 130;
            // 
            // Författare
            // 
            this.Författare.HeaderText = "Författare";
            this.Författare.Name = "Författare";
            this.Författare.ReadOnly = true;
            this.Författare.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Antal
            // 
            this.Antal.HeaderText = "Antal";
            this.Antal.Name = "Antal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 624);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label LabelBokTitel;
        private System.Windows.Forms.TextBox textBoxButik;
        private System.Windows.Forms.Label labelButikId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.DataGridViewComboBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Språk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utgivningsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Författare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
    }
}


