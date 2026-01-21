using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Higher priority item should be dequeued first
    // Expected Result: Item with highest priority is returned
    // Defect(s) Found: None 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("high", 5);
        priorityQueue.Enqueue("medium", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("high", result);
    }

    [TestMethod]
    // Scenario: Same priority items should follow FIFO order
    // Expected Result: First enqueued item with same priority is dequeued first
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 2);
        priorityQueue.Enqueue("second", 2);
        priorityQueue.Enqueue("third", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("first", result);
    }

    // Add more test cases as needed below.
}