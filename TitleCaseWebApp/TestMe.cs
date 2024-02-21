namespace TitleCaseWebApp
{
    public class TestMe
    {
        
            public string MakeTitle(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                    return input;

                string[] words = input.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(words[i]))
                    {
                        char[] wordChars = words[i].ToCharArray();
                        wordChars[0] = char.ToUpper(wordChars[0]);
                        words[i] = new string(wordChars);
                    }
                }

                return string.Join(' ', words);
            }
        }
    }

