partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.lstDisplayEmployees = new System.Windows.Forms.ListBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblSortingOptions = new System.Windows.Forms.Label();
            this.grpEmployeeFile = new System.Windows.Forms.GroupBox();
            this.radBigEmployeeFileReverse = new System.Windows.Forms.RadioButton();
            this.radBigEmployeeFileUnsorted = new System.Windows.Forms.RadioButton();
            this.radSmallEmployeeFileReverse = new System.Windows.Forms.RadioButton();
            this.radSmallEmployeeFileUnsorted = new System.Windows.Forms.RadioButton();
            this.grpSortMethod = new System.Windows.Forms.GroupBox();
            this.radMergeSort = new System.Windows.Forms.RadioButton();
            this.radNoneUnsorted = new System.Windows.Forms.RadioButton();
            this.radLINQ = new System.Windows.Forms.RadioButton();
            this.radIComparer = new System.Windows.Forms.RadioButton();
            this.radBubble = new System.Windows.Forms.RadioButton();
            this.grpSortDecision = new System.Windows.Forms.GroupBox();
            this.radDescending = new System.Windows.Forms.RadioButton();
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.btnLoadSort = new System.Windows.Forms.Button();
            this.lstDisplaySortingStatistics = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSortingHistory = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpEmployeeFile.SuspendLayout();
            this.grpSortMethod.SuspendLayout();
            this.grpSortDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDisplayEmployees
            // 
            this.lstDisplayEmployees.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplayEmployees.FormattingEnabled = true;
            this.lstDisplayEmployees.ItemHeight = 14;
            this.lstDisplayEmployees.Location = new System.Drawing.Point(13, 58);
            this.lstDisplayEmployees.Name = "lstDisplayEmployees";
            this.lstDisplayEmployees.Size = new System.Drawing.Size(196, 368);
            this.lstDisplayEmployees.TabIndex = 0;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(12, 24);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(90, 16);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "Employees:";
            // 
            // lblSortingOptions
            // 
            this.lblSortingOptions.AutoSize = true;
            this.lblSortingOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortingOptions.Location = new System.Drawing.Point(232, 26);
            this.lblSortingOptions.Name = "lblSortingOptions";
            this.lblSortingOptions.Size = new System.Drawing.Size(114, 16);
            this.lblSortingOptions.TabIndex = 2;
            this.lblSortingOptions.Text = "Sorting Options";
            // 
            // grpEmployeeFile
            // 
            this.grpEmployeeFile.Controls.Add(this.radBigEmployeeFileReverse);
            this.grpEmployeeFile.Controls.Add(this.radBigEmployeeFileUnsorted);
            this.grpEmployeeFile.Controls.Add(this.radSmallEmployeeFileReverse);
            this.grpEmployeeFile.Controls.Add(this.radSmallEmployeeFileUnsorted);
            this.grpEmployeeFile.Location = new System.Drawing.Point(235, 58);
            this.grpEmployeeFile.Name = "grpEmployeeFile";
            this.grpEmployeeFile.Size = new System.Drawing.Size(191, 150);
            this.grpEmployeeFile.TabIndex = 3;
            this.grpEmployeeFile.TabStop = false;
            this.grpEmployeeFile.Text = "Employee File:";
            // 
            // radBigEmployeeFileReverse
            // 
            this.radBigEmployeeFileReverse.AutoSize = true;
            this.radBigEmployeeFileReverse.Location = new System.Drawing.Point(18, 98);
            this.radBigEmployeeFileReverse.Name = "radBigEmployeeFileReverse";
            this.radBigEmployeeFileReverse.Size = new System.Drawing.Size(162, 17);
            this.radBigEmployeeFileReverse.TabIndex = 3;
            this.radBigEmployeeFileReverse.TabStop = true;
            this.radBigEmployeeFileReverse.Text = "15,000 Employees - unsorted";
            this.radBigEmployeeFileReverse.UseVisualStyleBackColor = true;
            // 
            // radBigEmployeeFileUnsorted
            // 
            this.radBigEmployeeFileUnsorted.AutoSize = true;
            this.radBigEmployeeFileUnsorted.Location = new System.Drawing.Point(18, 75);
            this.radBigEmployeeFileUnsorted.Name = "radBigEmployeeFileUnsorted";
            this.radBigEmployeeFileUnsorted.Size = new System.Drawing.Size(162, 17);
            this.radBigEmployeeFileUnsorted.TabIndex = 2;
            this.radBigEmployeeFileUnsorted.TabStop = true;
            this.radBigEmployeeFileUnsorted.Text = "15,000 Employees - unsorted";
            this.radBigEmployeeFileUnsorted.UseVisualStyleBackColor = true;
            // 
            // radSmallEmployeeFileReverse
            // 
            this.radSmallEmployeeFileReverse.AutoSize = true;
            this.radSmallEmployeeFileReverse.Location = new System.Drawing.Point(18, 52);
            this.radSmallEmployeeFileReverse.Name = "radSmallEmployeeFileReverse";
            this.radSmallEmployeeFileReverse.Size = new System.Drawing.Size(150, 17);
            this.radSmallEmployeeFileReverse.TabIndex = 1;
            this.radSmallEmployeeFileReverse.TabStop = true;
            this.radSmallEmployeeFileReverse.Text = "1,000 Employees - reverse";
            this.radSmallEmployeeFileReverse.UseVisualStyleBackColor = true;
            // 
            // radSmallEmployeeFileUnsorted
            // 
            this.radSmallEmployeeFileUnsorted.AutoSize = true;
            this.radSmallEmployeeFileUnsorted.Location = new System.Drawing.Point(18, 29);
            this.radSmallEmployeeFileUnsorted.Name = "radSmallEmployeeFileUnsorted";
            this.radSmallEmployeeFileUnsorted.Size = new System.Drawing.Size(156, 17);
            this.radSmallEmployeeFileUnsorted.TabIndex = 0;
            this.radSmallEmployeeFileUnsorted.TabStop = true;
            this.radSmallEmployeeFileUnsorted.Text = "1,000 Employees - unsorted";
            this.radSmallEmployeeFileUnsorted.UseVisualStyleBackColor = true;
            // 
            // grpSortMethod
            // 
            this.grpSortMethod.Controls.Add(this.radMergeSort);
            this.grpSortMethod.Controls.Add(this.radNoneUnsorted);
            this.grpSortMethod.Controls.Add(this.radLINQ);
            this.grpSortMethod.Controls.Add(this.radIComparer);
            this.grpSortMethod.Controls.Add(this.radBubble);
            this.grpSortMethod.Location = new System.Drawing.Point(448, 58);
            this.grpSortMethod.Name = "grpSortMethod";
            this.grpSortMethod.Size = new System.Drawing.Size(125, 150);
            this.grpSortMethod.TabIndex = 4;
            this.grpSortMethod.TabStop = false;
            this.grpSortMethod.Text = "Sort Method:";
            // 
            // radMergeSort
            // 
            this.radMergeSort.AutoSize = true;
            this.radMergeSort.Location = new System.Drawing.Point(17, 98);
            this.radMergeSort.Name = "radMergeSort";
            this.radMergeSort.Size = new System.Drawing.Size(77, 17);
            this.radMergeSort.TabIndex = 4;
            this.radMergeSort.TabStop = true;
            this.radMergeSort.Text = "Merge Sort";
            this.radMergeSort.UseVisualStyleBackColor = true;
            // 
            // radNoneUnsorted
            // 
            this.radNoneUnsorted.AutoSize = true;
            this.radNoneUnsorted.Location = new System.Drawing.Point(17, 121);
            this.radNoneUnsorted.Name = "radNoneUnsorted";
            this.radNoneUnsorted.Size = new System.Drawing.Size(101, 17);
            this.radNoneUnsorted.TabIndex = 3;
            this.radNoneUnsorted.TabStop = true;
            this.radNoneUnsorted.Text = "None (unsorted)";
            this.radNoneUnsorted.UseVisualStyleBackColor = true;
            // 
            // radLINQ
            // 
            this.radLINQ.AutoSize = true;
            this.radLINQ.Location = new System.Drawing.Point(17, 75);
            this.radLINQ.Name = "radLINQ";
            this.radLINQ.Size = new System.Drawing.Size(50, 17);
            this.radLINQ.TabIndex = 2;
            this.radLINQ.TabStop = true;
            this.radLINQ.Text = "LINQ";
            this.radLINQ.UseVisualStyleBackColor = true;
            // 
            // radIComparer
            // 
            this.radIComparer.AutoSize = true;
            this.radIComparer.Location = new System.Drawing.Point(17, 52);
            this.radIComparer.Name = "radIComparer";
            this.radIComparer.Size = new System.Drawing.Size(73, 17);
            this.radIComparer.TabIndex = 1;
            this.radIComparer.TabStop = true;
            this.radIComparer.Text = "IComparer";
            this.radIComparer.UseVisualStyleBackColor = true;
            // 
            // radBubble
            // 
            this.radBubble.AutoSize = true;
            this.radBubble.Location = new System.Drawing.Point(17, 29);
            this.radBubble.Name = "radBubble";
            this.radBubble.Size = new System.Drawing.Size(58, 17);
            this.radBubble.TabIndex = 0;
            this.radBubble.TabStop = true;
            this.radBubble.Text = "Bubble";
            this.radBubble.UseVisualStyleBackColor = true;
            // 
            // grpSortDecision
            // 
            this.grpSortDecision.Controls.Add(this.radDescending);
            this.grpSortDecision.Controls.Add(this.radAscending);
            this.grpSortDecision.Location = new System.Drawing.Point(595, 58);
            this.grpSortDecision.Name = "grpSortDecision";
            this.grpSortDecision.Size = new System.Drawing.Size(140, 81);
            this.grpSortDecision.TabIndex = 5;
            this.grpSortDecision.TabStop = false;
            this.grpSortDecision.Text = "Sort Decision:";
            // 
            // radDescending
            // 
            this.radDescending.AutoSize = true;
            this.radDescending.Location = new System.Drawing.Point(18, 52);
            this.radDescending.Name = "radDescending";
            this.radDescending.Size = new System.Drawing.Size(82, 17);
            this.radDescending.TabIndex = 1;
            this.radDescending.TabStop = true;
            this.radDescending.Text = "Descending";
            this.radDescending.UseVisualStyleBackColor = true;
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Location = new System.Drawing.Point(18, 29);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(75, 17);
            this.radAscending.TabIndex = 0;
            this.radAscending.TabStop = true;
            this.radAscending.Text = "Ascending";
            this.radAscending.UseVisualStyleBackColor = true;
            // 
            // btnLoadSort
            // 
            this.btnLoadSort.Location = new System.Drawing.Point(595, 149);
            this.btnLoadSort.Name = "btnLoadSort";
            this.btnLoadSort.Size = new System.Drawing.Size(140, 30);
            this.btnLoadSort.TabIndex = 6;
            this.btnLoadSort.Text = "Load and Sort File";
            this.btnLoadSort.UseVisualStyleBackColor = true;
            this.btnLoadSort.Click += new System.EventHandler(this.btnLoadSort_Click);
            // 
            // lstDisplaySortingStatistics
            // 
            this.lstDisplaySortingStatistics.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplaySortingStatistics.FormattingEnabled = true;
            this.lstDisplaySortingStatistics.ItemHeight = 14;
            this.lstDisplaySortingStatistics.Location = new System.Drawing.Point(235, 279);
            this.lstDisplaySortingStatistics.Name = "lstDisplaySortingStatistics";
            this.lstDisplaySortingStatistics.Size = new System.Drawing.Size(500, 144);
            this.lstDisplaySortingStatistics.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(595, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSortingHistory
            // 
            this.lblSortingHistory.AutoSize = true;
            this.lblSortingHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortingHistory.Location = new System.Drawing.Point(232, 226);
            this.lblSortingHistory.Name = "lblSortingHistory";
            this.lblSortingHistory.Size = new System.Drawing.Size(114, 16);
            this.lblSortingHistory.TabIndex = 9;
            this.lblSortingHistory.Text = "Sorting History:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(235, 255);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 13);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "File Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(348, 255);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(462, 255);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(52, 13);
            this.lblDirection.TabIndex = 12;
            this.lblDirection.Text = "Direction:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(575, 255);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(60, 13);
            this.lblNumberOfRecords.TabIndex = 13;
            this.lblNumberOfRecords.Text = "# Records:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(683, 255);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time (ms):";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(751, 446);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblSortingHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstDisplaySortingStatistics);
            this.Controls.Add(this.btnLoadSort);
            this.Controls.Add(this.grpSortDecision);
            this.Controls.Add(this.grpSortMethod);
            this.Controls.Add(this.grpEmployeeFile);
            this.Controls.Add(this.lblSortingOptions);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.lstDisplayEmployees);
            this.Name = "frmMain";
            this.grpEmployeeFile.ResumeLayout(false);
            this.grpEmployeeFile.PerformLayout();
            this.grpSortMethod.ResumeLayout(false);
            this.grpSortMethod.PerformLayout();
            this.grpSortDecision.ResumeLayout(false);
            this.grpSortDecision.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.ListBox lstDisplayEmployees;
    private System.Windows.Forms.Label lblEmployees;
    private System.Windows.Forms.Label lblSortingOptions;
    private System.Windows.Forms.GroupBox grpEmployeeFile;
    private System.Windows.Forms.RadioButton radBigEmployeeFileReverse;
    private System.Windows.Forms.RadioButton radBigEmployeeFileUnsorted;
    private System.Windows.Forms.RadioButton radSmallEmployeeFileReverse;
    private System.Windows.Forms.RadioButton radSmallEmployeeFileUnsorted;
    private System.Windows.Forms.GroupBox grpSortMethod;
    private System.Windows.Forms.RadioButton radNoneUnsorted;
    private System.Windows.Forms.RadioButton radLINQ;
    private System.Windows.Forms.RadioButton radIComparer;
    private System.Windows.Forms.RadioButton radBubble;
    private System.Windows.Forms.RadioButton radMergeSort;
    private System.Windows.Forms.GroupBox grpSortDecision;
    private System.Windows.Forms.RadioButton radDescending;
    private System.Windows.Forms.RadioButton radAscending;
    private System.Windows.Forms.Button btnLoadSort;
    private System.Windows.Forms.ListBox lstDisplaySortingStatistics;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblSortingHistory;
    private System.Windows.Forms.Label lblFileName;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Label lblDirection;
    private System.Windows.Forms.Label lblNumberOfRecords;
    private System.Windows.Forms.Label lblTime;
}