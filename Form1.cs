using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Lab3DatabaseWinform.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3DatabaseWinform
{
    public partial class Form1 : Form
    {
        private List<Böcker> böcker;
        private readonly BokhandelContext db;
        private Butiker activeButik = null;
        private bool isNewBook = false;

        public Form1()
        {
            InitializeComponent();
            db = new BokhandelContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.Database.CanConnect())
            {
                böcker = db.Böckers.ToList();

                var butiker = db.Butikers
                    .Include(l => l.LagerSaldos)
                    .ThenInclude(i => i.Isbn13)
                    .ThenInclude(f => f.Författare)
                    .ToList();

                foreach (Butiker butik in butiker)
                {
                    TreeNode butikNode = new TreeNode()
                    {
                        Text = $"{butik.ButiksNamn}",
                        Tag = butik

                    };
                    treeView1.Nodes.Add(butikNode);
                }
            }
            else Debug.WriteLine("Conncetion failed!");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Butiker butik)
            {
                activeButik = butik;

                textBoxButik.Text = butik.ButiksNamn;
                textBoxAdress.Text = butik.Adress;

                dataGridView1.Rows.Clear();
                foreach (LagerSaldo lagersaldo in butik.LagerSaldos)
                {


                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Tag = lagersaldo;

                    var comboBoxCell = dataGridView1.Rows[rowIndex].Cells["Titel"] as DataGridViewComboBoxCell;
                    comboBoxCell.ValueType = typeof(Böcker);
                    comboBoxCell.DisplayMember = "Titel";
                    comboBoxCell.ValueMember = "This";
                    foreach (Böcker böcker in böcker)
                    {
                        comboBoxCell.Items.Add(böcker);
                    }

                    dataGridView1.Rows[rowIndex].Cells["Titel"].Value = lagersaldo.Isbn13;
                    dataGridView1.Rows[rowIndex].Cells["ISBN"].Value = lagersaldo.Isbn13.Isbn13;
                    dataGridView1.Rows[rowIndex].Cells["Språk"].Value = lagersaldo.Isbn13.Språk;
                    dataGridView1.Rows[rowIndex].Cells["Pris"].Value = lagersaldo.Isbn13.Pris + " kr";
                    dataGridView1.Rows[rowIndex].Cells["Utgivningsdatum"].Value = lagersaldo.Isbn13.Utgivningsdatum;
                    dataGridView1.Rows[rowIndex].Cells["Författare"].Value = lagersaldo.Isbn13.Författare.Förnamn + " " + lagersaldo.Isbn13.Författare.Efternamn;
                    isNewBook = false;
                    dataGridView1.Rows[rowIndex].Cells["Antal"].Value = lagersaldo.Antal;
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeButik != null)
            {

                int rowIndex = dataGridView1.Rows.Add();
                var comboBoxCell = dataGridView1.Rows[rowIndex].Cells["Titel"] as DataGridViewComboBoxCell;
                comboBoxCell.ValueType = typeof(Böcker);
                comboBoxCell.DisplayMember = "Titel";
                comboBoxCell.ValueMember = "This";
                foreach (var item in böcker)
                {
                    comboBoxCell.Items.Add(item);
                }
                isNewBook = true;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.ColumnIndex == 0)
            {
                var bok = dataGridView1.Rows[e.RowIndex].Cells[0].Value as Böcker;

                dataGridView1.Rows[e.RowIndex].Cells[1].Value = bok.Isbn13;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = bok.Språk;
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = bok.Pris + " kr";
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = bok.Utgivningsdatum;
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = bok.Författare.Förnamn + " " + bok.Författare.Efternamn;

            }
            else if (e.ColumnIndex == 6)
            {
                int antal;

                Int32.TryParse(cell.Value.ToString(), out antal);

                var lager = dataGridView1.Rows[e.RowIndex].Tag as LagerSaldo;
                if (lager != null)
                {
                    lager.Antal = antal;              
                }

                if (isNewBook)
                {
                    var book = dataGridView1.Rows[e.RowIndex].Cells[0].Value as Böcker;

                    db.Database.ExecuteSqlInterpolated($"Insert into LagerSaldo (Isbn13id, ButiksId, Antal) values( {book.Isbn13},{activeButik.Id}, {antal})");
                    MessageBox.Show("Data saved");

                    treeView1.Nodes.Clear();

                    böcker = db.Böckers.ToList();

                    var butiker = db.Butikers
                        .Include(l => l.LagerSaldos)
                        .ThenInclude(i => i.Isbn13)
                        .ThenInclude(f => f.Författare)
                        .ToList();

                    foreach (Butiker butik in butiker)
                    {
                        TreeNode butikNode = new TreeNode()
                        {
                            Text = $"{butik.ButiksNamn}",
                            Tag = butik

                        };
                        treeView1.Nodes.Add(butikNode);
                    }
                }
                
            }

        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var result = MessageBox.Show("Do you want to delete this row?", "Delete row", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);

                        db.LagerSaldos.RemoveRange(db.LagerSaldos.Single(b => b.Isbn13id == item.Cells[1].Value.ToString() && b.ButiksId == activeButik.Id));
                        db.SaveChanges();

                    }
                }

            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }
    }
}
