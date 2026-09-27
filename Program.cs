static void DownloadTask()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Downloading file...");
    }
}

static void CheckTask()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Checking data...");
    }
}

Thread thread1 = new Thread(DownloadTask);
Thread thread2 = new Thread(CheckTask);

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine("All operations completed.");