using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURVEYFORMSAPP.Models
{
    public class Survey
    {
        
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; } // Anket oluşturulma tarihi


        public Survey(string title, string description, DateTime createdDate)
        {
            Title = title;
            Description = description;
            CreatedDate = createdDate;
        }

    }
}
