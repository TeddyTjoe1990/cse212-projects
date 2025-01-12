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
        // Step 1: Create an array to hold the multiples of the number.
        double[] multiples = new double[length];

        // Step 2: Loop through and fill the array with multiples of the 'number'.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Store the multiple of the 'number' at index 'i'.
            multiples[i] = number * (i + 1); // i + 1 because the first multiple is number * 1.
        }

        // Step 4: Return the array with all the multiples.
        return multiples;
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
        // Step 1: Ensure the amount of rotation is within the bounds of the list size.
        int rotateAmount = amount % data.Count; // This handles the case where amount > data.Count.

        // Step 2: If rotateAmount is 0, no rotation is needed.
        if (rotateAmount == 0)
            return;

        // Step 3: Split the list into two parts:
        // - The last 'rotateAmount' elements.
        // - The rest of the list.
        List<int> lastPart = data.GetRange(data.Count - rotateAmount, rotateAmount);
        List<int> frontPart = data.GetRange(0, data.Count - rotateAmount);

        // Step 4: Clear the original list and add the lastPart followed by frontPart.
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(frontPart);
    }
}
