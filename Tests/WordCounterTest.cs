using System;
using Xunit;

namespace WordCounter.Objects
{
  public class WordCounterTest
  {
    [Fact]
    public void T1_Compare_aToa_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("a", "a");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void T2_CountRepeats_aTob_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("a", "b");
      Assert.Equal(0, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void T3_CountRepeats_aToab_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("a", "a b");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void T4_CountRepeats_aToaba_3()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("a", "a b a");
      Assert.Equal(2, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void T5_CountRepeats_andToand_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("and", "and");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void T6_CountRepeats_andTocatanddog_2()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("and", "cat and dog");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void T7_CountRepeats_andTocatanddogandfish_3()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("and", "cat and dog and fish");
      Assert.Equal(2, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void T8_CountRepeats_helloToHellothereIsayExclamation_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("hello", "Hello there, I say!");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
  }
}
