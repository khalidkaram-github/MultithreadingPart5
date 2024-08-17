namespace MultithreadingPart5
{
    internal class Program
    {
        static void DisplayWelcome(object state)
        {
            string name = (string)state;
            Console.WriteLine($"Welcome : {name}");
        }

        static void Main(string[] args)
        {


            #region threadbool Way 1 example 1
            //ThreadPool.QueueUserWorkItem(DisplayWelcome, "khalid");
            //Console.ReadLine();
            #endregion

            #region threadbool Way 1 example 2
            //for (int i = 0; i < 10; i++)
            //{
            //    int taskNumber = i; // Capture the loop variable
            //    ThreadPool.QueueUserWorkItem(state =>
            //    {
            //        Console.WriteLine($"Task {taskNumber}: is starting on thread {Thread.CurrentThread.ManagedThreadId}.");
            //        Thread.Sleep(1000); // Simulate some work
            //        Console.WriteLine($"Task {taskNumber}: is completing on thread {Thread.CurrentThread.ManagedThreadId}.");
            //    });
            //}
            //Console.WriteLine("Main thread is continuing to run...");
            //Console.ReadLine();  // Prevent the application from closing immediately 
            #endregion

            #region threadbool Way 2 example 1
            //Task.Run(() =>
            //{
            //    // Your code here
            //    Console.WriteLine("Task running in thread pool");
            //});
            #endregion

            #region  threadboolWay 2 example 2
            //Task<int> task = Task.Run(() =>
            //{
            //    // Simulate some computation
            //    return 42;
            //});

            //int result = task.Result;
            //Console.WriteLine($"Result: {result}"); 
            #endregion

            #region threadbool Way 2 example 3

            //var tasks = new Task[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    int taskNumber = i;
            //    tasks[i] = Task.Run(() =>
            //    {
            //        Console.WriteLine($"Task {taskNumber} is starting.");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Task {taskNumber} is completed.");
            //    });
            //}

            //Task.WaitAll(tasks); // Wait for all tasks to complete
            //Console.WriteLine("All tasks are completed."); 
            #endregion

            #region threadbool Way 3 example 1
            //Task task = Task.Factory.StartNew(() =>
            //{
            //    // Code to run in a separate thread
            //    Console.WriteLine("Task is running in a separate thread.");
            //});
            //Console.ReadLine(); 
            #endregion

            #region threadbool Way 3 example 2
            //Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("Long-running task is starting.");
            //    Thread.Sleep(3000); // Simulate long work
            //    Console.WriteLine("Long-running task is completed.");
            //}, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            //Console.ReadLine(); 
            #endregion
        }
    }
}
