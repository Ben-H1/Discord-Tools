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
    public partial class EmojiForm : Form
    {
        public EmojiForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();
            Sanitiser sanitiser = new Sanitiser();
            string textToConvert;

            textToConvert = sanitiser.alphaOnly(originalBox.Text);
            convertedBox.Text = converter.convertEachLetter(textToConvert.ToLower(), true, ":regional_indicator_", ": ");
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(convertedBox.Text);
        }
    }
}
