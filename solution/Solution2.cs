public class Solution
{
    public int MinimumDeletions(string s)
    {
        // Get the length of the input string
        var n = s.Length;

        // Create a dynamic programming array to store the minimum deletions for each prefix
        var dp = new int[n];

        // Initialize the count of 'b' characters to 0
        var countB = 0;

        // Iterate over the string
        for (var i = 0; i < n; i++)
        {
            // If the current character is 'b', update the dp array and increment the count of 'b' characters
            if (s[i] == 'b')
            {
                dp[i] = i == 0 ? 0 : dp[i - 1]; // If it's the first character, set dp[i] to 0, otherwise copy from previous dp value
                countB++; // Increment the count of 'b' characters
            }
            // If the current character is 'a', update the dp array based on the minimum of two options:
            // 1. Delete the current character (1 + previous dp value)
            // 2. Keep the current character and increment the count of 'b' characters
            else
            {
                var prev = i == 0 ? 0 : dp[i - 1]; // Get the previous dp value, or 0 if it's the first character
                dp[i] = Math.Min(1 + prev, countB); // Update the dp array with the minimum of the two options
            }
        }

        // Return the minimum number of deletions required to make the string sorted, which is stored in the last element of the dp array
        return dp[n - 1];
    }
}