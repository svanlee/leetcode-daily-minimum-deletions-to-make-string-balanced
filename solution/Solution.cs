public class Solution
{
    public int MinimumDeletions(string s)
    {
        // Initialize the minimum number of deletions to maximum possible value
        int min = int.MaxValue;

        // Count the total number of 'a' characters in the string
        int countA = 0;
        foreach (char c in s)
        {
            if (c == 'a') countA++; // Increment countA if character is 'a'
        }

        // Initialize the count of 'b' characters to 0
        int countB = 0;

        // Iterate over the string, considering each position as a potential split point
        for (int i = 0; i <= s.Length; i++)
        {
            // Update the minimum number of deletions if the current split point is better
            min = Math.Min(min, countB + countA);

            // If we've reached the end of the string, stop iterating
            if (i == s.Length) break;

            // Update the counts of 'a' and 'b' characters based on the current character
            if (s[i] == 'a') countA--; // Decrement countA if current character is 'a'
            if (s[i] == 'b') countB++; // Increment countB if current character is 'b'
        }

        // Return the minimum number of deletions required to make the string sorted
        return min;
    }
}