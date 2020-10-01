using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFilter : MonoBehaviour
{
    public static int cube(int x)
    {
        return x * x * x;
    }

    public static int[] cubes(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = cube(xs[i]);
        }
        return result;
    }
}
