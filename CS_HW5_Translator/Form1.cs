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

        private const string PigLatin = "PigLatin";
        private const string PigGreek = "PigGreek";
        private const string EmptyString = "";

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            var Translator = new Translator();

            if (!ToTranslateRTB.Text.Equals(EmptyString))
            {
                if (PigLatinRB.Checked)
                {
                    TranslatedRTB.Text = Translator.Translate(ToTranslateRTB.Text, PigLatin);
                }
                else if (PigGreekRB.Checked)
                {
                    TranslatedRTB.Text = Translator.Translate(ToTranslateRTB.Text, PigGreek);
                }
                else
                {
                    MessageBox.Show("Please select either Pig Latin or Pig Greek.");
                }
            }
            else
            {
                MessageBox.Show("Please enter some text to translate.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ToTranslateRTB.Clear();
            TranslatedRTB.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}