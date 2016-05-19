using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public partial class frmMain : Form
{
    private List<clsPerson> mPerson = new List<clsPerson>();
    private List<clsPerson> mMergeSortPerson = new List<clsPerson>();

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
        radSmallEmployeeFileUnsorted.Checked = true;
        radBubble.Checked = true;
        radAscending.Checked = true;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnClearStats_Click(object sender, EventArgs e)
    {
        lstDisplaySortingStatistics.Items.Clear();
    }

    private void btnLoadSort_Click(object sender, EventArgs e)
    {
        lstDisplayEmployees.Items.Clear();
        mPerson.Clear();
        mMergeSortPerson.Clear();

        string filenameDisplayList;
        string sortTypeDisplayList;
        string directionDisplayList;
        string numberOfRecordsDisplayList;

        // Check Employee File

        if (radSmallEmployeeFileReverse.Checked == true) 
        {
            filenameDisplayList = "Reverse1k.txt";
            loadInformationFromFile("Reverse1k.txt");
        }
        else if (radSmallEmployeeFileUnsorted.Checked == true)
        {
            filenameDisplayList = "Unsorted.txt";
            loadInformationFromFile("Unsorted1k.txt");
        }
        else if (radBigEmployeeFileReverse.Checked == true)
        {
            filenameDisplayList = "Reverse15k.txt";
            loadInformationFromFile("Reverse15k.txt");
        }
        else if (radBigEmployeeFileUnsorted.Checked == true)
        {
            filenameDisplayList = "Unsorted15k.txt";
            loadInformationFromFile("Unsorted15k.txt");
        }
        else
        {
            return;
        }

        // Check Sort Decision

        directionDisplayList = "Ascending";
        if (radDescending.Checked == true)
        {
            directionDisplayList = "Descending";
            mPerson.Reverse();
        }
        else if (radAscending.Checked == false)
        {
            return;
        }

        numberOfRecordsDisplayList = mPerson.Count.ToString();

        // Check Sort Method

        DateTime start = DateTime.Now;

        if (radBubble.Checked == true) 
        {
            sortTypeDisplayList = "Bubble";
            bubbleSort();
        }
        else if (radIComparer.Checked == true) 
        {
            sortTypeDisplayList = "IComparer";
            iComparerSort();
        }
        else if (radLINQ.Checked == true)
        {
            sortTypeDisplayList = "Linq";
            linqSort();
        }
        else if (radMergeSort.Checked == true)
        {
            sortTypeDisplayList = "Merge Sort";
            mergeSort();
        } 
        else if (radNoneUnsorted.Checked == true) 
        {
            sortTypeDisplayList = "Unsorted";
        }
        else
        {
            return;
        }

        DateTime end = DateTime.Now;

        TimeSpan ts = end.Subtract(start);

        if (directionDisplayList == "Descending")
        {
            mPerson.Reverse();
        }

        showSortedInformation();

        showSortingStatistics(filenameDisplayList, 
            sortTypeDisplayList, 
            directionDisplayList, 
            numberOfRecordsDisplayList, 
            ts);
    }

    // Bubble Sort Functions: Start

    private void bubbleSort()
    {
        bool swapped = true;
        int i = 0;
        while (swapped == true)
        {
            swapped = false;
            i++;
            for (int j = 0; j < mPerson.Count - i; j++)
            {
                if (string.Compare(mPerson[j].LastName, mPerson[j + 1].LastName) > 0)
                {
                    swap(j, j + 1);
                    swapped = true;
                }
                else if (string.Compare(mPerson[j].LastName, mPerson[j + 1].LastName) == 0)
                {
                    if (string.Compare(mPerson[j].FirstName, mPerson[j + 1].FirstName) > 0)
                    {
                        swap(j, j + 1);
                        swapped = true;
                    }
                }
            }
        }
    }

    private void swap(int index1, int index2)
    {
        clsPerson temp = new clsPerson();
        temp = mPerson[index1];
        mPerson[index1] = mPerson[index2];
        mPerson[index2] = temp;
    }

    // Bubble Sort Functions: End

    private void iComparerSort() 
    {
        clsPersonComparer personComparer = new clsPersonComparer();
        mPerson.Sort(personComparer);
    }

    private void linqSort()
    {
        var querySortPersonList =
            from person in mPerson
            orderby person.FirstName ascending
            orderby person.LastName ascending
            select person;
        List<clsPerson> newPersonList = new List<clsPerson>(querySortPersonList);

        mPerson = newPersonList;
    }

    // Merge Sort Functions: Start

    private void mergeSort() 
    {
        int length = mPerson.Count;
        doMergeSort(0, length - 1);
    }

    private void doMergeSort(int lowerIndex, int upperIndex)
    {
        if (lowerIndex < upperIndex)
        {
            int median = (lowerIndex + upperIndex) / 2;
            doMergeSort(lowerIndex, median);
            doMergeSort(median + 1, upperIndex);
            merge(lowerIndex, median, upperIndex);
        }
    }

    private void merge(int lowerIndex, int median, int upperIndex)
    {
        int i;
        for (i = lowerIndex; i <= upperIndex; i++)
        {
            // I do not want to copy the addresses to each person instance to the other array
            clsPerson person = new clsPerson();
            person.FirstName = mPerson[i].FirstName;
            person.LastName = mPerson[i].LastName;
            mMergeSortPerson.Insert(i, person);
        }

        i = lowerIndex;
        int j = median + 1;
        int k = lowerIndex;

        while (i <= median && j <= upperIndex)
        {
            if (string.Compare(mMergeSortPerson[i].LastName, mMergeSortPerson[j].LastName) < 0)
            {
                mPerson[k].LastName = mMergeSortPerson[i].LastName;
                mPerson[k].FirstName = mMergeSortPerson[i].FirstName;
                i++;
            }
            else if (string.Compare(mMergeSortPerson[i].LastName, mMergeSortPerson[j].LastName) == 0) 
            {
                if (string.Compare(mMergeSortPerson[i].FirstName, mMergeSortPerson[j].FirstName) < 0)
                {
                    mPerson[k].LastName = mMergeSortPerson[i].LastName;
                    mPerson[k].FirstName = mMergeSortPerson[i].FirstName;
                    i++;
                }
                else
                {
                    mPerson[k].LastName = mMergeSortPerson[j].LastName;
                    mPerson[k].FirstName = mMergeSortPerson[j].FirstName;
                    j++;
                }
            }
            else
            {
                mPerson[k].LastName = mMergeSortPerson[j].LastName;
                mPerson[k].FirstName = mMergeSortPerson[j].FirstName;
                j++;
            }
            k++;
        }
        while (i <= median)
        {
            mPerson[k].LastName = mMergeSortPerson[i].LastName;
            mPerson[k].FirstName = mMergeSortPerson[i].FirstName;
            i++;
            k++;
        }
    }

    // Merge Sort Functions: End

    private void loadInformationFromFile(string filename)
    {
        string pathFileName = Path.Combine(Application.StartupPath, filename);
        string input;
        try
        {
            StreamReader sr = new StreamReader(pathFileName);

            input = sr.ReadLine();
            while (input != null)
            {
                clsPerson person = new clsPerson();
                person.Deserialize(input);
                mPerson.Add(person);
                input = sr.ReadLine();
            }
            sr.Close();
        }
        catch (Exception ex) 
        {
            MessageBox.Show("Error reading Names from file"
                + pathFileName + ".\n" + ex.Message);
        }
    }

    private void showSortingStatistics(
        string filename, 
        string sortType, 
        string direction, 
        string numberOfRecords, 
        TimeSpan ts)
    {
        int padding = 16;
        string result = filename.PadRight(padding) 
            + sortType.PadRight(padding)
            + direction.PadRight(padding)
            + numberOfRecords.PadRight(padding)
            + ts.TotalMilliseconds.ToString();

        lstDisplaySortingStatistics.Items.Add(result);
    }

    private void showSortedInformation() 
    {
        string result = "";
        foreach (clsPerson person in mPerson) 
        {
            result = person.LastName + ", " + person.FirstName;
            lstDisplayEmployees.Items.Add(result);
        }
    }
}