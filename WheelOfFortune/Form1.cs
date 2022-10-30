using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public partial class WheelOfFortuneForm : Form
    {
        #region Constants
        private const string BuyVowelText = "$250 to buy a vowel";
        private const string SolvePuzzleText = "Solve the Puzzle!";
        private const string FullAlphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
        private const string StartingConsonants = "B C D F G H J K L M N P Q R S T V W X Y Z";
        private const string StartingVowels = "A E I O U";
        private const int VowelCost = 250;
        

        

        private readonly List<int> _wheelSlices = new List<int>
        {
            5000, 600, 500, 300, 525, 800, 550, 400, 325, 900, 350, 950, 575, 0, 450,
            650, 380, -1, 850, 375, 475, 700, 275, 675
        };

        private readonly List<Color> _wheelColors = new List<Color>
        {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Indigo,
            Color.Chartreuse,
            Color.Fuchsia,
            Color.DarkOrange
        };

        private readonly List<Dictionary<string, string>> _puzzleToSolveText = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> {{"Convince", "To persuade somebody to believe or do something"}}, new Dictionary<string, string> {{"Urge", "To advise somebody strongly to do something"}}, new Dictionary<string, string> {{"Preach", "To give a talk on a religious or moral subject, or to give advice on morality or behavior in an overbearing way"}}, new Dictionary<string, string> {{"Steer", "To go or move in a particular direction when being driven or propelled, or to influence somebody in a particular direction"}}, new Dictionary<string, string> {{"Awkward", "Embarrassing, or difficult to use because requiring body to move in an uncomfortable position"}}, new Dictionary<string, string> {{"Clumsy", "Movement or action done without skill or grace"}}
        };
        #endregion

        #region Private Variables
        private int _playerMoney;
        private string _answerText;
        private StringBuilder _emptyAnswer = new StringBuilder();
        private string _consonantBuilder = "B C D F G H J K L M N P Q R S T V W X Y Z";
        private string _vowelBuilder = "A E I O U";
        private int _wheelSelectedAmount;
        private readonly ErrorProvider _errorProvider = new ErrorProvider();
        #endregion

        public WheelOfFortuneForm()
        {
            InitializeComponent();
            var puzzleAnswerText = _puzzleToSolveText[GetRandomNumber(_puzzleToSolveText.Count)];
            categoryLabel.Text = puzzleAnswerText.ElementAtOrDefault(0).Value;
            _answerText = puzzleAnswerText.ElementAtOrDefault(0).Key.ToUpper();
            UpdateFortuneAnswer();
        }

        private void ResetFields()
        {
            var puzzleAnswerText = _puzzleToSolveText[GetRandomNumber(_puzzleToSolveText.Count)];
            categoryLabel.Text = puzzleAnswerText.ElementAtOrDefault(0).Value;
            _answerText = puzzleAnswerText.ElementAtOrDefault(0).Key.ToUpper();
            UpdateFortuneAnswer();
        }

        /// <summary>
        /// Gets a random number between 0 and 1 - max number
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        private int GetRandomNumber(int maxNumber)
        {
            var randomNumber = new Random();
            return randomNumber.Next(0, maxNumber);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateText()
        {
            bool isValid = true;
            string selectedLetter = answerEntryTextBox.Text.ToUpper().Trim();

            if (string.IsNullOrWhiteSpace(selectedLetter))
            {
                isValid = false;
                _errorProvider.SetError(enterButton, "Answer cannot be blank.");
            }
            else if (buyVowelRadio.Checked && _playerMoney < 250)
            {
                isValid = false;
                _errorProvider.SetError(solvePuzzleRadio, "You do not have enough money to buy a vowel.");
            }
            else if (buyVowelRadio.Checked && !StringUtilities.IsVowel(selectedLetter))
            {
                isValid = false;
                _errorProvider.SetError(solvePuzzleRadio, "Must select a vowel.");
            }
            else if (spinRadio.Checked && StringUtilities.IsVowel(selectedLetter))
            {
                isValid = false;
                _errorProvider.SetError(solvePuzzleRadio, "Cannot select a vowel when spinning");
            }

            if (!spinRadio.Checked && !buyVowelRadio.Checked && !solvePuzzleRadio.Checked)
            {
                isValid = false;
                _errorProvider.SetError(solvePuzzleRadio, "Must select an action.");
            }

            if (buyVowelRadio.Checked && !_vowelBuilder.Contains(selectedLetter))
            {
                isValid = false;
                _errorProvider.SetError(enterButton, "Vowel has already been chosen.");
            }

            if (spinRadio.Checked && !_consonantBuilder.Contains(selectedLetter))
            {
                isValid = false;
                _errorProvider.SetError(enterButton, "Letter has already been picked.");
            }

            return isValid;
        }

        private int UpdateFortuneAnswer(bool isSolving = false, string answer = "")
        {
            var tempString = _answerText.Trim();
            var updatedAnswer = new StringBuilder();
            int letterRepetition = 0;

            if (!isSolving && string.IsNullOrWhiteSpace(answer))
            {
                foreach (var t in tempString)
                {
                    updatedAnswer.Append(t.ToString(CultureInfo.InvariantCulture) != " " ? "-" : " ");
                }

                lettersLabel.Text = FullAlphabet;
                _consonantBuilder = StartingConsonants;
                _vowelBuilder = StartingVowels;
                _emptyAnswer = updatedAnswer;
            }
            else if (!isSolving &&  !string.IsNullOrWhiteSpace(answer))
            {
                for (var i = 0; i < _answerText.Length; i++)
                {
                    if (_answerText[i] == char.Parse(answer))
                    {
                        _emptyAnswer = _emptyAnswer.Replace("-", answer, i, 1);
                        letterRepetition++;
                    }
                }
            }
            else if (isSolving)
            {
                if (answer == _answerText)
                {
                    answerEntryTextBox.Text = _answerText.ToUpper();
                    MessageBox.Show("Congratulations! You've solved the puzzle. See if you can solve the next one.",
                        "Wheel Of Fortune", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Sorry, that is not the correct answer. Keep trying.",
                        "Wheel Of Fortune", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            puzzleText.Text = _emptyAnswer.ToString();
            return letterRepetition;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                string answertText = answerEntryTextBox.Text.ToUpper().Trim();
                if (spinRadio.Checked)
                {
                    var multiplier = UpdateFortuneAnswer(false, answertText);
                    _consonantBuilder = StringUtilities.RemoveSubStringFromString(answertText, _consonantBuilder);
                    lettersLabel.Text = _consonantBuilder;
                    _playerMoney += multiplier * _wheelSelectedAmount;
                }
                else if (buyVowelRadio.Checked)
                {
                    UpdateFortuneAnswer(false, answertText);
                    _vowelBuilder = StringUtilities.RemoveSubStringFromString(answertText, _vowelBuilder);
                    lettersLabel.Text = _vowelBuilder;
                    _playerMoney -= VowelCost;
                }
                else if (solvePuzzleRadio.Checked)
                {
                    UpdateFortuneAnswer(true, answertText);
                }

                playerMoneyLabel.Text = _playerMoney.ToString("C0");
                ClearFields();
            } 
        }

        private void ClearFields()
        {
            
            spinRadio.Checked = false;
            buyVowelRadio.Checked = false;
            solvePuzzleRadio.Checked = false;
            answerEntryTextBox.Text = string.Empty;
            answerEntryTextBox.ReadOnly = true;
        }

        private void SpinWheel()
        {
            var selectedMoney = _wheelSlices[GetRandomNumber(_wheelSlices.Count)];
            string wheelText;
            Color backgroundColor;
            if (selectedMoney < 1)
            {
                backgroundColor = Color.Black;
                wheelText = "Bankrupt";
            }
            else
            {
                backgroundColor = _wheelColors[GetRandomNumber(_wheelColors.Count)];
                wheelText = selectedMoney.ToString("C0");
            }

            _wheelSelectedAmount = selectedMoney;
            wheelTextBox.BackColor = backgroundColor;
            wheelTextBox.Text = wheelText;
            wheelTextBox.ForeColor = Color.FloralWhite;
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            _errorProvider.SetError(enterButton, string.Empty);
        }

        private void OnCheckedChange(object sender, EventArgs e)
        {
            if (spinRadio.Checked)
            {
                lettersLabel.Text = _consonantBuilder;
                SpinWheel();
                if (_wheelSelectedAmount < 1)
                {
                    answerEntryTextBox.ReadOnly = true;
                    spinRadio.Checked = false;
                    playerMoneyLabel.Text = 0.ToString("C0");
                }

                answerEntryTextBox.MaxLength = 1;
            }
            else if (buyVowelRadio.Checked)
            {
                lettersLabel.Text = _vowelBuilder;
                wheelTextBox.Text = BuyVowelText;
                answerEntryTextBox.MaxLength = 1;
            }
            else if (solvePuzzleRadio.Checked)
            {
                wheelTextBox.Text = SolvePuzzleText;
                answerEntryTextBox.MaxLength = 1000;
            }

            answerEntryTextBox.ReadOnly = false;

            _errorProvider.SetError(solvePuzzleRadio, string.Empty);
        }
    }
}
