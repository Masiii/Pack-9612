using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Question
    {
        public string Topic { get; set; }
        public string Sample { get; set; }
        public string Difficulty { get; set; }
        public String Time { get; set; }
        public Double Score { get; set; }


        public override string ToString()
        {
            return $"{this.Topic}\n\n{this.Sample}\t{this.Difficulty}\t\t\t\t\t||\t{this.Time}\t{this.Score} ";
        }
    }
}


