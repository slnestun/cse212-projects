using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three people with with different priorities
    // Expected Result: Tim, sue, Bob
    // Defect(s) Found: Dequeue did not remove the selected item.
    // The loop also skipped the last item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 5);

        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add four people, including two with the same priority.
    // Expected Result: Juan, Ana, Pedro, Maria
    // Defect(s) Found: The original comparison used >= instead of >,
    // causing the last person with the same priority to be selected
    // instead of respecting FIFO order.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Pedro", 3);
        priorityQueue.Enqueue("Juan", 5);
        priorityQueue.Enqueue("Ana", 5);
        priorityQueue.Enqueue("Maria", 2);

        Assert.AreEqual("Juan", priorityQueue.Dequeue());
        Assert.AreEqual("Ana", priorityQueue.Dequeue());
        Assert.AreEqual("Pedro", priorityQueue.Dequeue());
        Assert.AreEqual("Maria", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Try to dequeue an item from an empty priority queue.
    // Expected Result: An InvalidOperationException with the message
    // "The queue is empty." should be thrown.
    // Defect(s) Found: None. The correct exception and message were returned.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}