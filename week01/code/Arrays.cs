public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create an array with the size specified by length.
        // Step 2: Loop through each position of the array.
        // Step 3: Calculate the multiple using number and the position.
        // Step 4: Store the calculated multiple in the array.
        // Step 5: Return the completed array.
        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Use the amount value to determine how to split the list into two parts.
        // Step 2: Calculate the first part using the list count and amount, and store it in a variable.
        // Step 3: Calculate the last part and store it in another variable.
        // Step 4: Clear the original list after saving both parts.
        // Step 5: Add the last part first, followed by the first part.
        List<int> firstPart = data.GetRange(0, data.Count - amount);
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
