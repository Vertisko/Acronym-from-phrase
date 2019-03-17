using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Char;

namespace AcronymFromPhrase
{
  public static class AcronymFromPhrase
  {
//      IEnumerable<string>

      private static string RemoveDashes(string phrase)
      {
          return phrase.Replace('-', ' ');
      }
      private static IEnumerable<string> ParsePhraseIntoWords (string phrase)
      {
          return  Regex.Replace(phrase, "[^a-zA-Z0-9% ._]", string.Empty).Split(' ');
      
      }
      private static string ProcessWords(IEnumerable<string> words)
      {
          return words.Where(word => !string.IsNullOrEmpty(word)).Aggregate("", (current, word) => current + ToUpper(word[0]));
      }
      public static string GenerateAcronym(string phrase)
      {
     
        return ProcessWords(ParsePhraseIntoWords(RemoveDashes(phrase)));

      }
      
  }
}