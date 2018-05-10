using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>()
            {
                new Question() { Topic = "Synetic" , Sample = "Calculate the average speed ?", Difficulty = "easy", Score = 0.5 , Time = "3 min" },
                new Question() { Topic = "Dynamic" , Sample = "Calculate device acceleration ?", Difficulty = "medium", Score = 1.0 , Time = "5 min" },
                new Question() { Topic = "Dynamic" , Sample = "Calculate the stretching force of the rope ?", Difficulty = "medium", Score = 1.0 , Time = "3 min" },
                new Question() { Topic = "Dynamic" , Sample = "Calculate potential energy ?", Difficulty = "Hard", Score = 2.0 , Time = "5 min" },
                new Question() { Topic = "energy" , Sample = "Definition of Newton's Third rule ?", Difficulty = "Hard", Score = 1.0 , Time = "3 min" },
            };


            //Define From comparer class
            questions.Sort(new DifficultyTopicScoreTime());

          
            foreach (var Question in questions)
            {
                Console.WriteLine(Question);
            }

            


        }

    }
}
