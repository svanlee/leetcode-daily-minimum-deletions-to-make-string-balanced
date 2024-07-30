function minimumDeletions(s: string): number {
    // Initialize the minimum number of deletions to infinity
    let min = Infinity;
    
    // Count the total number of 'a' characters in the string
    let countA = 0;
    for (let i = 0; i < s.length; ++i)
        countA += +(s[i] === 'a'); // Use a trick to convert boolean to 0 or 1
    
    // Initialize the count of 'b' characters to 0
    let countB = 0;
    
    // Iterate over the string, considering each position as a potential split point
    for (let i = 0; i <= s.length; ++i) {
        // Update the minimum number of deletions if the current split point is better
        min = Math.min(min, countB + countA);
        
        // If we've reached the end of the string, stop iterating
        if (i === s.length) break;
        
        // Update the counts of 'a' and 'b' characters based on the current character
        countA -= +(s[i] === 'a'); // Decrement 'a' count if current character is 'a'
        countB += +(s[i] === 'b'); // Increment 'b' count if current character is 'b'
    }

    // Return the minimum number of deletions required to make the string sorted
    return min;
};