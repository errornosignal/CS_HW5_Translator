
using System;
using System.Windows.Forms;

namespace CS_HW5_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private Translator Translator = new Translator();
        private const string Language1 = Translator.Language1;
        private const string Language2 = Translator.Language2;
        private const string EmptyString = "";

        /// <summary>
        /// Sets initial form state on load.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            var Form1 = new Form1
            {
                Text = Language1 + " " + Language2 + " Translator"
            };
            this.ToTranslateLabel.Text = "Enter English Text Here:";
            this.TranslationLabel.Text = "Translation:";
            this.Language1RB.Text = Language1;
            this.Language2RB.Text = Language2;
            this.TranslatedRTB.ReadOnly = true;
        }

        /// <summary>
        /// Handles TranslateButton_Click event.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TranslateButton_Click(object sender, EventArgs e)
        {
            if (!ToTranslateRTB.Text.Equals(EmptyString))
            {
                if (Language1RB.Checked)
                {
                    this.TranslationLabel.Text = Language1 + " Translation:";
                    this.TranslatedRTB.Text = Translator.Translate(ToTranslateRTB.Text, Language1);
                }
                else if (Language2RB.Checked)
                {
                    this.TranslationLabel.Text = Language2 + " Translation:";
                    this.TranslatedRTB.Text = Translator.Translate(ToTranslateRTB.Text, Language2);
                }
                else
                {
                    MessageBox.Show("Select either " + Language1 + " or " + Language2);
                }
            }
            else
            {
                MessageBox.Show("Enter some text to translate.");
            }
        }

        /// <summary>
        /// Handles ClearButton_Click event.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ToTranslateRTB.Clear();
            this.TranslatedRTB.Clear();
        }

        /// <summary>
        /// Handles ExitButton_Click event.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}