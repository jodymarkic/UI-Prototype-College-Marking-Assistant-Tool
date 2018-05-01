using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UID_A02
{
    class PlagurismNote
    {
        private string codeInQuestion;
        private bool? wasPlagurized;
        private bool? sourceCreditied;
        private string originalWebsite;
        private string originalAuthor;

        public string CodeInQuestion
        {
            get { return codeInQuestion; }
            set { codeInQuestion = value; }
        }

        public bool? WasPlagurized
        {
            get { return wasPlagurized; }
            set { wasPlagurized = value; }
        }

        public bool? SourceCreditied
        {
            get { return sourceCreditied; }
            set { sourceCreditied = value; }
        }

        public string OriginalWebsite
        {
            get { return originalWebsite; }
            set { originalWebsite = value; }
        }

        public string OriginalAuthor
        {
            get { return originalAuthor; }
            set { originalAuthor = value; }
        }
    }
}
