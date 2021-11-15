using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURVEYFORMSAPP.Models
{

    public enum QuestonTypes
    {
        ShortAnswerQuestion,
        ParagraphAnswerQuestion,
        YesOrNoQuestion,
        MultipleChoiceQuestion,
        CheckboxQuestion,
        DateFormatQuestion,
    }

    public class Question
    {
        

        public int ID { get; set; }

        public string Text { get; set; }

        public QuestonTypes QuestionTypes { get; set; }



        public Question(int id, string text, QuestonTypes questionTypes)
        {
            this.ID = id;
            this.Text = text;
            this.QuestionTypes = questionTypes;

        }

        

    }
}
