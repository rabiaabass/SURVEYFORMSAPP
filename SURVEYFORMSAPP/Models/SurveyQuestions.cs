using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURVEYFORMSAPP.Models
{
    public class SurveyQuestions
    {
        /// <summary>
        /// Soru ile soru tipini karşılaştırabilmek için soruya id tanımlandı
        /// </summary>
        public int QuestionID { get; set; }

        // HashSet ile çalışıldığı için IReadOnlySet interface kullanıldı.
        public IReadOnlySet<Question> Questions => questions;

        // Aynı soru eklenmemesi için HashSet kullanıldı.

        private HashSet<Question> questions = new HashSet<Question>();

        // HashSet ile çalışıldığı için IReadOnlySet interface kullanıldı.
        public IReadOnlySet<Option> Options => options;

        //Aynı seçenek eklenilmemesi için HashSet kullanıldı.
        private HashSet<Option> options = new HashSet<Option>();

        public SurveyQuestions(int questionID)
        {
            QuestionID = questionID;
        }

        /// <summary>
        /// Ankete soru ekleme methodu
        /// </summary>
        /// <param name="question"></param>
        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }
        

        /// <summary>
        /// Anketteki sorulara seçenek ekleemek için kullanıldı.
        /// </summary>
        /// <param name="option"></param>
        public void AddOptions(Option option)
        {
            options.Add(option);
        }
    }
}
