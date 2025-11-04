namespace Pig_Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEnglish.Text == "")
                {
                    MessageBox.Show("Please enter a word or phrase to translate.", "Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error\n\nStack Trace:{ex.StackTrace}");
                return;
            }

            String input = txtEnglish.Text;
            String[] words = input.Split(' ');
            String pigWord = "";
            String pigLatin = "";

            foreach (String i in words)
            {
                pigWord = "";
                String word = i;
                String punctuation = "";
                if (checkPunctuation(word))
                {
                    punctuation = word[^1].ToString();
                    word = word.Substring(0, word.Length - 1);
                }
                if (containsSymbol(word) || containsNumber(word))
                {
                    pigLatin += word + punctuation + " ";
                }
                else if (firstLetterVowel(word))
                {
                    pigWord += word + "way";
                    pigWord = formatWord(word, pigWord);
                    pigLatin += pigWord + punctuation + " ";
                }
                else
                {
                    foreach (char c in word)
                    {
                        if ("aeiouyAEIOUY".IndexOf(c) >= 0)
                        {
                            int index = word.IndexOf(c);
                            pigWord = word.Substring(index) + word.Substring(0, index) + "ay";
                            pigWord = formatWord(word, pigWord);
                            pigLatin += pigWord + punctuation + " ";
                            break;
                        }
                    }
                }
            }
            txtPigLatin.Text = pigLatin.Trim();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnglish.Clear();
            txtPigLatin.Clear();
            txtEnglish.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Boolean checkPunctuation(String word)
        {
            char lastCharacter = word[^1];
            if (lastCharacter == '.' || lastCharacter == ',' || lastCharacter == '!' || lastCharacter == '?' || lastCharacter == ';' || lastCharacter == ':')
            {
                return true;
            }
            return false;
        }
        private Boolean firstLetterVowel(String word)
        {
            char firstLetter = Char.ToLower(word[0]);

            // Check if the first letter is a vowel
            if ("aeiouAEIOU".IndexOf(firstLetter) >= 0)
            {
                return true;
            }
            return false;
        }
        private Boolean containsNumber(String word)
        {
            foreach (char c in word)
            {
                // Check if the character is a digit
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        private Boolean containsSymbol(String word)
        {
            foreach (char c in word)
            {
                // Check if the character is a symbol
                if (!char.IsLetterOrDigit(c) && c != '\'')
                {
                    return true;
                }
            }
            return false;
        }
        private String formatWord(String word, String pigWord)
        {
            if (word.All(char.IsUpper))
            {
                pigWord = pigWord.ToUpper();
                return pigWord;
            }
            else if (word[0] == char.ToUpper(word[0]))
            {
                pigWord = pigWord.ToLower();
                pigWord = char.ToUpper(pigWord[0]) + pigWord.Substring(1);
                return pigWord;
            }

            return pigWord;
        }
    }
}
