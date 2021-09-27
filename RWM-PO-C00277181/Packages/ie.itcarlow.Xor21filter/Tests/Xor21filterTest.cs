using NUnit.Framework;
using UnityEngine;

namespace Tests
{
  public class Xor21FilterTest
  {
    [Test]
    public void Xor21FilterSimple()
    {
      int[] input = { 4, 2, 8, 3, 9, 4, 1000000000 };
      int[] output = Xor21Filter.Xor21s(input);
      int[] expected = { 17, 23, 29, 22, 28, 17, 1000000021};

      CollectionAssert.AreEqual(expected, output);
    }
  }
}
