﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using Roslyn.Services;
using Roslyn.Services.CSharp;
using TSGHealtVaultService;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            loadHealthVaultStructure.getHealthVaultModelData();
        }
    }
}
