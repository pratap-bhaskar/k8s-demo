// See https://aka.ms/new-console-template for more information
var waitInSecsEnvVariable = Environment.GetEnvironmentVariable("WAIT_IN_SECS");
var waitInSecs = waitInSecsEnvVariable == null ? 5 : int.Parse(waitInSecsEnvVariable);

for (int i = 1; i <= waitInSecs; i++)
{
    Console.WriteLine("Waiting for a long operation to Complete....");
    Console.WriteLine($"{i} of {waitInSecs}");
    Thread.Sleep(i * 1000);
}

Console.WriteLine("Long operation completed");