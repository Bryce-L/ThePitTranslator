using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const char escapeCharacter = '"';

        private Dictionary<string, string> translationDictionary = new Dictionary<string, string>
        {
            { " ", " "},
            { ",", ","},
            { ".", "."},
            { ":", ":"},
            { "-", "-"},
            
            { "AE", "EE"},
            { "AUM", "OO"},
            { "IU", "EA"},
            { "EO", "OU"},
            { "KH", "[CH|P]"},
            { "RT", "TH"},
            { "TH", "SH"},

            { "AA", "E"},
            { "AC", "Z"},
            { "AU", "O"},
            { "DE", "G"},
            { "EH", "I"},
            //{ "F", "F"},
            { "G", "B"},
            //{ "H", "H"},
            { "HM", "[D|M]"},
            //{ "K", "K"},
            //{ "HM", "M"},
            //{ "KH", "P"},
            { "KR", "J"},
            { "MOKH", "W"},
            { "NG", "L"},
            { "NH", "N"},
            { "OI", "Y"},
            { "OW", "A"},
            { "PR", "C"},
            { "Q", "Q"},
            { "ROR", "U"},
            { "RRR", "R"},
            { "SH", "S"},
            { "VH", "V"},
            { "WR", "T"},
            //{ "X", "X"},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string text = this.inputRichTextBox.Text;
            this.outputTextBox.Text = Algorithm3(text);
        }

        /// <summary>           
        /// Given a string, do the last X character(s) match a key
        ///     Yes - Replace the longest match, mark the unmatched characters with brackets, and recusively call the method passing it the next character
        ///     No - Recursively call the method passing it the current string plus the next character.
        private string Algorithm3(string text)
        {
            StringBuilder result = new StringBuilder();
            string current = String.Empty;
            for (int x = 0; x < text.Length; x++)
            {
                current += text[x];

                // Check for words that I want to provide by wrapping in brackets.
                if (current.StartsWith(escapeCharacter.ToString()))
                {
                    if (current.Length > 1 && current.EndsWith(escapeCharacter.ToString()))
                    {
                        result.Append(current.TrimStart(escapeCharacter).TrimEnd(escapeCharacter));
                        current = String.Empty;
                    }
                    continue;
                }

                string matchingKey = null;
                for (int y = current.Length - 1; y >= 0; y--)
                {
                    string potentialKey = current.Substring(y, current.Length - y);
                    if (translationDictionary.ContainsKey(potentialKey))
                    {
                        matchingKey = potentialKey;
                    }
                }
                if (matchingKey != null)
                {
                    if (matchingKey.Length != current.Length)
                    {
                        string unmatchedSubString = current.Substring(0, current.Length - matchingKey.Length);
                        if (unmatchedSubString == "F" || unmatchedSubString == "H" || unmatchedSubString == "K" || unmatchedSubString == "X")
                        {
                            result.Append(unmatchedSubString);
                        }
                        else
                        {
                            result.AppendFormat("[{0}]", unmatchedSubString);
                        }
                    }
                    result.Append(translationDictionary[matchingKey]);

                    current = String.Empty;
                    matchingKey = null;
                }
            }

            return result.ToString();
        }
    }
}
