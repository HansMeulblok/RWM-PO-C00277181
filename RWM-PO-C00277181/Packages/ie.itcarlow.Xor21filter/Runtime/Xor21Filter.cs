using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xor21Filter
{
   public static int Xor21(int x)
   {
       return x = x^21;
   }

   public static int[] Xor21s(int[] xs)
   {
       int[] result = new int[xs.Length];
       for (int i = 0; i < xs.Length; i++)
       {
           result[i] = Xor21(xs[i]);
       }
       return result;
   }
}
