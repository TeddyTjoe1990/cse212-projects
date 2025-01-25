using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    //As all items have equal priority in this tests, we are verifying if the items were placed in the correct order by the Enqueue method, where each new item should go back on the queue
    //Also, we are verifying if the Dequeue method will dequeue the item positioned closer to the front of the queue if items have same priority.
    // Expected Result: valueOne
    // Defect(s) Found: The if statement inside the for loop inside the Dequeue function, should be a greater than, and not a equal or greater than. This will keep the firt item that was added to the queue as the one to dequeue in case other item has the same priority
    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("valueOne", 1);
        priorityQueue.Enqueue("valueTwo", 1);
        priorityQueue.Enqueue("valueThree", 1);

        var expectedResult = "valueOne";

        var itemValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, itemValue);
    }

    [TestMethod]
    // Scenario: Items with different priority to check if the Dequeue method will dequeue the item with most priority
    // Expected Result: valueFive
    // Defect(s) Found: the for loop of the Dequeue method was starting from index 1 insted of index 0, and the statemet of the loop should be queue.Count only as we are using the less than comparison
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("valueOne", 1);
        priorityQueue.Enqueue("valueTwo", 2);
        priorityQueue.Enqueue("valueThree", 3);
        priorityQueue.Enqueue("valueFour", 4);
        priorityQueue.Enqueue("valueFive", 5);

        var expectedResult = "valueFive";

        var itemValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, itemValue);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Check if we encounter an error Excpetion if the queue is empty and we try to dequeue an item 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();


        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: Items with different priority to check if the Dequeue method will dequeue the item with most priority
    // Expected Result: valueFour
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("valueOne", 1);
        priorityQueue.Enqueue("valueTwo", 2);
        priorityQueue.Enqueue("valueThree", 3);
        priorityQueue.Enqueue("valueFour", 4);
        priorityQueue.Enqueue("valueFive", 1);
         priorityQueue.Enqueue("valueSix", 2);

        var expectedResult = "valueFour";

        var itemValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, itemValue);
    }


    [TestMethod]
    // Scenario: Dequeue of multiple items
    // Expected Result: valueThree
    // Defect(s) Found: The Dequeue method was missing the removal of the dequeued item
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("valueOne", 1);
        priorityQueue.Enqueue("valueTwo", 2);
        priorityQueue.Enqueue("valueThree", 3);
        priorityQueue.Enqueue("valueFour", 4);
        priorityQueue.Enqueue("valueFive", 1);
         priorityQueue.Enqueue("valueSix", 3);

        var expectedResult = "valueThree";
        priorityQueue.Dequeue();
        var itemValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, itemValue);
    }


}