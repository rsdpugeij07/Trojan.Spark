// Decompiled with JetBrains decompiler
// Type: Spark.Variables
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using System;
using System.Diagnostics;
using System.IO;

#nullable disable
namespace Spark;

internal class Variables
{
  public static string DriveLetter = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
  public static string windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
  public static string FilePath = Variables.windir + "\\File Cache";
  public static bool Initialised = File.Exists(Variables.FilePath + "\\Initialised");
  public static bool KillOnReboot = File.Exists(Variables.FilePath + "\\KillOnReboot");
  public static string[] MonitorFiles = new string[3]
  {
    Variables.FilePath + "\\DLL.dll",
    Variables.FilePath + "\\Driver.sys",
    Variables.FilePath + "\\IFEO.exe"
  };
  public static string IFEOApplication = Variables.FilePath + "\\IFEO.exe";
  public static int IFEOLastCheck = 0;
  public static bool Running = Process.GetProcessesByName("Spark").Length > 1;
  public static int BetweenPayloads = 25000;
  public static bool x64 = Environment.Is64BitOperatingSystem;
  public static bool ErrorSoundsRunning = false;
  public static bool ShowAllWindowsRan = false;
  public static bool SendMessageRunning = false;
  public static bool ShootingStarsRunning = false;
}
