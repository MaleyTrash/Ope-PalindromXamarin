namespace Xam
{
    public partial class Palindrom
    {
        private class SpecialChar
        {
            char _special;
            char _normalizied;

            public SpecialChar(char special, char normal)
            {
                _special = special;
                _normalizied = normal;
            }

            public string RemoveCharacter(string input)
            {
                return input.Replace(_special, _normalizied);
            }
        }
    }
}
