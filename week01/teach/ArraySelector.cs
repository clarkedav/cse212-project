public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
   
        var l3 = new[] { 'A', 'A', 'A', 'A', 'A'};
        var l4 = new[] { 'B', 'B', 'B', 'B', 'B'};
        select = new[] {1, 2, 1, 2, 1, 2, 1, 2, 1, 2};
        var charResult = ListSelector(l3, l4, select);
        Console.WriteLine("<char[]>{" + string.Join(", ", charResult) + "}");   
        
    }

   private static int[] ListSelector(int[] list1, int[] list2, int[] select)
{
    // Create the result array (same size as selector)
    int[] result = new int[select.Length];

    // Index counters for list1 and list2
    int i1 = 0;
    int i2 = 0;

    // Loop through the selector array
    for (int i = 0; i < select.Length; i++)
    {
        if (select[i] == 1)
        {
            result[i] = list1[i1];
            i1++; // move to next item in list1
        }
        else if (select[i] == 2)
        {
            result[i] = list2[i2];
            i2++; // move to next item in list2
        }
    }

    return result;
    }
    private static char[] ListSelector(char[] list3, char[] list4, int[] select)
    {
        var result = new char[select.Length];
        var i1 = 0;
        var i2 = 0;

        for (var i = 0; i < select.Length; i++)
            result[i] = select[i] == 1 ? list3[i1++] : list4[i2++];

        return result;
    }
    
}