namespace LongestSubstringWithoutRepeatingCharacters
{
  public class Solution
  {
    public int LengthOfLongestSubstring(string s)
    {
      // If the string is empty or has one character, return its length
      if (s.Length == 0 || s.Length == 1)
        return s.Length;

      int longestSubstringLength = 0;

      // Left pointer for the start of the sliding window
      int left = 0;

      // Iterate Right pointer for the end of the sliding window
      for (int right = 0; right < s.Length; right++)
      {

        // Check for duplicates between Left and Right pointers
        for (int i = left; i < right; i++)
        {

          // If a duplicate is found, move the Left pointer to the right of the duplicate
          if (s[right] == s[i])
          {
            left = i + 1;
            break;
          }
        }

        // Update the length of the longest substring found
        if (longestSubstringLength < right - left + 1)
          longestSubstringLength = right - left + 1;
      }

      return longestSubstringLength;
    }
  }
}