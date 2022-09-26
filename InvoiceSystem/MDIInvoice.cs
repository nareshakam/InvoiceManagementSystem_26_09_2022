using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleTire;

namespace InvoiceSystem
{
    public partial class MDIInvoice : Form
    {
        private int childFormNumber = 0;

        private static bool isAdmin = false;

        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        public MDIInvoice()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();

            Form1 f1 = new Form1();
            f1.Show();
            f1.MdiParent = this;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            ScearchForm hpm = new ScearchForm();
            hpm.MdiParent = this;
            hpm.Show();

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void knowInvoiceNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                KnowingInvoiceNumber kni = new KnowingInvoiceNumber();
                kni.Show();
                kni.MdiParent = this;
            }
            else
            {
                MessageBox.Show("UnauthorizedAccess...! your not an Admin");
            }
        }

        private void deleteCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                DeleteCart dc = new DeleteCart();
                dc.Show();
                dc.MdiParent = this;
            }
            else
            {
                MessageBox.Show("UnauthorizedAccess...! your not an Admin");
            }
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void editCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCart ec = new EditCart();
            ec.Show();
            ec.MdiParent = this;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                UpDateCustmerDetails ucd = new UpDateCustmerDetails();
                ucd.Show();
                ucd.MdiParent = this;
            }
            else
            {
                MessageBox.Show("unauthorized ...!");
            }
        }

        private void MDIInvoice_Load(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Hide();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Singout = 1;
            this.Close();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KnowingInvoiceNumber kni = new KnowingInvoiceNumber();
            KnowingInvoiceNumber.Byway = "date";
            kni.Show();
            kni.MdiParent = this;
        }
    }
}
