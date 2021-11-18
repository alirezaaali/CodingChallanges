public static int palindromeIndex(string s)
    {
         for (int i = 0, j = s.Length-1; i < j; i++, j--) {
        if (s[i] != s[j]) {
            if (isPalindrome(s, i+1, j))
                return i;
            
            if (isPalindrome(s, i, j-1))
                return j;

            return -1;
        }
    }

    return -1;

    }
    public static bool isPalindrome(string s, int start, int end) {
    for (int i = start, j = end; i < j; i++, j--) {
        if (s[i] != s[j])
            return false;
    }
    return true;
}
