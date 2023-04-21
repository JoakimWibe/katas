using FluentAssertions;

namespace Katas.Tests;

public class KatasTests
{
    [Fact]
    public void should_return_number_of_occurances()
    {
        // arrange 
        var katas = new Katas();
        var sample = new int[] { 1, 5, 6, 4, 3, 5, 5};
        
        // act
        var result = katas.NumberOfOccurrences(5,sample);
        
        // assert
        result.Should().Be(3);
    }
    
    [Theory]
    [InlineData("test", "test covfefe")]
    [InlineData("coverage", "covfefe")]
    [InlineData("coverage coverage", "covfefe covfefe")]
    [InlineData("coverage test coverage", "covfefe test covfefe")]
    public void should_return_covfefe_for_coverage(string input, string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.Covfefe(input);
        
        // assert
        result.Should().Be(expected);
    }

    [Fact]
    public void should_return_sum_of_ints_in_string()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.SumOfIntegersInString("The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog");
        
        // assert
        result.Should().Be(3635);
    }
    
    [Theory]
    [InlineData("helLo world", 7)]
    [InlineData("gm-grmntwk)c#mngvfud$(=mn-=,$sdt-)xx)q,l%l %o-#zlh",29)]
    public void should_return_amount_of_consonant_in_string(string input,int expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.ConsonantCount(input);
        
        // assert
        result.Should().Be(expected);
    }

    [Fact]
    public void should_return_amount_of_vowels()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.GetVowelCount("abracadabra");
        
        // assert
        result.Should().Be(5);
    }
    
    [Fact]
    public void should_return_highest_and_lowest()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.HighAndLow("1 2 3 4 5");
        
        // assert
        result.Should().Be("5 1");
    }
    
    [Fact]
    public void should_return_rearanged_digit_in_descending_order()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.DescendingOrder(42145);
        
        // assert
        result.Should().Be(54421);
    }
    
    [Theory]
    [InlineData("test", "es")]
    [InlineData("testing", "t")]
    public void should_return_middle_char(string input,string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.GetMiddle(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("This website is for losers LOL!","Ths wbst s fr lsrs LL!")]
    public void should_remove_all_vowels(string input,string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.Disemvowel(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void should_count_sheeps_in_array()
    {
        // arrange 
        var katas = new Katas();
        var sheeps = new bool[] { true, false, true };

        // act
        var result = katas.CountSheeps(sheeps);
        
        // assert
        result.Should().Be(2);
    }
    
    [Fact]
    public void should_find_every_summation()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.Summation(8);
        
        // assert
        result.Should().Be(36);
    }
    
    [Fact]
    public void should_filter_out_strings_from_list()
    {
        // arrange 
        var katas = new Katas();
        var sample = new List<object>() {1, 2, "a", "b"};
        var expected = new List<int>() {1, 2};

        // act
        var result = katas.GetIntegersFromList(sample);
        
        // assert
        result.Should().Equal(expected);
    }
    
    [Fact]
    public void should_reverse_digitize_number()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.Digitize(35231);
        
        // assert
        result.Should().Equal(new long[] {1,3,2,5,3});
    }
    
    [Fact]
    public void should_sum_two_smallest_numbers()
    {
        // arrange 
        var katas = new Katas();
        var sample = new int[] { 19, 5, 42, 2, 77 };

        // act
        var result = katas.sumTwoSmallestNumbers(sample);
        
        // assert
        result.Should().Be(7);
    }
    
    [Theory]
    [InlineData("xo", true)]
    [InlineData("xxOo", true)]
    public void should_check_for_same_amount_of_x_and_o(string input,bool expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.XO(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void should_find_shortest_word()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.FindShort("bitcoin take over the world maybe who knows perhaps");
        
        // assert
        result.Should().Be(3);
    }
    
    [Fact]
    public void should_sum_without_min_and_max()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.Sum(new[] { 6, 2, 1, 8, 10});
        
        // assert
        result.Should().Be(16);
    }
    
    [Fact]
    public void should_return_number_with_odd_occurances()
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.FindOddApperance(new int[] {20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5});
        
        // assert
        result.Should().Be(5);
    }
    
    [Theory]
    [InlineData("aa_", "false")]
    [InlineData("u__hello_world123", "true")]
    public void should_validate_username(string input, string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.CodelandUsernameValidation(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}, "1,4,13")]
    [InlineData(new string[] {"1, 3, 9, 10, 17, 18", "1, 4, 9, 10"}, "1,9,10")]
    public void should_find_intersection(string[] input, string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.FindIntersection(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("aa6?9", "false")]
    [InlineData("acc?7??sss?3rr1??????5", "true")]
    public void should_sum_between_question_marks(string input, string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.QuestionsMarks(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("coderbyte", "etybredoc")]
    [InlineData("I Love Code", "edoC evoL I")]
    public void should_return_reversed_string(string input, string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.FirstReverse(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(4, 24)]
    [InlineData(8, 40320)]
    public void should_return_factorial(int input, int expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.FirstFactorial(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("fun&!! time", "time")]
    [InlineData("I love dogs", "love")]
    [InlineData("Hello world123 567", "Hello")]
    public void should_return_longest_word(string input, string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.LongestWord(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(new int[] {1, 1, 1, -5}, -2)]
    [InlineData(new int[] {0, 0, 2, 3, 7, 1}, 13)]
    [InlineData(new int[] { 3, 7, 1}, 11)]
    [InlineData(new int[] { 0}, 0)]
    public void should_return_largest_four(int[] input, int expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.LargestFour(input);
        
        // assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("xooxxo", "true")]
    [InlineData("x", "false")]
    [InlineData("xooxxxxooxo", "false")]
    public void should_return_if_equal_amount_of_xo(string input, string expected)
    {
        // arrange 
        var katas = new Katas();

        // act
        var result = katas.ExOh(input);
        
        // assert
        result.Should().Be(expected);
    }
}