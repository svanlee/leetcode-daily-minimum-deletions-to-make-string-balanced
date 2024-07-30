#include <string>
#include <vector>
#include <algorithm>

class Solution
{
public:
    int minimumDeletions(std::string s)
    {
        // Get the size of the string
        int n = s.size();

        // Create a dynamic programming vector to store the minimum deletions
        std::vector<int> f(n + 1, 0);

        // Initialize a counter for the number of 'b's seen so far
        int b = 0;

        // Iterate over the string
        for (int i = 1; i <= n; ++i)
        {
            // If the current character is 'b', increment the counter and don't change the dynamic programming vector
            if (s[i - 1] == 'b')
            {
                f[i] = f[i - 1];
                ++b;
            }
            // If the current character is not 'b', consider two options:
            // 1. Delete the current character (add 1 to the previous minimum deletions)
            // 2. Don't delete the current character (keep the previous minimum deletions)
            // Choose the option with the minimum deletions
            else
            {
                f[i] = std::min(f[i - 1] + 1, b);
            }
        }

        // Return the minimum deletions for the entire string
        return f[n];
    }
};