class Solution:
    def minimumDeletions(self, s: str) -> int:
        # Get the length of the input string
        n = len(s)
        
        # Initialize a list to store the minimum number of deletions up to each index
        f = [0] * (n + 1)
        
        # Initialize a counter for the number of 'b' characters encountered
        b = 0
        
        # Iterate over the input string
        for i, c in enumerate(s, 1):
            # If the current character is 'b', increment the counter and update f[i]
            if c == 'b':
                f[i] = f[i - 1]
                b += 1
            # If the current character is not 'b', update f[i] with the minimum number of deletions
            else:
                f[i] = min(f[i - 1] + 1, b)
        
        # Return the minimum number of deletions required to make the entire string sorted
        return f[n]