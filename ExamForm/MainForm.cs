using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Hints
// Extra marks are awarded for demonstrating extra skills and knowledge
// Stringbuilder, Tasks, LINQ, etc. though not required
//
// If you've got extra time, fix the resizing issue however you see fit
//
// Code clarity is paramount, messy code is frowned upon
//
// That hint label has an interesting name
#endregion

namespace ExamForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            OutputRTB.Text = "Nothing happened...";
        }
    }
}
