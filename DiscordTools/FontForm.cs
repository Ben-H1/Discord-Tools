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
    public partial class FontForm : Form
    {
        public FontForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();
            Fonts fonts = new Fonts();

            switch (choiceComboBox.Text)
            {
                case "Maths Bold":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsBold);
                    break;
                case "Maths Double-struck":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsDoublestruck);
                    break;
                case "Maths Italic":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsItalic);
                    break;
                case "Maths Bold Italic":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsBoldItalic);
                    break;
                case "Maths Script":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsScript);
                    break;
                case "Maths Bold Script":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsBoldScript);
                    break;
                case "Maths Fraktur":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsFraktur);
                    break;
                case "Maths Bold Fraktur":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsBoldFraktur);
                    break;
                case "Maths Sans-serif":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsSansserif);
                    break;
                case "Maths Bold Sans-serif":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsBoldSansserif);
                    break;
                case "Maths Italic Sans-serif":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsItalicSansserif);
                    break;
                case "Maths Bold Italic Sans-serif":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsBoldItalicSansserif);
                    break;
                case "Maths Monospace":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.mathsMonospace);
                    break;
                case "Fullwidth":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.fullwidth);
                    break;
                case "Squared":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.squared);
                    break;
                case "Negative Squared":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.negativeSquared);
                    break;
                case "Circled":
                    convertedBox.Text = converter.convertToFont(originalBox.Text, fonts.circled);
                    break;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(convertedBox.Text);
        }
    }
}
// Fonts to add:
//
//      Consider adding numbers