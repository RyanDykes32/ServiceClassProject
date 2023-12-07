﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClassProject.Model;

public class Employee : Account
{
    // Constructor for creating a employee object with a specified username and password.
    public Employee(string na, string pa)
    {
        // Initialize the username and password fields with the provided values.
        username = na;
        password = pa;

        // Add the username and password to the loginPairs dictionary.
        // This allows the system to verify login credentials during the authentication process.
        loginPairs.Add(username, password);

        // Add the username and the corresponding Employee object to the accountList dictionary.
        // This enables quick access to the Employee object associated with a given username.
        accountList.Add(username, this);

    }
    }
