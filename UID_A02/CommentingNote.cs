using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UID_A02
{
    class CommentingNote
    {
        private string filename;
        private string commentingPercentage;

        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }

        public string CommentingPercentage
        {
            get { return commentingPercentage; }
            set { commentingPercentage = value; }
        }
    }
}
