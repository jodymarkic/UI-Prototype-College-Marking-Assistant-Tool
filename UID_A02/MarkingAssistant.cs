using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace UID_A02
{
    public partial class TabOne : Form
    {
        private enum MyTabs { TabOne = 0, TabTwo, TabThree, TabFour, TabFive };

        private bool[] validatingLoadCompileRun = { false, false, false };
        private bool[] validatingPlagirism = { false, false };

        private int previousIndex;
        private bool incompletePage = false;

        private Report myReport = new Report();


        public TabOne()
        {
            // TabController.Paint += tabpage_Paint;
            InitializeComponent();

            Directory.CreateDirectory("Assignment Reports");

            Point myTextboxLocation = searchProjectTextbox.Location;
            Size mySize = searchProjectTextbox.Size;


            TabController.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabController.DrawItem += new DrawItemEventHandler(this.tabController_DrawItem);
        }

        private void SetTabHeader(TabPage page, Color color)
        {
            //TabController.TabePages[e]
        }

        // force the tab background to the current BackColor

        private void tabController_DrawItem(object sender, DrawItemEventArgs e)
        {
            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(
               fontFamily,
               11,
               FontStyle.Regular,
               GraphicsUnit.Point);



            if (e.Index == TabController.SelectedIndex)
            {
                Rectangle tabBuffer = TabController.GetTabRect(e.Index);
                //Rectangle lasttabrect = tabControl1.GetTabRect(tabControl1.TabPages.Count - 1);
                //tabBuffer.X = tabBuffer.X + 424;
                Brush tabBrush = Brushes.PowderBlue; // the color you want
                e.Graphics.FillRectangle(tabBrush, tabBuffer);

                Rectangle emptyTab = TabController.GetTabRect(TabController.TabPages.Count - 1);
                Rectangle emptyTabSpace = new Rectangle(
                        emptyTab.X + emptyTab.Width,
                        emptyTab.Y - 2,
                        TabController.Width - (emptyTab.X + emptyTab.Width),
                        emptyTab.Height);
                tabBrush = Brushes.Transparent;
                e.Graphics.FillRectangle(tabBrush, emptyTabSpace);

                Rectangle paddedBounds = e.Bounds;

                TabController.TabPages[e.Index].Padding = new Padding(3, 3, 3, 25);

                paddedBounds.Inflate(-2, -2);
                e.Graphics.DrawString(TabController.TabPages[e.Index].Text, font, SystemBrushes.ControlText, paddedBounds);
            }
            else
            {
                Rectangle tabBuffer = TabController.GetTabRect(e.Index);
                //Rectangle lasttabrect = tabControl1.GetTabRect(tabControl1.TabPages.Count - 1);
                //tabBuffer.X = tabBuffer.X + 424;
                Brush tabBrush = Brushes.Transparent; // the color you want
                e.Graphics.FillRectangle(tabBrush, tabBuffer);

                Rectangle paddedBounds = e.Bounds;
                paddedBounds.Inflate(-2, -2);
                // TabController.TabPages[e.Index].Text.PadLeft(20);
                e.Graphics.DrawString(TabController.TabPages[e.Index].Text, font, SystemBrushes.ControlText, paddedBounds);
            }
        }

        private void tabController_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabController.SelectedIndex)
            {
                case (int)MyTabs.TabOne:
                    //TabController.Sele
                    backButton.Enabled = false;
                    subtitleLabel.Text = "Find a Project";
                    myProgressBar.Value = 0;
                    break;
                case (int)MyTabs.TabTwo:
                    subtitleLabel.Text = "Edit, Compile, and Run";
                    myProgressBar.Value = 20;
                    break;
                case (int)MyTabs.TabThree:
                    subtitleLabel.Text = "Percentage of Code Comments";

                    myProgressBar.Value = 40;
                    break;
                case (int)MyTabs.TabFour:
                    subtitleLabel.Text = "Check for Plagiarism";
                    myProgressBar.Value = 60;
                    break;
                case (int)MyTabs.TabFive:
                    subtitleLabel.Text = "Provide Feedback";
                    myProgressBar.Value = 80;
                    nextButton.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //pathingValid = false;
            OpenFileDialog myFileDialog = new OpenFileDialog();
            if (myFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = myFileDialog.FileName;

                if (filepath.Contains(".sln"))
                {
                    //pathingValid = true;
                    //pathingCheckLabel.Font.Bold = Font.Bold;
                    pathingCheckLabel.ForeColor = Color.Green;
                    pathingCheckLabel.Text = "Visual Studio Project, Confirmed!";
                    badPathingLabel.Text = "";


                    int index = filepath.LastIndexOf(@"\");
                    string filename = filepath.Substring(index + 1);

                    searchProjectTextbox.Text = filename;
                    myReport.ProjectName = searchProjectTextbox.Text;
                }
                else
                {
                    badPathingLabel.ForeColor = Color.Red;
                    badPathingLabel.Text = "Incorrect file type, please provide a .sln file!";
                    pathingCheckLabel.Text = "";
                }
            }
        }

        private void projectLoadButton_Click(object sender, EventArgs e)
        {


            if (validatingLoadCompileRun[0])
            {
                validatingLoadCompileRun[0] = false;
                projectLoadButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");
                projectLoadButton.BackgroundImage.Tag = "xMark.png";
            }
            else
            {
                validatingLoadCompileRun[0] = true;
                projectLoadButton.BackgroundImage = Image.FromFile("../../Resources/yMark.png");
                projectLoadButton.BackgroundImage.Tag = "yMark.png";
            }
        }

        private void projectCompileButton_Click(object sender, EventArgs e)
        {
            if (validatingLoadCompileRun[1])
            {
                validatingLoadCompileRun[1] = false;
                projectCompileButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");
                projectCompileButton.BackgroundImage.Tag = "xMark.png";
            }
            else
            {
                validatingLoadCompileRun[1] = true;
                projectCompileButton.BackgroundImage = Image.FromFile("../../Resources/yMark.png");
                projectCompileButton.BackgroundImage.Tag = "yMark.png";
            }
        }

        private void projectRunButton_Click(object sender, EventArgs e)
        {
            if (validatingLoadCompileRun[2])
            {
                validatingLoadCompileRun[2] = false;
                projectRunButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");
                projectRunButton.BackgroundImage.Tag = "xMark.png";
            }
            else
            {
                validatingLoadCompileRun[2] = true;
                projectRunButton.BackgroundImage = Image.FromFile("../../Resources/yMark.png");
                projectRunButton.BackgroundImage.Tag = "yMark.png";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int commentingPercent = 0;
            int totalPercent = 0;
            int percent = 0;

            OpenFileDialog myFileDialog = new OpenFileDialog();
            if (myFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = myFileDialog.FileName;

               // if (filepath.Contains(".cs") || filepath.Contains(".cpp") || filepath.Contains(".c") || filepath.Contains(".h") || filepath.Contains(".xml"))
               // {
                    //pathingValid = true;
                    //pathingCheckLabel.Font.Bold = Font.Bold;
                    int index = filepath.LastIndexOf(@"\");
                    string filename = filepath.Substring(index + 1);
                    fileListbox.Items.Add(filename);


                    commentingPercent = random.Next(0, 50);

                    string percentage = commentingPercent.ToString() + " %";
                    percentageListbox.Items.Add(percentage);

                    int currentItems = percentageListbox.Items.Count;
                    for (int i = 0; i < currentItems; i++)
                    {
                        string itemBuffer = percentageListbox.Items[i].ToString();
                        itemBuffer = itemBuffer.Remove(itemBuffer.Length - 1);
                        totalPercent += Int32.Parse(itemBuffer);
                    }



                    // totalPercent += commentingPercent;
                    percent = totalPercent / percentageListbox.Items.Count;

                    resultsPercentLabel.Text = percent.ToString(".00") + "%";

                    if (percent > 20)
                    {
                        resultsPercentLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        resultsPercentLabel.ForeColor = Color.Red;
                    }

               // }
              //  else
              //  {
              //      string message = "Provide sources files to evaluate comment coverage!\n" +
              //                       "File types supported are .cs, .cpp, .c, .h, and .xml";
              //      string caption = "Incorrect File Type!";
               //     MessageBoxButtons buttons = MessageBoxButtons.OK;
               //     DialogResult result;

                    // Displays the MessageBox.

               ///     result = MessageBox.Show(this, message, caption, buttons,
               //         MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
               //         MessageBoxOptions.RightAlign);
              //  }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int totalPercent = 0;
            double percent = 0;
            int deleteIndex = fileListbox.SelectedIndex;
            fileListbox.Items.RemoveAt(deleteIndex);
            percentageListbox.Items.RemoveAt(deleteIndex);

            int currentItems = percentageListbox.Items.Count;
            for (int i = 0; i < currentItems; i++)
            {
                string itemBuffer = percentageListbox.Items[i].ToString();
                itemBuffer = itemBuffer.Remove(itemBuffer.Length - 1);
                totalPercent += Int32.Parse(itemBuffer);
            }

            if (percentageListbox.Items.Count != 0)
            {
                percent = totalPercent / percentageListbox.Items.Count;
            }
            else
            {
                percent = 0;
            }

            resultsPercentLabel.Text = percent.ToString(".00") + "%";

            if (percent > 20)
            {
                resultsPercentLabel.ForeColor = Color.Green;
            }
            else
            {
                resultsPercentLabel.ForeColor = Color.Red;
            }

            totalPercent = 0;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            bool processStarted = false;

            Process[] processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.MainWindowTitle.Equals("Google - Google Chrome", StringComparison.OrdinalIgnoreCase))
                {
                    processStarted = true;
                    break;
                }
            }

            if (!processStarted)
            {
                Process p = new Process();
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "chrome.exe";
                p.StartInfo = info;

                string buffer = sourceCodeValidateTextbox.Text;

                Regex trimmer = new Regex(@"\s\s+");

                buffer = trimmer.Replace(buffer, " ");

                buffer = buffer.Replace(' ', '+');

                info.Arguments = "https://www.google.ca/search?q=stackoverflow+" + buffer;
                p.Start();
            }
        }

        private void plagurizeButton_Click(object sender, EventArgs e)
        {
            if (validatingPlagirism[0]) //need to change
            {
                validatingPlagirism[0] = false; //need to change
                plagurizeButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");
            }
            else
            {
                validatingPlagirism[0] = true; //need to change
                plagurizeButton.BackgroundImage = Image.FromFile("../../Resources/yMark.png");
            }
        }

        private void citedButton_Click(object sender, EventArgs e)
        {

            if (validatingPlagirism[1]) //need to change
            {
                validatingPlagirism[1] = false; //need to change
                citedButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");
            }
            else
            {
                validatingPlagirism[1] = true; //need to change
                citedButton.BackgroundImage = Image.FromFile("../../Resources/yMark.png");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //take code, booleans, and textbox data and place into report
            PlagurismNote myNote = new PlagurismNote();
            myNote.CodeInQuestion = sourceCodeValidateTextbox.Text;
            myNote.WasPlagurized = validatingPlagirism[0];
            myNote.SourceCreditied = validatingPlagirism[1];
            myNote.OriginalWebsite = originalSourceTextbox.Text;
            myNote.OriginalWebsite = originalAuthorTextbox.Text;

            myReport.PlagurisedNotes.Add(myNote);

            MessageBox.Show("Entry Saved Successfully!");

            sourceCodeValidateTextbox.Text = "Provide Source Code to Authenticate Here...";
            plagurizeButton.BackgroundImage = Image.FromFile("../../Resources/qMark.png");
            citedButton.BackgroundImage = Image.FromFile("../../Resources/qMark.png");

            originalSourceTextbox.Text = "";
            originalAuthorTextbox.Text = "";

        }

        private void newEntryButton_Click(object sender, EventArgs e)
        {

            sourceCodeValidateTextbox.Text = "Provide Source Code to Authenticate Here...";
            plagurizeButton.BackgroundImage = Image.FromFile("../../Resources/qMark.png");
            citedButton.BackgroundImage = Image.FromFile("../../Resources/qMark.png");

            originalSourceTextbox.Text = "";
            originalAuthorTextbox.Text = "";

        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            sourceCodeLineTextbox.Text = "";
            NoteTextbox.Text = "Write a note about the source code provided in the adjacent textbox...";
            sourceCodeNoteTextbox.Text = "Add Source Code Related to Note...";
        }


        //NEED TO CHECK FOR ALOT OF THINGS
        private void nextButton_Click(object sender, EventArgs e)
        {
            int currentIndex = TabController.SelectedIndex;
            int tabCount = TabController.TabCount;

            TabController.SelectedIndex = currentIndex + 1;
        }

        private void tabTwoEvaluate()
        {
            if (validatingLoadCompileRun[0])
            {
                myReport.ProjectDidLoad = true;
            }
            else
            {
                myReport.ProjectDidLoad = false;
            }

            if (validatingLoadCompileRun[1])
            {
                myReport.ProjectDidCompile = true;
            }
            else
            {
                myReport.ProjectDidCompile = false;
            }

            if (validatingLoadCompileRun[2])
            {
                myReport.ProjectDidRun = true;
            }
            else
            {
                myReport.ProjectDidRun = false;
            }
        }

        private void tabThreeEvaluate()
        {
            int entryCount = fileListbox.Items.Count;

            for (int i = 0; i < entryCount; i++)
            {
                CommentingNote myNote = new CommentingNote();
                myNote.Filename = fileListbox.Items[i].ToString();
                myNote.CommentingPercentage = percentageListbox.Items[i].ToString();
                myReport.CommentingNotes.Add(myNote);
            }
            myReport.CumulativeCommentingCoverage = resultsPercentLabel.Text;
        }


        private void tabController_Deselected(object sender, TabControlEventArgs e)
        {
            switch (TabController.SelectedIndex)
            {
                case (int)MyTabs.TabOne:
                    //TabController.Sele
                    subtitleLabel.Text = "Find a Project";
                    myProgressBar.Value = 0;
                    myReport.ProjectOwner = projectOwnerNameTextbox.Text;
                    backButton.Enabled = true;
                    break;
                case (int)MyTabs.TabTwo:
                    // subtitleLabel.Text = "Edit, Compile, and Run";
                    // myProgressBar.Value = 20;
                    tabTwoEvaluate();
                    break;
                case (int)MyTabs.TabThree:
                    subtitleLabel.Text = "Percentage of Code Comments";

                    tabThreeEvaluate();

                    myProgressBar.Value = 40;
                    break;
                case (int)MyTabs.TabFour:
                    subtitleLabel.Text = "Check for Plagiarism";
                    myProgressBar.Value = 60;
                    break;
                case (int)MyTabs.TabFive:
                    subtitleLabel.Text = "Provide Feedback";
                    myProgressBar.Value = 80;

                    nextButton.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            Note myNote = new UID_A02.Note();

            myNote.ChooseCode = sourceCodeNoteTextbox.Text;
            myNote.CommentsAboutCode = NoteTextbox.Text;
            myNote.LineStart = sourceCodeLineTextbox.Text;

            myReport.SourceCodeNotes.Add(myNote);

            MessageBox.Show("Note Saved Successfully!");

            sourceCodeLineTextbox.Text = "";
            NoteTextbox.Text = "Write a note about the source code provided in the adjacent textbox...";
            sourceCodeNoteTextbox.Text = "Add Source Code Related to Note...";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            int currentIndex = TabController.SelectedIndex;

            TabController.SelectedIndex = currentIndex - 1;
        }

        private void resetUI()
        {
            badPathingLabel.Text = "";
            pathingCheckLabel.Text = "";

            //myReport.ProjectName = "";
            searchProjectTextbox.Text = "Select a project .sln file";
            // myProgressBar.Value = myProgressBar.Value - 20;

           // myReport.ProjectOwner = " ";
            projectOwnerNameTextbox.Text = "John Doe";

            validatingLoadCompileRun[0] = false;
            projectLoadButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

            validatingLoadCompileRun[1] = false;
            projectCompileButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

            validatingLoadCompileRun[2] = false;
            projectRunButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

            myReport.ProjectDidLoad = null;
            myReport.ProjectDidCompile = null;
            myReport.ProjectDidRun = null;

            fileListbox.Items.Clear();
            percentageListbox.Items.Clear();

            resultsPercentLabel.ForeColor = Color.Black;
            resultsPercentLabel.Text = "0%";

            sourceCodeValidateTextbox.Text = "Provide Source Code to Authenticate Here...";

            validatingPlagirism[0] = false;
            validatingPlagirism[1] = false;

            plagurizeButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");
            citedButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

            originalSourceTextbox.Text = "";

            originalAuthorTextbox.Text = "";

            sourceCodeNoteTextbox.Text = "Add Source Code Related to Note...";
            NoteTextbox.Text = "Write a note about the source code provided in the adjacent textbox...";

            sourceCodeLineTextbox.Text = "";

            TabController.SelectedIndex = 0;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            switch (TabController.SelectedIndex)
            {
                case (int)MyTabs.TabOne:
                    //TabController.Sele
                    //subtitleLabel.Text = "Find a Project";

                    badPathingLabel.Text = "";
                    pathingCheckLabel.Text = "";

                    myReport.ProjectName = "";
                    searchProjectTextbox.Text = "Select a project .sln file";
                    // myProgressBar.Value = myProgressBar.Value - 20;


                    myReport.ProjectOwner = " ";
                    projectOwnerNameTextbox.Text = "John Doe";
                   // backButton.Enabled = true;

                    MessageBox.Show("Changes made in tab reset.");

                    break;
                case (int)MyTabs.TabTwo:
                    // subtitleLabel.Text = "Edit, Compile, and Run";
                    // myProgressBar.Value = 20;
                    validatingLoadCompileRun[0] = false;
                    projectLoadButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

                    validatingLoadCompileRun[1] = false;
                    projectCompileButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

                    validatingLoadCompileRun[2] = false;
                    projectRunButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

                    myReport.ProjectDidLoad = null;
                    myReport.ProjectDidCompile = null;
                    myReport.ProjectDidRun = null;

                    MessageBox.Show("Changes made in tab reset.");

                    //tabTwoEvaluate();
                    break;
                case (int)MyTabs.TabThree:

                    fileListbox.Items.Clear();
                    percentageListbox.Items.Clear();

                    resultsPercentLabel.ForeColor = Color.Black;
                    resultsPercentLabel.Text = "0%";

                    MessageBox.Show("Changes made in tab reset.");
                    break;
                case (int)MyTabs.TabFour:

                    sourceCodeValidateTextbox.Text = "Provide Source Code to Authenticate Here...";

                    validatingPlagirism[0] = false;
                    validatingPlagirism[1] = false;

                    plagurizeButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");
                    citedButton.BackgroundImage = Image.FromFile("../../Resources/xMark.png");

                    originalSourceTextbox.Text = "";

                    originalAuthorTextbox.Text = "";

                    break;
                case (int)MyTabs.TabFive:
                    sourceCodeNoteTextbox.Text = "Add Source Code Related to Note...";
                    NoteTextbox.Text = "Write a note about the source code provided in the adjacent textbox...";

                    sourceCodeLineTextbox.Text = "";

                    MessageBox.Show("Changes made in tab reset.");
                    break;
                default:
                    break;
            }
        }

        private void generateReport()
        {
            //myReport.ProjectN
            string filename;
            int dotIndex = myReport.ProjectName.IndexOf('.');
            string projectOwner = myReport.ProjectOwner;
            string projectName = myReport.ProjectName.Remove(dotIndex);
            string yesOrNo;
            projectOwner = projectOwner.Replace(' ', '_');

            filename = projectName + "_" + projectOwner;

            //string path = ".";
            if (!File.Exists("Assignment Reports\\" + filename + ".txt"))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText("Assignment Reports\\" + filename + ".txt"))
                {
                    //Project Name
                    sw.WriteLine("Project Name:\n\n");
                    sw.WriteLine("\t" + myReport.ProjectName + "\n\n");

                    //Project Owner
                    sw.WriteLine("Project Owner:\n\n");
                    sw.WriteLine("\t" + myReport.ProjectOwner + "\n\n");

                    //Load
                    sw.WriteLine("Project Loads:\n\n");
                    if (myReport.ProjectDidLoad == true)
                    {
                        yesOrNo = "yes";
                    }
                    else
                    {
                        yesOrNo = "no";
                    }
                    sw.WriteLine("\ty\\n? : " + yesOrNo + "\n\n");

                    //Compile
                    sw.WriteLine("Project Compiles:\n\n");
                    if (myReport.ProjectDidCompile == true)
                    {
                        yesOrNo = "yes";
                    }
                    else
                    {
                        yesOrNo = "no";
                    }
                    sw.WriteLine("\ty\\n? : " + yesOrNo + "\n\n");

                    //Run
                    sw.WriteLine("Project Runs:\n\n");
                    if (myReport.ProjectDidRun == true)
                    {
                        yesOrNo = "yes";
                    }
                    else
                    {
                        yesOrNo = "no";
                    }
                    sw.WriteLine("\ty\\n? : " + yesOrNo + "\n\n");

                    sw.WriteLine("Commenting Coverage:\n\n");

                    sw.WriteLine("  Cumulative Coverage: " + myReport.CumulativeCommentingCoverage + "\n\n");
                    
                    sw.WriteLine("\tIndividual Files Commenting Coverage:\n\n");

                    for (int i = 0; i < myReport.CommentingNotes.Count; i++)
                    {
                        sw.WriteLine("\tfilename: " + myReport.CommentingNotes[i].Filename + "\t\tpercent: " + myReport.CommentingNotes[i].CommentingPercentage + "\n");
                    }

                    sw.WriteLine("Plagurism Report:\n\n");
                    if (myReport.PlagurisedNotes.Count <= 0)
                    {
                        sw.WriteLine("\tN\\A\n\n");
                    }
                    else
                    {
                        for (int i = 0; i < myReport.PlagurisedNotes.Count; i++)
                        {
                            sw.WriteLine("\tPossibly Plagurized Code:\n\n");
                            sw.WriteLine("\t" + myReport.PlagurisedNotes[i].CodeInQuestion + "\n\n");
                            sw.WriteLine("\t Was It Plagurized? :");
                            if (myReport.PlagurisedNotes[i].WasPlagurized == true)
                            {
                                yesOrNo = "yes";
                            }
                            else
                            {
                                yesOrNo = "no";
                            }
                            sw.WriteLine("\ty\\n? : " + yesOrNo + "\n\n");
                            if (myReport.PlagurisedNotes[i].SourceCreditied == true)
                            {
                                yesOrNo = "yes";
                            }
                            else
                            {
                                yesOrNo = "no";
                            }
                            sw.WriteLine("\ty\\n? : " + yesOrNo + "\n\n");
                            sw.WriteLine("\tWebsite code was found:\n\n");
                            sw.WriteLine("\t" + myReport.PlagurisedNotes[i].OriginalWebsite);
                            sw.WriteLine("\tOriginal Author:\n\n");
                            sw.WriteLine("\t" + myReport.PlagurisedNotes[i].OriginalAuthor + "\n\n\n");

                        }
                    }

                    sw.WriteLine("Teachers Notes:\n\n");

                    if (myReport.SourceCodeNotes.Count <= 0)
                    {
                        sw.WriteLine("\tN\\A\n\n");
                    }
                    else
                    {
                        for (int i = 0; i < myReport.SourceCodeNotes.Count; i++)
                        {
                            sw.WriteLine("\tCode Section To Note:\n\n");
                            sw.WriteLine("\t" + myReport.SourceCodeNotes[i].ChooseCode);
                            sw.WriteLine("\t Code starts on line:\n\n");
                            sw.WriteLine("\t" + myReport.SourceCodeNotes[i].LineStart + "\n\n");
                            sw.WriteLine("\tProfessor Comment:\n\n");
                            sw.WriteLine("\t" + myReport.SourceCodeNotes[i].CommentsAboutCode + "\n\n\n");
                        }
                    }
                }
            }

        }


        private void finishButton_Click(object sender, EventArgs e)
        {
            myProgressBar.Value = 100;
            if (myReport.ProjectName != null && myReport.ProjectOwner != null)
            {

                DialogResult dialogResult = MessageBox.Show("Generate a Report?", "Report Generator", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    generateReport();
                    //do something
                    MessageBox.Show("Report Successfully Generated! All Reports can be found in the 'Assignment Reports' folder relative to where Marking Assistant can be found.");

                    //code for a reset.
                    myReport = new Report();

                    //reset UI
                    resetUI();
                }
                else if (dialogResult == DialogResult.No)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Reset Marking Assistant?", "Reset", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        //reset 
                        myReport = new Report();
                        resetUI();
                        //reset UI
                    }
                    else
                    {
                        myProgressBar.Value = 80;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please ensure a project and project owner is provided before proceeding!");
            }
        }
    }
}
