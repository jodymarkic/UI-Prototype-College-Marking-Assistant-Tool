using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UID_A02
{
    class Report
    {
        private List<CommentingNote> commentingNotes = new List<CommentingNote>();
        private List<PlagurismNote> plagurisedNotes = new List<PlagurismNote>();
        private List<Note> sourceCodeNotes = new List<Note>();
        private string projectName;
        private string projectOwner;
        private bool? projectDidLoad;
        private bool? projectDidCompile;
        private bool? projectDidRun;
        private string cumulativeCommentingCoverage;

        public bool? ProjectDidRun
        {
            get { return projectDidRun; }
            set { projectDidRun = value; }
        }


        public List<CommentingNote> CommentingNotes
        { 
            get { return commentingNotes; }
            set { commentingNotes = value; }
        }

        public List<PlagurismNote> PlagurisedNotes
        {
            get { return plagurisedNotes; }
            set { plagurisedNotes = value; }
        }

        public List<Note> SourceCodeNotes
        {
            get { return sourceCodeNotes; }
            set { sourceCodeNotes = value; }
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public string ProjectOwner
        {
            get { return projectOwner; }
            set { projectOwner = value; }
        }

        public bool? ProjectDidLoad
        {
            get { return projectDidLoad; }
            set { projectDidLoad = value; }
        }

        public bool? ProjectDidCompile
        {
            get { return projectDidCompile; }
            set { projectDidCompile = value; }
        }

        public string CumulativeCommentingCoverage
        {
            get { return cumulativeCommentingCoverage; }
            set { cumulativeCommentingCoverage = value; }
        }
    }
}
