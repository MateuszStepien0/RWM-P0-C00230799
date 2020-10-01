using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuloFirstFilter : MonoBehaviour
{
    public static int moduloFirst(int x, int first)
    {
        return x % first;
    }

    public static int[] results(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = moduloFirst(xs[i], xs[0]);
        }
        return result;
    }
}
