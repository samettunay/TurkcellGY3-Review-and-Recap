﻿using Constructors;

Console.WriteLine("Hello, World!");
ReportGenerator reportGenerator = new ReportGenerator("C:\\data.txt");

Console.WriteLine(reportGenerator.ReportFormat);

ReportGenerator report2 = new ReportGenerator(readingPath: "C:\\data.xml");

Ekmek ekmek = new Ekmek(2, "kepek");