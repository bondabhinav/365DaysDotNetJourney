using LearningDotNetDay1;

public class ValueTypeDemo
{
    public void ShowValueTypeBehavior()
    {
        // Original value
        int originalNumber = 10;

        // Value copy होगी
        int copiedNumber = originalNumber;

        // केवल copiedNumber बदलेगा
        copiedNumber = 50;

        Console.WriteLine(
            $"Original Number: {originalNumber}"
        );

        Console.WriteLine(
            $"Copied Number: {copiedNumber}"
        );
    }
}