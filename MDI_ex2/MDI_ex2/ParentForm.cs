﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ParentForm : Form
    {
        private int openDocument = 0;
        public ParentForm()
        {
            InitializeComponent();
            spData.Text =
            Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void FileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + "" + ++openDocument;
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void toolStrip1_ItemClicked(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
                {
                    case "NewDoc":
                        ChildForm newChild = new ChildForm();
                        newChild.MdiParent = this;
                        newChild.Show();
                        newChild.Text = newChild.Text + " " +
                        ++openDocument;
                    break;
                    case "Cascade":
                        this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                    case "Title":
                        this.LayoutMdi
                        (System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void spWin_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
            spWin.Text = "Windows is horizontal";
        }
    }
}
