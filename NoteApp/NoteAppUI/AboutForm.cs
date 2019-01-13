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

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        private const string REPOSITORY_LINK = "https://github.com/ZakharovVasily";

        public AboutForm()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(REPOSITORY_LINK);
        }
    }
}
