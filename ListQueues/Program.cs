﻿#region Copyright (c) 2010 Active Web Solutions Ltd
//
// (C) Copyright 2010 Active Web Solutions Ltd
//      All rights reserved.
//
// This software is provided "as is" without warranty of any kind,
// express or implied, including but not limited to warranties as to
// quality and fitness for a particular purpose. Active Web Solutions Ltd
// does not support the Software, nor does it warrant that the Software
// will meet your requirements or that the operation of the Software will
// be uninterrupted or error free or that any defects will be
// corrected. Nothing in this statement is intended to limit or exclude
// any liability for personal injury or death caused by the negligence of
// Active Web Solutions Ltd, its employees, contractors or agents.
//
#endregion

using System;
using Aws.AzureTools;
using Microsoft.WindowsAzure.Storage.Queue;

namespace ListQueues
{
    class Program
    {
        static int Main(string[] args)
        {
            QueueHelper queueHelper = new QueueHelper();
            foreach (CloudQueue queue in queueHelper.ListQueues())
            {
                Console.WriteLine(queue);
            }

            return (Settings.SUCCESS);
        }
    }
}
