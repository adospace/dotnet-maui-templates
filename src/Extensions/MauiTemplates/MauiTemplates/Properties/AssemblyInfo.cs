﻿using MauiTemplates;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

// For Visual Studio to locate and load the component assembly during runtime
[assembly: ProvideCodeBase(AssemblyName = "VijayAnand.MauiTemplates")]

[assembly: AssemblyTitle(Vsix.Name)]
[assembly: AssemblyDescription(Vsix.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(Vsix.Author)]
[assembly: AssemblyProduct(Vsix.Name)]
[assembly: AssemblyCopyright(Vsix.Author)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: AssemblyVersion("1.7.1.0")]
[assembly: AssemblyFileVersion("1.7.1.0")]
