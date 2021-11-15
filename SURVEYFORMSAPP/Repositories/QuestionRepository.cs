using SURVEYFORMSAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURVEYFORMSAPP.Repositories
{
    public class QuestionRepository : IRepository<SurveyQuestions>
    {
        private HashSet<SurveyQuestions> countries = new HashSet<SurveyQuestions>();
        public List<SurveyQuestions> GetData()
        {

            // Kısa cevaplı sorular
            var q1 = new SurveyQuestions(questionID: 1);
            q1.AddQuestion(new Models.Question(id: 1, text: "Adınızı girniz :", questionTypes: QuestonTypes.ShortAnswerQuestion));

            var q2 = new SurveyQuestions(questionID: 2);
            q2.AddQuestion(new Models.Question(id: 2, text: "E-posta giriniz :", questionTypes: QuestonTypes.ShortAnswerQuestion));

            // Paragraf cevaplı sorular
            var q3 = new SurveyQuestions(questionID: 3);
            q3.AddQuestion(new Models.Question(id: 3, text: "Notlarınızı yazınız : ", questionTypes: QuestonTypes.ParagraphAnswerQuestion));

            var q4 = new SurveyQuestions(questionID: 4);
            q4.AddQuestion(new Models.Question(id: 4, text: "Tavsiyelerinizi yazınız :", questionTypes: QuestonTypes.ParagraphAnswerQuestion));

            // Tarih formatlı sorular
            var q5 = new SurveyQuestions(questionID: 5);
            q5.AddQuestion(new Models.Question(id: 5, text: "Doğum tarihiniz nedir ?", questionTypes: QuestonTypes.DateFormatQuestion ));

            var q6 = new SurveyQuestions(questionID: 6);
            q6.AddQuestion(new Models.Question(id: 6, text: "Gezi hangi tarihte olsun ? ", questionTypes: QuestonTypes.DateFormatQuestion ));

            //Onay kutusu soruları
            var q7 = new SurveyQuestions(questionID: 7);
            q7.AddQuestion(new Models.Question(id: 7, text: "Nereye gidilsin ?" , questionTypes: QuestonTypes.CheckboxQuestion));

            var q8 = new SurveyQuestions(questionID: 8);
            q8.AddQuestion(new Models.Question(id: 8, text: "Hobileriniz neler ?", questionTypes: QuestonTypes.CheckboxQuestion));

            // Çoktan seçmeli sorular
            var q9 = new SurveyQuestions(questionID: 9);
            q9.AddQuestion(new Models.Question(id: 9, text: "Nereden katılıyorsunuz ?", questionTypes: QuestonTypes.MultipleChoiceQuestion));

            var q10 = new SurveyQuestions(questionID: 10);
            q10.AddQuestion(new Models.Question(id: 10, text: "Geziye haftanın hangi gününde gidilsin ?", questionTypes: QuestonTypes.MultipleChoiceQuestion));

            // evet-hayır cevaplı sorular
            var q11 = new SurveyQuestions(questionID: 11);
            q11.AddQuestion(new Models.Question(id: 11, text: "Evli misiniz ?", questionTypes: QuestonTypes.YesOrNoQuestion));

            var q12 = new SurveyQuestions(questionID: 12);
            q12.AddQuestion(new Models.Question(id: 12, text: "Tek mi katılacaksınız ?" , questionTypes: QuestonTypes.YesOrNoQuestion));

            














            throw new NotImplementedException();
        }
    }
}
