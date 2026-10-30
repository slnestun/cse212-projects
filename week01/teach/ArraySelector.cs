public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        //Create an array to store the selected elements.
        int[] result = new int[select.Length];

        // initialize the index for list1 and list2
        int l1Idx = 0;
        int l2Idx = 0;

        // iterate through the select array
        for (int i = 0; i < select.Length; i++)
        {
            // if the value in select is 1, take the next element from list1
            if (select[i] == 1)
            {
                result[i] = list1[l1Idx++];
            }
            // if the value in select is 2, take the next element from list2
            else if (select[i] == 2)
            {
                result[i] = list2[l2Idx++];
            }
        }

        //return the result array containing the selected elements
        return result;
    }
}