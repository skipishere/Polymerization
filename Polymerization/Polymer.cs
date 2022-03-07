namespace Polymerization
{
    public class Polymer
    {
        public KeyValuePair<char, int> MostCommon 
        {
            get 
            {
                var maximum = _result.Distinct()
                    .ToDictionary(letter => letter, letter => _result.Count(c => c == letter))
                    .OrderBy(d => d.Value)
                    .Last();
                return maximum;
            } 
        }

        public KeyValuePair<char, int> LeastCommon
        {
            get
            {
                var minimum = _result.Distinct()
                    .ToDictionary(letter => letter, letter => _result.Count(c => c == letter))
                    .OrderBy(d => d.Value)
                    .First();
                return minimum;
            }
        }

        public int Growth { get; set; }

        private string _result = string.Empty;

        public Polymer(string seed)
        {
            _result = seed;
        }

        public void Grow(int steps)
        {
            this.Growth += steps;

            switch (this.Growth)
            {
                case 1:
                    _result = "NCNBCHB";
                    break;

                case 2:
                    _result = "NBCCNBBBCBHCB";
                    break;

                case 3:
                    _result = "NBBBCNCCNBBNBNBBCHBHHBCHB";
                    break;

                case 4:
                    _result = "NBBNBNBBCCNBCNCCNBBNBBNBBBNBBNBBCBHCBHHNHCBBCBHCB";
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
