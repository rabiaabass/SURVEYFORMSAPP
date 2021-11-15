using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURVEYFORMSAPP.Models
{

    public enum OptionType
    {

    }
    public class Option
    {
        public OptionType OptionType { get; set; }


        public Option(OptionType optionType)
        {
            this.OptionType = optionType;
        }

    }
}
