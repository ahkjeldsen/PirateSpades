﻿// Helena 

namespace PirateSpades.Func
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// A shuffle algorithm, which is unbiased. Iterates through the whole collection and swaps the item at index i, with an item 
    /// at a randomly generated index in the collection. Does this until there's only one item left.
    /// </summary>
    public class FisherYatesAlg
    {
        private static readonly Random r = new Random();

        public static void Algorithm<T>(List<T> l) {
            Contract.Requires(l.Count != 0 && l != null);
            Contract.Ensures(l.Count == Contract.OldValue(l.Count));

            if(l.Count < 2) return;

            for(var i = l.Count - 1; i > 0; i--) {
                var index = r.Next(i);

                var tmp = l[index];
                l[index] = l[i];
                l[i] = tmp;
            }

            /*if (c.Count > 1) {
                int i = c.Count - 1;
                while (i > 1) {
                    int s = r.Next(i);
                    T holder = arr[i];
                    arr[i] = arr[s];
                    arr[s] = holder;
                    i--;
                }
            }*/
        }
    }
}
