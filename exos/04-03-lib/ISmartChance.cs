using System.Globalization;

namespace SmartChance;

public interface ISmartChance
{
    /// <summary>
    /// Gives a random int
    /// </summary>
    /// <returns>a randomm int</returns>
    int RandomInt();
    
    /// <summary>
    /// Gives a random int between min and max
    /// </summary>
    /// <param name="min">min value</param>
    /// <param name="max">max value</param>
    /// <returns>a number between min and max</returns>
    int RandomInt(int min, int max);
    
    /// <summary>
    ///  Gives a random float
    /// </summary>
    /// <returns>a random float</returns>
    float RandomFloat();
    
    /// <summary>
    /// Gives a random float between min and max
    /// </summary>
    /// <param name="min">min value</param>
    /// <param name="max">max value</param>
    /// <returns>a number between min and max</returns>
    float RandomFloat(float min, float max);
    
    /// <summary>
    /// Gives a random ASCII char
    /// </summary>
    /// <returns>a random ascii char</returns>
    char RandomChar();

    /// <summary>
    /// Gives a random char chosen from dictionary or null if all have been already used
    /// </summary>
    /// <param name="dictionary">list of available chars</param>
    /// <param name="withRepetition">same char can happen multiple times if true, false otherwise</param>
    /// <returns></returns>
    char RandomChar(string dictionary, bool withRepetition = false);
    
    /// <summary>
    /// Gives a random string
    /// </summary>
    /// <returns>a random string</returns>
    string RandomString();
    
    /// <summary>
    /// Gives a random word in given dictionary, null when all have been given and
    /// withRepetition is false
    /// </summary>
    /// <param name="dictionary">a set of words</param>
    /// <param name="withRepetition">if true, can give multiple times the same word</param>
    /// <returns></returns>
    string RandomWord(HashSet<string> dictionary,bool withRepetition=false);
    
    /// <summary>
    /// Generates a random valid date
    /// </summary>
    /// <returns>a valid date in the past, present or future</returns>
    DateTime RandomDate();
    
    /// <summary>
    /// Gives a random date after "after" argument and before "before" argument
    /// </summary>
    /// <param name="after">lower bound date</param>
    /// <param name="before">upper bound date</param>
    /// <returns></returns>
    DateTime RandomDate(DateTime after, DateTime before);
    
    /// <summary>
    /// Gives a random firstName for given local,
    /// for instance, with locale fr-CH it could be "xavier, aurelie, jonathan, ..."
    /// and with locale en-US it could be "sharon, luke, kevin, ..."
    /// </summary>
    /// <param name="locale">locale for</param>
    /// <returns>if existing, a random firstname of given locale, if not a random firstname in a random available locale</returns>
    String RandomFirstName(CultureInfo locale);
}

