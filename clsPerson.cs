﻿using System;

public class clsPerson
{
    public string LastName;
    public string FirstName;

    public void Deserialize(string information)
    {
        string[] parsedInformation = information.Split('\t');

        LastName = parsedInformation[0];
        FirstName = parsedInformation[1];
    }
}