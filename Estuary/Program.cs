class Program
{
    public static void Main(string[] args)
    {
        int numberOfCharacters = 10;
        string randomString = GenerateRandom(numberOfCharacters);
        Console.WriteLine(randomString);

        Display100Character();

        string nameOfBall = "Ball 1";
        int positionOfBall = FindBall(nameOfBall);
        if (positionOfBall > 0)
        {
            Console.WriteLine($"The ball in box {positionOfBall}");
        }
        else
        {
            Console.WriteLine("No balls found in the boxes.");
        }
    }

    private static string GenerateRandom(int length)
    {
        Random random = new Random();
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string result = "";

        for (var i = 0; i < length; i++)
        {
            char randomCharacter = characters[random.Next(characters.Length)];
            result += randomCharacter;
        }
            
        return result;
    }

    private static void Display100Character()
    {
        int numberPerRepeat = 24;
        string chars= "";
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            char character;
            
            if (i % 2 == 0)
            {
                character = (char)random.Next(48,57);
            }
            else
            {
                if (i < numberPerRepeat)
                {
                    character = (char)random.Next(97, 122);
                    chars += character;
                }
                else
                {
                    int positionOfCharacter = (i % numberPerRepeat) / 2;
                    character = chars[positionOfCharacter];
                }
                
            }

            Console.Write($"{character}");
        }
        Console.WriteLine();
    }

    private static int FindBall(string desiredBall)
    {
        Dictionary<string, int> boxes = new Dictionary<string, int>();

        boxes.Add("Ball 1", 1);
        boxes.Add("Ball 2", 1);
        boxes.Add("Ball 3", 1);
        boxes.Add("Ball 4", 2);
        boxes.Add("Ball 5", 2);
        boxes.Add("Ball 6", 3);
        boxes.Add("Ball 7", 3);
        boxes.Add("Ball 8", 3);
        boxes.Add("Ball 9", 3);

        if (boxes.ContainsKey(desiredBall))
        {
            int boxNumber = boxes[desiredBall];
            return boxNumber;
        }
        else
        {
            return -1;
        }
    }
}
