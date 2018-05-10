using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public abstract class Comparer : IComparer <Question>
    {
        DifficultyTopicScoreTime LengthFirst = new DifficultyTopicScoreTime();

        Comparer<Question> bc = (Comparer<Question>)LengthFirst;

        Box BoxA = new Box(2, 6, 8);
        Box BoxB = new Box(10, 12, 14);
        int x = LengthFirst.Compare(BoxA, BoxB);
        Console.WriteLine();
        Console.WriteLine(x.ToString());




    }
}
