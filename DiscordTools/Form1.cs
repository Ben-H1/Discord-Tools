using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void emojiButton_Click(object sender, EventArgs e)
        {
            EmojiForm emojiForm = new EmojiForm();
            emojiForm.Show();
        }

        private void spoilerButton_Click(object sender, EventArgs e)
        {
            SpoilerForm spoilerForm = new SpoilerForm();
            spoilerForm.Show();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontForm fontForm = new FontForm();
            fontForm.Show();
        }
    }
}
