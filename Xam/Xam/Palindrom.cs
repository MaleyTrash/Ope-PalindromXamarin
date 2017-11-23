using System.Text;
using System.Globalization;
using Xamarin.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace Xam
{
    public partial class Palindrom
    {
        private Label _display;

        private SpecialChar[] _charList = new SpecialChar[]
        {
            new SpecialChar('ř','r'),
            new SpecialChar('ě','e'),
            new SpecialChar('š','s'),
            new SpecialChar('č','c'),
            new SpecialChar('ž','z'),
            new SpecialChar('ý','y'),
            new SpecialChar('á','a'),
            new SpecialChar('í','i'),
            new SpecialChar('é','e'),
            new SpecialChar('ď','d'),
            new SpecialChar('ť','t'),
            new SpecialChar('ú','u'),
            new SpecialChar('ů','u')
        };

        public Palindrom(Entry entry, Label displayLabel)
        {
            entry.TextChanged += OnTextChanged;
            _display = displayLabel;
        }

        private bool IsPalindrom(string input)
        {
            input = input.ToLower();
            foreach(SpecialChar item in _charList)
            {
                input = item.RemoveCharacter(input);
            }
            Regex.Replace(input,@"\W", "");
            MatchCollection col = Regex.Matches(input, "(ch|[a-z])");
            string clean = "";
            string reverse = "";
            foreach(Match item in col)
            {
                clean += item.Value;
            }
            for(int i = col.Count-1; i >= 0; i--)
            {
                reverse += col[i].Value;
            }

            if (clean.Equals(reverse)) return true;
            else return false;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            _display.Text = IsPalindrom(e.NewTextValue).ToString();
        }
    }
}
