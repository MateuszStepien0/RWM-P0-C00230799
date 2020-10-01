using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ModuloFirstFilterTest
    {
        [Test]
        public void ModuloFirstFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = ModuloFirstFilter.results(input);
            int[] expected = { 0, 2, 0, 3, 1, 0, 2, 1, 3, 2 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void ModuloFirstFilterNegative()
        {
            int[] input = { -4, -1, -5, -2, -7, -5, -2, -8, -10, -14 };
            int[] output = ModuloFirstFilter.results(input);
            int[] expected = { 0, -1, -1, -2, -3, -1, -2, 0, -2, -2 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
