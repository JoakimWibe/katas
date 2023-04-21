using System.Text.RegularExpressions;

namespace Katas;

public class Katas
{

    public static int ClosestEnemy(int[] arr)
    {

        if (!arr.Any(n => n == 2))
        {
            return 0;
        }

        var indexOf1 = Array.IndexOf(arr, 1);

        var indexesOf2 = arr
            .Select((number, index) => new { number, index })
            .Where(obj => obj.number == 2)
            .Select(obj => obj.index)
            .ToList();

        return indexesOf2.Select(i => Math.Abs(i - indexOf1)).Min();
    }

    public int NumberOfOccurrences(int x, int[] xs)
    {
        return xs.Count(num => num == x);
    }

    public string Covfefe(string tweet)
    {
        if (!tweet.Contains("coverage"))
        {
            return tweet + " covfefe";
        }

        var wordArray = tweet.Split(" ").Select(word => word.Replace("coverage", "covfefe"));

        return String.Join(" ", wordArray);
    }

    public int SumOfIntegersInString(string s)
    {
        var extractedNumbers = Regex.Matches(s, "[0-9]+").Select(character => character.Value).ToArray();

        return Array.ConvertAll(extractedNumbers, int.Parse).Sum();
    }

    public int ConsonantCount(string str)
    {
        var characters = str.ToLower().ToCharArray().ToList();

        return characters.Count(c => c.Equals('b') || c.Equals('c') || c.Equals('d') || c.Equals('f') || c.Equals('g') || c.Equals('h') || c.Equals('j') || c.Equals('k') || c.Equals('l') || c.Equals('m') || c.Equals('n') || c.Equals('p') || c.Equals('q') || c.Equals('r') || c.Equals('s') || c.Equals('t') || c.Equals('v') || c.Equals('w') || c.Equals('x') || c.Equals('y') || c.Equals('z'));
    }

    public int GetVowelCount(string str)
    {
        var characters = str.ToCharArray().ToList();

        return characters.Count(character => character.Equals('a') || character.Equals('e') || character.Equals('i') || character.Equals('o') || character.Equals('u'));
    }

    public string HighAndLow(string numbers)
    {
        var stringArray = numbers.Split(" ");
        var intArray = Array.ConvertAll(stringArray, int.Parse);

        return $"{intArray.Max()} {intArray.Min()}";
    }

    public int DescendingOrder(int num)
    {
        return Convert.ToInt32(String.Concat(num.ToString().OrderByDescending(x => x)));
    }

    public string GetMiddle(string s)
    {
        var charArray = s.ToCharArray();

        return charArray.Length % 2 != 0 ? $"{charArray[charArray.Length / 2]}" : $"{charArray[charArray.Length / 2 - 1]}{charArray[charArray.Length / 2]}";
    }

    public string Disemvowel(string str)
    {
        string vowels = "aeiouAEIOU";

        return new string(str.Where(c => !vowels.Contains(c)).ToArray());
    }

    public int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(item => item);
    }

    public int Summation(int num)
    {
        return num * (num + 1) / 2;
    }

    public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems.Where(item => item is int).ToList().OfType<int>();
    }

    public long[] Digitize(long n)
    {
        var array = n.ToString().Select(digit => int.Parse(digit.ToString())).Reverse().ToArray();

        return array.Select(item => (long)item).ToArray();
    }

    public int sumTwoSmallestNumbers(int[] numbers)
    {
        var numbersList = numbers.ToList();
        var smallest = numbersList.Min();
        numbersList.Remove(smallest);
        var secondSmallest = numbersList.Min();

        return smallest + secondSmallest;
    }

    public bool XO(string input)
    {
        var charArray = input.ToLower().ToCharArray().ToList();

        return charArray.Count(c => c == 'x') == charArray.Count(c => c == 'o');
    }

    public int FindShort(string s)
    {
        var stringArray = s.Split(" ");

        return stringArray.Min(word => word.Length);
    }

    public int Sum(int[] numbers)
    {
        if (numbers.Length < 3)
        {
            return 0;
        }

        var numbersList = numbers.ToList();
        var smallest = numbersList.Min();
        var largest = numbersList.Max();
        numbersList.Remove(smallest);
        numbersList.Remove(largest);

        return numbersList.Sum();
    }

    public int FindOddApperance(int[] seq)
    {
        return seq
            .GroupBy(num => num)
            .Where(group => group.Count() % 2 != 0)
            .Select(group => group.Key)
            .Single();
    }

    public string CodelandUsernameValidation(string str)
    {
        if (str.Length > 25 || str.Length < 4 || string.IsNullOrEmpty(str) && !char.IsLetter(str[0]) || !str.All(c => char.IsLetterOrDigit(c) || c.Equals('_')) || str[str.Length - 1] == '_')
        {
            return "false";
        }

        return "true";
    }

    public string FindIntersection(string[] strArr)
    {
        var firstList = strArr[0].Split(", ");
        var secondList = strArr[1].Split(", ");

        var intersectionList = firstList.Where(c => secondList.Contains(c)).Select(c => c.ToString());

        return String.Join(",", intersectionList);
    }

    public string QuestionsMarks(string str)
    {
        var result = "false";
        var counter = 0;
        var previousDigit = 'a';
        var currentDigit = 'a';
        foreach (var digit in str)
        {
            if (digit == '?')
            {
                counter++;
            }

            if (!char.IsDigit(digit)) continue;
            if (previousDigit == 'a')
            {
                previousDigit = digit;
            }
            else if (currentDigit == 'a')
            {
                currentDigit = digit;
                if ((int)char.GetNumericValue(previousDigit) + (int)char.GetNumericValue(currentDigit) == 10 && counter == 3)
                {
                    result = "true";
                    previousDigit = currentDigit;
                    currentDigit = 'a';
                }
                else if ((int)char.GetNumericValue(previousDigit) + (int)char.GetNumericValue(currentDigit) == 10 && counter != 3)
                {
                    return "false";
                }

            }
            counter = 0;
        }

        return result;
    }

    public string FirstReverse(string str)
    {
        var reverse = str.Reverse();

        return string.Join("", reverse);
    }

    public int FirstFactorial(int num)
    {
        return Enumerable.Range(1, num).Aggregate(1, (p, item) => p * item);
    }

    public string LongestWord(string sen)
    {
        var senArray = sen.Split(" ");
        var trimmedArray = senArray.Select(character => character.Trim(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '?', '.', ',', '&' }));
        return trimmedArray.OrderByDescending(str => str.Length).First();
    }

    public int LargestFour(int[] arr)
    {
        if (arr.Length < 4)
        {
            return arr.Sum();
        }
        var numbersList = arr.ToList();

        var largestNum = numbersList.Max();
        numbersList.Remove(largestNum);
        var secondLargestNum = numbersList.Max();
        numbersList.Remove(secondLargestNum);
        var thirdLargestNum = numbersList.Max();
        numbersList.Remove(thirdLargestNum);
        var fourthLargestNum = numbersList.Max();
        numbersList.Remove(fourthLargestNum);

        return largestNum + secondLargestNum + thirdLargestNum + fourthLargestNum;
    }


    public string ExOh(string str)
    {
        var stringList = str.ToLower().ToCharArray();
        var amountOfX = stringList.Count(character => character == 'x');
        var amountOfO = stringList.Count(character => character == 'o');

        return amountOfX != amountOfO ? "false" : "true";
    }

    public string Likes(string[] name)
    {
        throw new NotImplementedException();
    }

}