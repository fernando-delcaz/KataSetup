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
}
