using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 1); // Enqueue item with priority 1
        var result = priorityQueue.Dequeue(); // Dequeue should return item1
        Assert.AreEqual("item1", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 1); // Enqueue item with priority 1
        priorityQueue.Enqueue("item2", 3); // Enqueue item with priority 3
        priorityQueue.Enqueue("item3", 2); // Enqueue item with priority 2

        var result1 = priorityQueue.Dequeue(); // Dequeue should return item2 (highest priority)
        var result2 = priorityQueue.Dequeue(); // Dequeue should return item3 (next highest)
        var result3 = priorityQueue.Dequeue(); // Dequeue should return item1 (lowest priority)

        Assert.AreEqual("item2", result1);
        Assert.AreEqual("item3", result2);
        Assert.AreEqual("item1", result3);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found:
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 2); // Enqueue item with priority 2
        priorityQueue.Enqueue("item2", 2); // Enqueue item with priority 2
        priorityQueue.Enqueue("item3", 2); // Enqueue item with priority 2

        var result1 = priorityQueue.Dequeue(); // Dequeue should return item1 (first enqueued)
        var result2 = priorityQueue.Dequeue(); // Dequeue should return item2 (second enqueued)
        var result3 = priorityQueue.Dequeue(); // Dequeue should return item3 (third enqueued)

        Assert.AreEqual("item1", result1);
        Assert.AreEqual("item2", result2);
        Assert.AreEqual("item3", result3);
    }
}