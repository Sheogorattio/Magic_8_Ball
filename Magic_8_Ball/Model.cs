using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    internal class Ball : IModel
    {
        static string[] Answers = new string[] { "Yes", "No", "Maybe" };
        StringBuilder answer;

        public Ball()
        {
            answer = new StringBuilder();
        }

        public string Answer
        {
            get
            {
               return answer.ToString();
            }
        }

        public void GenerateAnswer()
        {
            answer.Clear();
            answer = answer.Append(Answers[new Random().Next(0, 3)]);
        }
    }
}
