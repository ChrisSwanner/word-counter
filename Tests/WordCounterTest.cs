using System;
using Xunit;

namespace WordCounter.Objects
{
  public class WordCounterTest
  {
    [Fact]
    public void T1_Compare_aToa_1()
    {
      Words testWords = new Words("a", "a");
      Assert.Equal(1, testWords.Compare());
    }
    [Fact]
    public void T2_Compare_aTob_0()
    {
      Words testWords = new Words("a", "b");
      Assert.Equal(0, testWords.Compare());
    }
    [Fact]
    public void T3_Compare_aToab_1()
    {
      Words testWords = new Words("a", "a b");
      Assert.Equal(1, testWords.Compare());
    }
    [Fact]
    public void T4_Compare_aToaba_3()
    {
      Words testWords = new Words("a", "a b a");
      Assert.Equal(3, testWords.Compare());
    }
  }
}
