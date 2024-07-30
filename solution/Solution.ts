function minimumDeletions(s: string): number {
    // Initialize the answer (minimum number of deletions) to 0
    let ans = 0;
    
    // Initialize a counter for the number of 'b' characters encountered
    let count = 0;
    
    // Iterate over the input string
    for (let i of s) {
        // If the current character is 'b', increment the counter
        if (i === 'b') {
            count += 1;
        } 
        // If the current character is not 'b' and there are 'b' characters encountered before
        else if (count) {
            // Increment the answer (delete one 'b' character)
            ans += 1;
            // Decrement the counter (one 'b' character is deleted)
            count -= 1;
        }
    }
    
    // Return the minimum number of deletions required to make the string sorted
    return ans;
}