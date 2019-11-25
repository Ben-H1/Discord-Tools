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
    public partial class SpoilerForm : Form
    {
        public SpoilerForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();

            switch (choiceComboBox.Text)
            {
                case "each letter":
                    convertedBox.Text = converter.convertEachLetter(originalBox.Text, false, "||", "||");
                    break;

                case "each word":
                    convertedBox.Text = converter.convertEachWord(originalBox.Text, "||", "||");
                    break;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(convertedBox.Text);
        }
    }
}
