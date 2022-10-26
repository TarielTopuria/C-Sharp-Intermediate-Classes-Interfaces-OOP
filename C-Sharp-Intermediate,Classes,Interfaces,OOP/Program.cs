using C_Sharp_Intermediate_Classes_Interfaces_OOP;
using System.Diagnostics;

namespace CSharpCourse;

public class Program
{
    public static void Main (string[] args)
    {
        //StopwatchCalculator execution

        //StopwatchCalculator.Start();
        //Thread.Sleep(3000);
        //StopwatchCalculator.Stop();
        //Console.WriteLine(StopwatchCalculator.Value());
        //Console.WriteLine("");
        //StopwatchCalculator.Start();
        //Thread.Sleep(3000);
        //StopwatchCalculator.Stop();
        //Console.WriteLine(StopwatchCalculator.Value());


        //Post execution

        Post.UpVote();
        Post.UpVote();
        Post.UpVote();
        Post.UpVote();
        Post.DownVote();
        Console.WriteLine("Title: " + Post.GetTitle());
        Console.WriteLine("Post Description: " + Post.GetDescription());
        Console.WriteLine("Date: " + Post.Getdate());
        Console.WriteLine("Votes: " + Post.GetVotes());
    }
}