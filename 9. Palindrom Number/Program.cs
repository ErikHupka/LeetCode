Console.WriteLine(IsPalindrome(x: 121));

static bool IsPalindrome(int x)
{
    string palindrome = x.ToString();
    int palindromLength = palindrome.Length;

    for (int i = 0; i < palindromLength / 2; i++)
    {
        if (palindrome[i] != palindrome[palindromLength - 1 - i])
        {
            return false;
        }
    }
    return true;
}