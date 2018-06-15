using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheButton
{
    public partial class catchMeForm : Form
    {
        public catchMeForm()
        {
            InitializeComponent();
        }

        private void buttonCatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidht = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
            this.buttonCatchMe.Location = new Point(rand.Next(maxWidht), rand.Next(maxHeight));
        }

        private void buttonCatchMe_MouseClick(object sender, MouseEventArgs e)
        {
            this.winBox.Visible = true;
            this.okButton.Visible = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.winBox.Visible = false;
            this.okButton.Visible = false;
        }
    }
}