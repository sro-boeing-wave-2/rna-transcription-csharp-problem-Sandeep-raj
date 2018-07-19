using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //throw new NotImplementedException("You need to implement this function.");
            Dictionary<Char, Char> dict = new Dictionary<Char, Char>()
            {
                { 'G','C' },
                {'C','G' },
                {'T','A' },
                {'A','U' }
            };

            string sequence = "";

            foreach(Char c in nucleotide)
            {
                sequence += dict[c];
            }
            

            return sequence;
        }
    }
}
