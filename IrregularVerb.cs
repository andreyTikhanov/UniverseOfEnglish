using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myEnglish_with_Button
{
    public class IrregularVerb
    {
        public string BaseForm { get; set; }
        public string PastSimple { get; set; }
        public string PastParticiple {  get; set; }
        public string Translation { get; set; }

        public IrregularVerb(string baseForm, string pastForm, string participleForm, string translation )
        {
            this.BaseForm = baseForm;
            this.PastSimple = pastForm;
            this.PastParticiple = participleForm;
            this.Translation = translation;
        }
        public IrregularVerb() { }
    }
}
