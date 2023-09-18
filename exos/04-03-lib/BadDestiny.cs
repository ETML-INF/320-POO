using SmartChance;
using System.Globalization;


namespace SmartChanceImpl1
{
    internal class BadDestiny : ISmartChance
    {
        public char RandomChar()
        {
            return 'a';
        }

        public char RandomChar(string dictionary, bool withRepetition = false)
        {
            return dictionary[0];
        }

        public DateTime RandomDate()
        {
            return DateTime.Now;
        }

        public DateTime RandomDate(DateTime after, DateTime before)
        {
            return after.AddDays(1);
        }

        public string RandomFirstName(CultureInfo locale)
        {
            return "bob";
        }

        public float RandomFloat()
        {
            return 1.04f;
        }

        public float RandomFloat(float min, float max)
        {
            return min + 0.001f;
        }

        public int RandomInt()
        {
            return 1;
        }

        public int RandomInt(int min, int max)
        {
            return min + 1;
        }

        public string RandomString()
        {
            return "bobs";
        }

        public string RandomWord(HashSet<string> dictionary, bool withRepetition = false)
        {
            return "bobw";
        }
    }
}
