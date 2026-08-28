// Decompiled with JetBrains decompiler
// Type: Spark.Properties.Resources
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Spark.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  internal Resources()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (Spark.Properties.Resources.resourceMan == null)
        Spark.Properties.Resources.resourceMan = new ResourceManager("Spark.Properties.Resources", typeof (Spark.Properties.Resources).Assembly);
      return Spark.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Spark.Properties.Resources.resourceCulture;
    set => Spark.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap Card1
  {
    get => (Bitmap) Spark.Properties.Resources.ResourceManager.GetObject(nameof (Card1), Spark.Properties.Resources.resourceCulture);
  }

  internal static Bitmap Card2
  {
    get => (Bitmap) Spark.Properties.Resources.ResourceManager.GetObject(nameof (Card2), Spark.Properties.Resources.resourceCulture);
  }

  internal static Bitmap Card3
  {
    get => (Bitmap) Spark.Properties.Resources.ResourceManager.GetObject(nameof (Card3), Spark.Properties.Resources.resourceCulture);
  }

  internal static Bitmap Card4
  {
    get => (Bitmap) Spark.Properties.Resources.ResourceManager.GetObject(nameof (Card4), Spark.Properties.Resources.resourceCulture);
  }

  internal static byte[] DLL
  {
    get => (byte[]) Spark.Properties.Resources.ResourceManager.GetObject(nameof (DLL), Spark.Properties.Resources.resourceCulture);
  }

  internal static byte[] Driver_x64
  {
    get
    {
      return (byte[]) Spark.Properties.Resources.ResourceManager.GetObject(nameof (Driver_x64), Spark.Properties.Resources.resourceCulture);
    }
  }

  internal static byte[] Driver_x86
  {
    get
    {
      return (byte[]) Spark.Properties.Resources.ResourceManager.GetObject(nameof (Driver_x86), Spark.Properties.Resources.resourceCulture);
    }
  }

  internal static Icon icon
  {
    get => (Icon) Spark.Properties.Resources.ResourceManager.GetObject(nameof (icon), Spark.Properties.Resources.resourceCulture);
  }

  internal static byte[] IFEO
  {
    get => (byte[]) Spark.Properties.Resources.ResourceManager.GetObject(nameof (IFEO), Spark.Properties.Resources.resourceCulture);
  }

  internal static Bitmap Star
  {
    get => (Bitmap) Spark.Properties.Resources.ResourceManager.GetObject(nameof (Star), Spark.Properties.Resources.resourceCulture);
  }
}
