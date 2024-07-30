#include <string>
#include <algorithm>

using namespace std;

class Solution
{
public:
    int minimumDeletions(string s)
    {
        // Initialize variables to store the minimum deletions and the count of 'b' characters
        int ans = 0;
        int count_b = 0;

        // Iterate over the string
        for (int i = 0; i < s.size(); i++)
        {
            // If the current character is 'b', increment the count
            if (s[i] == 'b')
            {
                count_b++;
            }
            // If the current character is not 'b', update the minimum deletions
            else
            {
                ans = min(ans + 1, count_b);
            }
        }

        // Return the minimum deletions required to make the string sorted
        return ans;
    }
};