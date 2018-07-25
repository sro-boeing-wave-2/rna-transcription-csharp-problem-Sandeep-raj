using System;
using System.Collections.Generic;
using System.Linq;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //throw new NotImplementedException("You need to implement this function.");
            Dictionary<Char, Char> dict = new Dictionary<Char, Char>()
            {
                {'G','C' },
                {'C','G' },
                {'T','A' },
                {'A','U' }
            };

            return new string(nucleotide.Select(c => dict[c]).ToArray());

        }
    }
}
