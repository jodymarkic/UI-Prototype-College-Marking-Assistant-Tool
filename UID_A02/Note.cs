using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UID_A02
{
    class Note
    {
        private string choosenCode;
        private string commentsAboutCode;
        private string lineStart;

        public string ChooseCode
        {
            get { return choosenCode; }
            set { choosenCode = value; }
        }

        public string CommentsAboutCode
        {
            get { return commentsAboutCode; }
            set { commentsAboutCode = value; }
        }

        public string LineStart
        {
            get { return lineStart; }
            set { lineStart = value; }
        }
    }
}
