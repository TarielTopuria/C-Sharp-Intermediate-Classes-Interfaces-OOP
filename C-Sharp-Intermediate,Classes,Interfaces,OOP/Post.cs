using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate_Classes_Interfaces_OOP
{
    public class Post
    {
        private static readonly string Title = "My First Post";
        private static readonly string Description = "This is test post to check my code";
        private static readonly string date = DateTime.Today.ToString();
        private static int Votes = 0;

        public static void UpVote()
        {
            Votes++;
        } 

        public static void DownVote()
        {
            Votes--;
        }

        public static string GetTitle()
        {
            return Title;
        }

        public static string GetDescription()
        {
            return Description;
        }

        public static string Getdate()
        {
            return date;
        }

        public static int GetVotes()
        {
            return Votes;
        }
    }
} 