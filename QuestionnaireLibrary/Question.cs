using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireLibrary
{
    public class Question
    {
        // Attributes
        private List<Answer> possibleAnswer = new List<Answer>();
        private string text;
        private string imageUrl;
        public string Text
        {
            get { return text; }
            set { text = value;}
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value;}
        }

        public Question(string text)
        {
            this.text = text;
        }

        public void Add(Answer answer)
        {
            possibleAnswer.Add(answer);
        }

        public Answer GetAnswer(int index)
        {
            return possibleAnswer[index-1];
        }

        public override string ToString()
        {
            return text;
        }
    }
}
