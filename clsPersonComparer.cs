using System;
using System.Collections.Generic;

public class clsPersonComparer: IComparer<clsPerson>
{
    int IComparer<clsPerson>.Compare(clsPerson person1, clsPerson person2)
    {
        if (string.Compare(person1.LastName, person2.LastName) < 0)
        {
            return -1;
        }
        else if (string.Compare(person1.LastName, person2.LastName) == 0)
        {
            if (string.Compare(person1.FirstName, person2.FirstName) < 0)
            {
                return -1;
            }
        }
        return 1;
    }
}