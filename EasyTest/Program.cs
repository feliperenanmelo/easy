static bool WordIsValid(string word)
{
    var wordLenght = word.Length;

    if(wordLenght < 1 || wordLenght > 100) return false;

    bool isUpperCase = false;
    bool isLowerCase = false;

    var countUppercaseLetters = 0;

    foreach (char letter in word)
    {
        if(char.IsUpper(letter))
        {
            isUpperCase = true;

            countUppercaseLetters += 1;

            if (isLowerCase) return false;

            continue;
        }

        if (char.IsLower(letter))
        {
            if (countUppercaseLetters > 1 && isUpperCase) return false;

            isLowerCase = true;
            
            continue;
        }

        return false;
    }

    return isUpperCase || isLowerCase;
}
