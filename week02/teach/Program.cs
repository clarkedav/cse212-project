
{
    Console.WriteLine("\n======================\nComplex Stack Tests\n======================");

    // Test 1: Balanced parentheses
    string input1 = "(a == 3 or (b == 5 and c == 6))";
    bool result1 = ComplexStack.DoSomethingComplicated(input1);
    Console.WriteLine($"Input: {input1}");
    Console.WriteLine($"Balanced: {result1}\n"); // Expected: True

    // Test 2: Wrong square bracket
    string input2 = "(students]i].Grade > 80 and students[i].Grade < 90";
    bool result2 = ComplexStack.DoSomethingComplicated(input2);
    Console.WriteLine($"Input: {input2}");
    Console.WriteLine($"Balanced: {result2}\n"); // Expected: False

    // Test 3: Missing closing parenthesis
    string input3 = "(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))";
    bool result3 = ComplexStack.DoSomethingComplicated(input3);
    Console.WriteLine($"Input: {input3}");
    Console.WriteLine($"Balanced: {result3}\n"); // Expected: False
}

{
    Console.WriteLine("\n======================\nCustomer Service\n======================");
    CustomerService.Run();
    CustomerServiceSolution.Run();
}


