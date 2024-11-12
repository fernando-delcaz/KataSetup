using Kata;

namespace Tests;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;
public class AnagramTest
{
    [Fact]
    public void a_is_not_an_anagram_of_b()
    {
        HashSet<string> anagrams = Anagram.GetAnagrams("b");
        anagrams.Should().NotContain("a");
    }

    [Fact]
    public void a_is_an_anagram_of_a()
    {
        HashSet<string> anagrams = Anagram.GetAnagrams("a");
        anagrams.Should().Contain("a");
    }

    [Fact]
    public void returns_the_anagrams_of_a_two_letter_word()
    {
        HashSet<string> anagrams = Anagram.GetAnagrams("ab");

        anagrams.Should().Contain("ba");
        anagrams.Should().Contain("ab");
    }
}
