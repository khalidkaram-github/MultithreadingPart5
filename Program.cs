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


            #region threadbool Way 3 example 1
            //Task task = Task.Factory.StartNew(() =>
            //{
            //    // Code to run in a separate thread
            //    Console.WriteLine("Task is running in a separate thread.");
            //});
            //Console.ReadLine(); 
            #endregion


        }
    }
}
