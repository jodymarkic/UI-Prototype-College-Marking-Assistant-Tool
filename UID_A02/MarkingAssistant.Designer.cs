namespace UID_A02
{
    partial class TabOne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabOne));
            this.TabController = new System.Windows.Forms.TabControl();
            this.findProjectPage = new System.Windows.Forms.TabPage();
            this.projectOwnerNameTextbox = new System.Windows.Forms.TextBox();
            this.programmerNameLabel = new System.Windows.Forms.Label();
            this.badPathingLabel = new System.Windows.Forms.Label();
            this.pathingCheckLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.searchProjectTextbox = new System.Windows.Forms.TextBox();
            this.searchProjectLabel = new System.Windows.Forms.Label();
            this.loadCompilePage = new System.Windows.Forms.TabPage();
            this.projectRunButton = new System.Windows.Forms.Button();
            this.projectCompileButton = new System.Windows.Forms.Button();
            this.projectRunLabel = new System.Windows.Forms.Label();
            this.projectCompileLabel = new System.Windows.Forms.Label();
            this.projectLoadLabel = new System.Windows.Forms.Label();
            this.projectLoadButton = new System.Windows.Forms.Button();
            this.commentsPage = new System.Windows.Forms.TabPage();
            this.resultsPercentLabel = new System.Windows.Forms.Label();
            this.resultLabelTwo = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileListLabel = new System.Windows.Forms.Label();
            this.resultsLabelOne = new System.Windows.Forms.Label();
            this.percentageListbox = new System.Windows.Forms.ListBox();
            this.fileListbox = new System.Windows.Forms.ListBox();
            this.authenticityPage = new System.Windows.Forms.TabPage();
            this.originalAuthorTextbox = new System.Windows.Forms.TextBox();
            this.originalSourceAuthorLabel = new System.Windows.Forms.Label();
            this.originalSourceTextbox = new System.Windows.Forms.TextBox();
            this.originalSourceWebsite = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.addCodeLabel = new System.Windows.Forms.Label();
            this.citedButton = new System.Windows.Forms.Button();
            this.sourceCitedLabel = new System.Windows.Forms.Label();
            this.plagurizeButton = new System.Windows.Forms.Button();
            this.plagerizedLabel = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.sourceCodeValidateTextbox = new System.Windows.Forms.TextBox();
            this.feedbackPage = new System.Windows.Forms.TabPage();
            this.noteLabel = new System.Windows.Forms.Label();
            this.NoteTextbox = new System.Windows.Forms.TextBox();
            this.sourceCodeLineTextbox = new System.Windows.Forms.TextBox();
            this.sourceCodeLineLabel = new System.Windows.Forms.Label();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sourceCodeNoteTextbox = new System.Windows.Forms.TextBox();
            this.myProgressBar = new System.Windows.Forms.ProgressBar();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.TabController.SuspendLayout();
            this.findProjectPage.SuspendLayout();
            this.loadCompilePage.SuspendLayout();
            this.commentsPage.SuspendLayout();
            this.authenticityPage.SuspendLayout();
            this.feedbackPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.findProjectPage);
            this.TabController.Controls.Add(this.loadCompilePage);
            this.TabController.Controls.Add(this.commentsPage);
            this.TabController.Controls.Add(this.authenticityPage);
            this.TabController.Controls.Add(this.feedbackPage);
            this.TabController.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabController.ItemSize = new System.Drawing.Size(85, 30);
            this.TabController.Location = new System.Drawing.Point(16, 73);
            this.TabController.Margin = new System.Windows.Forms.Padding(0);
            this.TabController.Multiline = true;
            this.TabController.Name = "TabController";
            this.TabController.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(963, 516);
            this.TabController.TabIndex = 0;
            this.TabController.SelectedIndexChanged += new System.EventHandler(this.tabController_SelectedIndexChanged);
            this.TabController.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabController_Deselected);
            // 
            // findProjectPage
            // 
            this.findProjectPage.BackColor = System.Drawing.Color.PowderBlue;
            this.findProjectPage.Controls.Add(this.projectOwnerNameTextbox);
            this.findProjectPage.Controls.Add(this.programmerNameLabel);
            this.findProjectPage.Controls.Add(this.badPathingLabel);
            this.findProjectPage.Controls.Add(this.pathingCheckLabel);
            this.findProjectPage.Controls.Add(this.browseButton);
            this.findProjectPage.Controls.Add(this.searchProjectTextbox);
            this.findProjectPage.Controls.Add(this.searchProjectLabel);
            this.findProjectPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findProjectPage.Location = new System.Drawing.Point(4, 34);
            this.findProjectPage.Margin = new System.Windows.Forms.Padding(0);
            this.findProjectPage.Name = "findProjectPage";
            this.findProjectPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.findProjectPage.Size = new System.Drawing.Size(955, 478);
            this.findProjectPage.TabIndex = 0;
            this.findProjectPage.Text = "Find Project";
            // 
            // projectOwnerNameTextbox
            // 
            this.projectOwnerNameTextbox.Location = new System.Drawing.Point(376, 239);
            this.projectOwnerNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.projectOwnerNameTextbox.Name = "projectOwnerNameTextbox";
            this.projectOwnerNameTextbox.Size = new System.Drawing.Size(327, 30);
            this.projectOwnerNameTextbox.TabIndex = 9;
            this.projectOwnerNameTextbox.Text = "John Doe";
            // 
            // programmerNameLabel
            // 
            this.programmerNameLabel.AutoSize = true;
            this.programmerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmerNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.programmerNameLabel.Location = new System.Drawing.Point(75, 236);
            this.programmerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.programmerNameLabel.Name = "programmerNameLabel";
            this.programmerNameLabel.Size = new System.Drawing.Size(280, 31);
            this.programmerNameLabel.TabIndex = 8;
            this.programmerNameLabel.Text = "Project Owner Name :";
            // 
            // badPathingLabel
            // 
            this.badPathingLabel.AutoSize = true;
            this.badPathingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badPathingLabel.Location = new System.Drawing.Point(227, 73);
            this.badPathingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.badPathingLabel.Name = "badPathingLabel";
            this.badPathingLabel.Size = new System.Drawing.Size(0, 25);
            this.badPathingLabel.TabIndex = 6;
            // 
            // pathingCheckLabel
            // 
            this.pathingCheckLabel.AutoSize = true;
            this.pathingCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathingCheckLabel.Location = new System.Drawing.Point(287, 73);
            this.pathingCheckLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathingCheckLabel.Name = "pathingCheckLabel";
            this.pathingCheckLabel.Size = new System.Drawing.Size(0, 25);
            this.pathingCheckLabel.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(712, 190);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(115, 32);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // searchProjectTextbox
            // 
            this.searchProjectTextbox.Location = new System.Drawing.Point(376, 190);
            this.searchProjectTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchProjectTextbox.Name = "searchProjectTextbox";
            this.searchProjectTextbox.Size = new System.Drawing.Size(327, 30);
            this.searchProjectTextbox.TabIndex = 3;
            this.searchProjectTextbox.Text = "Select a project .sln file";
            // 
            // searchProjectLabel
            // 
            this.searchProjectLabel.AutoSize = true;
            this.searchProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchProjectLabel.Location = new System.Drawing.Point(84, 185);
            this.searchProjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchProjectLabel.Name = "searchProjectLabel";
            this.searchProjectLabel.Size = new System.Drawing.Size(268, 31);
            this.searchProjectLabel.TabIndex = 2;
            this.searchProjectLabel.Text = "Search for a Project :";
            // 
            // loadCompilePage
            // 
            this.loadCompilePage.BackColor = System.Drawing.Color.PowderBlue;
            this.loadCompilePage.Controls.Add(this.projectRunButton);
            this.loadCompilePage.Controls.Add(this.projectCompileButton);
            this.loadCompilePage.Controls.Add(this.projectRunLabel);
            this.loadCompilePage.Controls.Add(this.projectCompileLabel);
            this.loadCompilePage.Controls.Add(this.projectLoadLabel);
            this.loadCompilePage.Controls.Add(this.projectLoadButton);
            this.loadCompilePage.Location = new System.Drawing.Point(4, 34);
            this.loadCompilePage.Margin = new System.Windows.Forms.Padding(4);
            this.loadCompilePage.Name = "loadCompilePage";
            this.loadCompilePage.Padding = new System.Windows.Forms.Padding(4);
            this.loadCompilePage.Size = new System.Drawing.Size(955, 478);
            this.loadCompilePage.TabIndex = 1;
            this.loadCompilePage.Text = "Load & Compile";
            // 
            // projectRunButton
            // 
            this.projectRunButton.BackgroundImage = global::UID_A02.Properties.Resources.xMark;
            this.projectRunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectRunButton.Location = new System.Drawing.Point(565, 276);
            this.projectRunButton.Margin = new System.Windows.Forms.Padding(4);
            this.projectRunButton.Name = "projectRunButton";
            this.projectRunButton.Size = new System.Drawing.Size(72, 60);
            this.projectRunButton.TabIndex = 7;
            this.projectRunButton.Tag = "qMark.png";
            this.projectRunButton.UseVisualStyleBackColor = true;
            this.projectRunButton.Click += new System.EventHandler(this.projectRunButton_Click);
            // 
            // projectCompileButton
            // 
            this.projectCompileButton.BackgroundImage = global::UID_A02.Properties.Resources.xMark;
            this.projectCompileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectCompileButton.Location = new System.Drawing.Point(565, 194);
            this.projectCompileButton.Margin = new System.Windows.Forms.Padding(4);
            this.projectCompileButton.Name = "projectCompileButton";
            this.projectCompileButton.Size = new System.Drawing.Size(72, 60);
            this.projectCompileButton.TabIndex = 6;
            this.projectCompileButton.Tag = "qMark.png";
            this.projectCompileButton.UseVisualStyleBackColor = true;
            this.projectCompileButton.Click += new System.EventHandler(this.projectCompileButton_Click);
            // 
            // projectRunLabel
            // 
            this.projectRunLabel.AutoSize = true;
            this.projectRunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectRunLabel.Location = new System.Drawing.Point(268, 293);
            this.projectRunLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectRunLabel.Name = "projectRunLabel";
            this.projectRunLabel.Size = new System.Drawing.Size(264, 31);
            this.projectRunLabel.TabIndex = 2;
            this.projectRunLabel.Text = "Did the Project Run?";
            // 
            // projectCompileLabel
            // 
            this.projectCompileLabel.AutoSize = true;
            this.projectCompileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCompileLabel.Location = new System.Drawing.Point(219, 212);
            this.projectCompileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectCompileLabel.Name = "projectCompileLabel";
            this.projectCompileLabel.Size = new System.Drawing.Size(313, 31);
            this.projectCompileLabel.TabIndex = 1;
            this.projectCompileLabel.Text = "Did the Project Compile?";
            // 
            // projectLoadLabel
            // 
            this.projectLoadLabel.AutoSize = true;
            this.projectLoadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLoadLabel.Location = new System.Drawing.Point(255, 130);
            this.projectLoadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectLoadLabel.Name = "projectLoadLabel";
            this.projectLoadLabel.Size = new System.Drawing.Size(274, 31);
            this.projectLoadLabel.TabIndex = 0;
            this.projectLoadLabel.Text = "Did the Project Load?";
            // 
            // projectLoadButton
            // 
            this.projectLoadButton.BackgroundImage = global::UID_A02.Properties.Resources.xMark;
            this.projectLoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectLoadButton.Location = new System.Drawing.Point(565, 113);
            this.projectLoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.projectLoadButton.Name = "projectLoadButton";
            this.projectLoadButton.Size = new System.Drawing.Size(72, 60);
            this.projectLoadButton.TabIndex = 3;
            this.projectLoadButton.Tag = "qMark.png";
            this.projectLoadButton.UseVisualStyleBackColor = true;
            this.projectLoadButton.Click += new System.EventHandler(this.projectLoadButton_Click);
            // 
            // commentsPage
            // 
            this.commentsPage.BackColor = System.Drawing.Color.PowderBlue;
            this.commentsPage.Controls.Add(this.resultsPercentLabel);
            this.commentsPage.Controls.Add(this.resultLabelTwo);
            this.commentsPage.Controls.Add(this.removeButton);
            this.commentsPage.Controls.Add(this.addButton);
            this.commentsPage.Controls.Add(this.label3);
            this.commentsPage.Controls.Add(this.fileListLabel);
            this.commentsPage.Controls.Add(this.resultsLabelOne);
            this.commentsPage.Controls.Add(this.percentageListbox);
            this.commentsPage.Controls.Add(this.fileListbox);
            this.commentsPage.Location = new System.Drawing.Point(4, 34);
            this.commentsPage.Margin = new System.Windows.Forms.Padding(4);
            this.commentsPage.Name = "commentsPage";
            this.commentsPage.Padding = new System.Windows.Forms.Padding(4);
            this.commentsPage.Size = new System.Drawing.Size(955, 478);
            this.commentsPage.TabIndex = 2;
            this.commentsPage.Text = "% Of Comments";
            // 
            // resultsPercentLabel
            // 
            this.resultsPercentLabel.AutoSize = true;
            this.resultsPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsPercentLabel.Location = new System.Drawing.Point(619, 203);
            this.resultsPercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsPercentLabel.Name = "resultsPercentLabel";
            this.resultsPercentLabel.Size = new System.Drawing.Size(116, 69);
            this.resultsPercentLabel.TabIndex = 8;
            this.resultsPercentLabel.Text = "0%";
            // 
            // resultLabelTwo
            // 
            this.resultLabelTwo.AutoSize = true;
            this.resultLabelTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabelTwo.Location = new System.Drawing.Point(637, 137);
            this.resultLabelTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabelTwo.Name = "resultLabelTwo";
            this.resultLabelTwo.Size = new System.Drawing.Size(151, 36);
            this.resultLabelTwo.TabIndex = 7;
            this.resultLabelTwo.Text = "Coverage";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(159, 407);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(125, 38);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(25, 407);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 37);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Commenting Coverage";
            // 
            // fileListLabel
            // 
            this.fileListLabel.AutoSize = true;
            this.fileListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileListLabel.Location = new System.Drawing.Point(27, 23);
            this.fileListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileListLabel.Name = "fileListLabel";
            this.fileListLabel.Size = new System.Drawing.Size(167, 25);
            this.fileListLabel.TabIndex = 3;
            this.fileListLabel.Text = "Add source files";
            // 
            // resultsLabelOne
            // 
            this.resultsLabelOne.AutoSize = true;
            this.resultsLabelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabelOne.Location = new System.Drawing.Point(549, 97);
            this.resultsLabelOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabelOne.Name = "resultsLabelOne";
            this.resultsLabelOne.Size = new System.Drawing.Size(357, 36);
            this.resultsLabelOne.TabIndex = 2;
            this.resultsLabelOne.Text = "Cumulative Commenting";
            // 
            // percentageListbox
            // 
            this.percentageListbox.Enabled = false;
            this.percentageListbox.FormattingEnabled = true;
            this.percentageListbox.ItemHeight = 25;
            this.percentageListbox.Location = new System.Drawing.Point(292, 62);
            this.percentageListbox.Margin = new System.Windows.Forms.Padding(4);
            this.percentageListbox.Name = "percentageListbox";
            this.percentageListbox.Size = new System.Drawing.Size(243, 304);
            this.percentageListbox.TabIndex = 1;
            // 
            // fileListbox
            // 
            this.fileListbox.FormattingEnabled = true;
            this.fileListbox.ItemHeight = 25;
            this.fileListbox.Location = new System.Drawing.Point(27, 62);
            this.fileListbox.Margin = new System.Windows.Forms.Padding(4);
            this.fileListbox.Name = "fileListbox";
            this.fileListbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileListbox.Size = new System.Drawing.Size(253, 304);
            this.fileListbox.TabIndex = 0;
            // 
            // authenticityPage
            // 
            this.authenticityPage.BackColor = System.Drawing.Color.PowderBlue;
            this.authenticityPage.Controls.Add(this.originalAuthorTextbox);
            this.authenticityPage.Controls.Add(this.originalSourceAuthorLabel);
            this.authenticityPage.Controls.Add(this.originalSourceTextbox);
            this.authenticityPage.Controls.Add(this.originalSourceWebsite);
            this.authenticityPage.Controls.Add(this.saveButton);
            this.authenticityPage.Controls.Add(this.addCodeLabel);
            this.authenticityPage.Controls.Add(this.citedButton);
            this.authenticityPage.Controls.Add(this.sourceCitedLabel);
            this.authenticityPage.Controls.Add(this.plagurizeButton);
            this.authenticityPage.Controls.Add(this.plagerizedLabel);
            this.authenticityPage.Controls.Add(this.validateButton);
            this.authenticityPage.Controls.Add(this.sourceCodeValidateTextbox);
            this.authenticityPage.Location = new System.Drawing.Point(4, 34);
            this.authenticityPage.Margin = new System.Windows.Forms.Padding(4);
            this.authenticityPage.Name = "authenticityPage";
            this.authenticityPage.Padding = new System.Windows.Forms.Padding(4);
            this.authenticityPage.Size = new System.Drawing.Size(955, 478);
            this.authenticityPage.TabIndex = 3;
            this.authenticityPage.Text = "Authenticity";
            // 
            // originalAuthorTextbox
            // 
            this.originalAuthorTextbox.Location = new System.Drawing.Point(725, 320);
            this.originalAuthorTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.originalAuthorTextbox.Name = "originalAuthorTextbox";
            this.originalAuthorTextbox.Size = new System.Drawing.Size(195, 30);
            this.originalAuthorTextbox.TabIndex = 12;
            // 
            // originalSourceAuthorLabel
            // 
            this.originalSourceAuthorLabel.AutoSize = true;
            this.originalSourceAuthorLabel.Location = new System.Drawing.Point(540, 320);
            this.originalSourceAuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalSourceAuthorLabel.Name = "originalSourceAuthorLabel";
            this.originalSourceAuthorLabel.Size = new System.Drawing.Size(153, 25);
            this.originalSourceAuthorLabel.TabIndex = 11;
            this.originalSourceAuthorLabel.Text = "Original Author :";
            // 
            // originalSourceTextbox
            // 
            this.originalSourceTextbox.Location = new System.Drawing.Point(725, 260);
            this.originalSourceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.originalSourceTextbox.Name = "originalSourceTextbox";
            this.originalSourceTextbox.Size = new System.Drawing.Size(195, 30);
            this.originalSourceTextbox.TabIndex = 10;
            // 
            // originalSourceWebsite
            // 
            this.originalSourceWebsite.AutoSize = true;
            this.originalSourceWebsite.Location = new System.Drawing.Point(455, 263);
            this.originalSourceWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalSourceWebsite.Name = "originalSourceWebsite";
            this.originalSourceWebsite.Size = new System.Drawing.Size(235, 25);
            this.originalSourceWebsite.TabIndex = 9;
            this.originalSourceWebsite.Text = "Original Source Website :";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(571, 389);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(258, 49);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save Entry";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addCodeLabel
            // 
            this.addCodeLabel.AutoSize = true;
            this.addCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCodeLabel.Location = new System.Drawing.Point(27, 23);
            this.addCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addCodeLabel.Name = "addCodeLabel";
            this.addCodeLabel.Size = new System.Drawing.Size(293, 25);
            this.addCodeLabel.TabIndex = 6;
            this.addCodeLabel.Text = "Add Source Code to Validate";
            // 
            // citedButton
            // 
            this.citedButton.BackgroundImage = global::UID_A02.Properties.Resources.xMark;
            this.citedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.citedButton.Location = new System.Drawing.Point(729, 198);
            this.citedButton.Margin = new System.Windows.Forms.Padding(4);
            this.citedButton.Name = "citedButton";
            this.citedButton.Size = new System.Drawing.Size(44, 41);
            this.citedButton.TabIndex = 5;
            this.citedButton.UseVisualStyleBackColor = true;
            this.citedButton.Click += new System.EventHandler(this.citedButton_Click);
            // 
            // sourceCitedLabel
            // 
            this.sourceCitedLabel.AutoSize = true;
            this.sourceCitedLabel.Location = new System.Drawing.Point(459, 204);
            this.sourceCitedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceCitedLabel.Name = "sourceCitedLabel";
            this.sourceCitedLabel.Size = new System.Drawing.Size(237, 25);
            this.sourceCitedLabel.TabIndex = 4;
            this.sourceCitedLabel.Text = "Original Source Credited?";
            // 
            // plagurizeButton
            // 
            this.plagurizeButton.BackgroundImage = global::UID_A02.Properties.Resources.xMark;
            this.plagurizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plagurizeButton.Location = new System.Drawing.Point(728, 133);
            this.plagurizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.plagurizeButton.Name = "plagurizeButton";
            this.plagurizeButton.Size = new System.Drawing.Size(44, 41);
            this.plagurizeButton.TabIndex = 3;
            this.plagurizeButton.UseVisualStyleBackColor = true;
            this.plagurizeButton.Click += new System.EventHandler(this.plagurizeButton_Click);
            // 
            // plagerizedLabel
            // 
            this.plagerizedLabel.AutoSize = true;
            this.plagerizedLabel.Location = new System.Drawing.Point(492, 142);
            this.plagerizedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plagerizedLabel.Name = "plagerizedLabel";
            this.plagerizedLabel.Size = new System.Drawing.Size(214, 25);
            this.plagerizedLabel.TabIndex = 2;
            this.plagerizedLabel.Text = "Was Code Plagurized?";
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(455, 62);
            this.validateButton.Margin = new System.Windows.Forms.Padding(4);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(468, 49);
            this.validateButton.TabIndex = 1;
            this.validateButton.Text = "Check Authenticity";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // sourceCodeValidateTextbox
            // 
            this.sourceCodeValidateTextbox.Location = new System.Drawing.Point(27, 62);
            this.sourceCodeValidateTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceCodeValidateTextbox.Multiline = true;
            this.sourceCodeValidateTextbox.Name = "sourceCodeValidateTextbox";
            this.sourceCodeValidateTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceCodeValidateTextbox.Size = new System.Drawing.Size(412, 384);
            this.sourceCodeValidateTextbox.TabIndex = 0;
            this.sourceCodeValidateTextbox.Text = "Provide Source Code to Authenticate Here...";
            // 
            // feedbackPage
            // 
            this.feedbackPage.BackColor = System.Drawing.Color.PowderBlue;
            this.feedbackPage.Controls.Add(this.noteLabel);
            this.feedbackPage.Controls.Add(this.NoteTextbox);
            this.feedbackPage.Controls.Add(this.sourceCodeLineTextbox);
            this.feedbackPage.Controls.Add(this.sourceCodeLineLabel);
            this.feedbackPage.Controls.Add(this.saveNoteButton);
            this.feedbackPage.Controls.Add(this.label5);
            this.feedbackPage.Controls.Add(this.sourceCodeNoteTextbox);
            this.feedbackPage.Location = new System.Drawing.Point(4, 34);
            this.feedbackPage.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackPage.Name = "feedbackPage";
            this.feedbackPage.Padding = new System.Windows.Forms.Padding(4);
            this.feedbackPage.Size = new System.Drawing.Size(955, 478);
            this.feedbackPage.TabIndex = 4;
            this.feedbackPage.Text = "Feedback";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(444, 22);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(253, 25);
            this.noteLabel.TabIndex = 27;
            this.noteLabel.Text = "Note About Source Code";
            // 
            // NoteTextbox
            // 
            this.NoteTextbox.Location = new System.Drawing.Point(449, 60);
            this.NoteTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTextbox.Multiline = true;
            this.NoteTextbox.Name = "NoteTextbox";
            this.NoteTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextbox.Size = new System.Drawing.Size(472, 250);
            this.NoteTextbox.TabIndex = 26;
            this.NoteTextbox.Text = "Write a note about the source code provided in the adjacent textbox...";
            // 
            // sourceCodeLineTextbox
            // 
            this.sourceCodeLineTextbox.Location = new System.Drawing.Point(704, 330);
            this.sourceCodeLineTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceCodeLineTextbox.Name = "sourceCodeLineTextbox";
            this.sourceCodeLineTextbox.Size = new System.Drawing.Size(217, 30);
            this.sourceCodeLineTextbox.TabIndex = 25;
            // 
            // sourceCodeLineLabel
            // 
            this.sourceCodeLineLabel.AutoSize = true;
            this.sourceCodeLineLabel.Location = new System.Drawing.Point(452, 334);
            this.sourceCodeLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceCodeLineLabel.Name = "sourceCodeLineLabel";
            this.sourceCodeLineLabel.Size = new System.Drawing.Size(227, 25);
            this.sourceCodeLineLabel.TabIndex = 24;
            this.sourceCodeLineLabel.Text = "Source Code Line Start :";
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.Location = new System.Drawing.Point(571, 387);
            this.saveNoteButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(258, 49);
            this.saveNoteButton.TabIndex = 20;
            this.saveNoteButton.Text = "Save Note";
            this.saveNoteButton.UseVisualStyleBackColor = true;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Related Source Code";
            // 
            // sourceCodeNoteTextbox
            // 
            this.sourceCodeNoteTextbox.Location = new System.Drawing.Point(28, 60);
            this.sourceCodeNoteTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceCodeNoteTextbox.Multiline = true;
            this.sourceCodeNoteTextbox.Name = "sourceCodeNoteTextbox";
            this.sourceCodeNoteTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceCodeNoteTextbox.Size = new System.Drawing.Size(412, 384);
            this.sourceCodeNoteTextbox.TabIndex = 13;
            this.sourceCodeNoteTextbox.Text = "Add Source Code Related to Note...";
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(21, 596);
            this.myProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(440, 39);
            this.myProgressBar.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(469, 596);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 39);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(597, 596);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(120, 39);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(725, 596);
            this.finishButton.Margin = new System.Windows.Forms.Padding(4);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(120, 39);
            this.finishButton.TabIndex = 4;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(853, 596);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 39);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subtitleLabel.Location = new System.Drawing.Point(16, 14);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(231, 39);
            this.subtitleLabel.TabIndex = 6;
            this.subtitleLabel.Text = "Find A Project";
            // 
            // TabOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 650);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.TabController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TabOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Marking Assistant";
            this.TabController.ResumeLayout(false);
            this.findProjectPage.ResumeLayout(false);
            this.findProjectPage.PerformLayout();
            this.loadCompilePage.ResumeLayout(false);
            this.loadCompilePage.PerformLayout();
            this.commentsPage.ResumeLayout(false);
            this.commentsPage.PerformLayout();
            this.authenticityPage.ResumeLayout(false);
            this.authenticityPage.PerformLayout();
            this.feedbackPage.ResumeLayout(false);
            this.feedbackPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage findProjectPage;
        private System.Windows.Forms.TabPage loadCompilePage;
        private System.Windows.Forms.TabPage commentsPage;
        private System.Windows.Forms.TabPage authenticityPage;
        private System.Windows.Forms.ProgressBar myProgressBar;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox searchProjectTextbox;
        private System.Windows.Forms.Label searchProjectLabel;
        private System.Windows.Forms.Label pathingCheckLabel;
        private System.Windows.Forms.Button projectRunButton;
        private System.Windows.Forms.Button projectCompileButton;
        private System.Windows.Forms.Button projectLoadButton;
        private System.Windows.Forms.Label projectRunLabel;
        private System.Windows.Forms.Label projectCompileLabel;
        private System.Windows.Forms.Label projectLoadLabel;
        private System.Windows.Forms.Label badPathingLabel;
        private System.Windows.Forms.ListBox percentageListbox;
        private System.Windows.Forms.ListBox fileListbox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileListLabel;
        private System.Windows.Forms.Label resultsLabelOne;
        private System.Windows.Forms.Label resultLabelTwo;
        private System.Windows.Forms.Label resultsPercentLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label addCodeLabel;
        private System.Windows.Forms.Button citedButton;
        private System.Windows.Forms.Label sourceCitedLabel;
        private System.Windows.Forms.Button plagurizeButton;
        private System.Windows.Forms.Label plagerizedLabel;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.TextBox sourceCodeValidateTextbox;
        private System.Windows.Forms.Label originalSourceWebsite;
        private System.Windows.Forms.TextBox originalAuthorTextbox;
        private System.Windows.Forms.Label originalSourceAuthorLabel;
        private System.Windows.Forms.TextBox originalSourceTextbox;
        private System.Windows.Forms.TabPage feedbackPage;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox NoteTextbox;
        private System.Windows.Forms.TextBox sourceCodeLineTextbox;
        private System.Windows.Forms.Label sourceCodeLineLabel;
        private System.Windows.Forms.Button saveNoteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sourceCodeNoteTextbox;
        private System.Windows.Forms.TextBox projectOwnerNameTextbox;
        private System.Windows.Forms.Label programmerNameLabel;
    }
}

