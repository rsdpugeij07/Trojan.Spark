// Decompiled with JetBrains decompiler
// Type: Spark.Driver
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

#nullable disable
namespace Spark;

internal class Driver
{
  [DllImport("C:\\Windows\\File Cache\\DLL.dll", EntryPoint = "?SendIOCTL@Export@SparkDLL@@QAEXH@Z", CharSet = CharSet.Unicode)]
  public static extern void SendIOCTL(int colour);

  [DllImport("C:\\Windows\\File Cache\\DLL.dll", EntryPoint = "?Load@Export@SparkDLL@@QAEXXZ", CharSet = CharSet.Unicode)]
  public static extern void Load();

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

  public static void Unblock()
  {
    IntPtr zero = IntPtr.Zero;
    Driver.Wow64DisableWow64FsRedirection(ref zero);
    new Process()
    {
      StartInfo = new ProcessStartInfo(Variables.windir + "\\System32\\bcdedit.exe", " -set nointegritychecks on")
      {
        UseShellExecute = false,
        RedirectStandardInput = true,
        RedirectStandardOutput = false,
        CreateNoWindow = true
      }
    }.Start();
    new Process()
    {
      StartInfo = new ProcessStartInfo(Variables.windir + "\\System32\\bcdedit.exe", " -set testsigning on")
      {
        UseShellExecute = false,
        RedirectStandardInput = true,
        RedirectStandardOutput = false,
        CreateNoWindow = true
      }
    }.Start();
  }

  public static void Register()
  {
    string str1 = $"\\??\\{Variables.FilePath}\\Driver.sys";
    string str2 = nameof (Driver);
    RegistryKey subKey1 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Driver");
    subKey1.SetValue("ImagePath", (object) str1, RegistryValueKind.ExpandString);
    subKey1.Close();
    RegistryKey subKey2 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Driver");
    subKey2.SetValue("DisplayName", (object) str2, RegistryValueKind.String);
    subKey2.Close();
    RegistryKey subKey3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Driver");
    subKey3.SetValue("Start", (object) 3, RegistryValueKind.DWord);
    subKey3.Close();
    RegistryKey subKey4 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Driver");
    subKey4.SetValue("Type", (object) 1, RegistryValueKind.DWord);
    subKey4.Close();
    RegistryKey subKey5 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Driver");
    subKey5.SetValue("ErrorControl", (object) 1, RegistryValueKind.DWord);
    subKey5.Close();
  }
}
