﻿Console.Clear();
Console.ForegroundColor=ConsoleColor.Cyan;
for (int n=1; n<=40; n++)
   Console.Write(n %4==0? "pim\n":$"{n,12}");
