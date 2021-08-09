﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Titanfall2_SkinTool.Titanfall2.WeaponData;

namespace Titanfall2_SkinTool
{
    public partial class MainWindow : Form
    {
        string msg;
        string GamePath;
        string filePath = Environment.CurrentDirectory;
        public string filename = "default";
        int DDSFolderExist = 0;
        string[,] FilePath = new string[3, 7];
        string[] ImageCheck = new string[3];//2为2048x2048,1为1024x1024,0为512x512
        System.Resources.ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        public MainWindow()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
            this.label1.Text = rm.GetString("label");
            this.Text = rm.GetString("Form");
            this.Menu_Setting.Text = rm.GetString("MenuSet");
            this.Menu_SettingGamePath.Text = rm.GetString("MenuSetPath");
            this.Menu_About.Text = rm.GetString("MenuAbout");
            this.Menu_Author.Text = rm.GetString("MenuAboutAuthor");
            this.ToolLanguageMenu.Text = rm.GetString("Language");
            this.LanguageChinese.Text = rm.GetString("Chinese");
            this.LanguageEnglish.Text = rm.GetString("English");
            this.Test.Text = rm.GetString("ImportBtn");
            this.LanguageChinese.Checked = true;
            if (System.IO.File.Exists($"{filePath}\\Path.txt") == true)
            {
                GamePath = File.ReadAllText($"{filePath}\\Path.txt");
                textBox1.AppendText(rm.GetString("GameLoadSuccess") + "\r\n");
            }
            else
            {
                textBox1.AppendText(rm.GetString("SetGamePath") + "\r\n");
            }
        }

        private void SkinFileSelect_FileOk(object sender, CancelEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkinFileSelect.ShowHelp = false;
            SkinFileSelect.InitialDirectory = @"F:\";
            SkinFileSelect.Filter = rm.GetString("Skin")+"(*.zip)|*.zip";
            SkinFileSelect.Title = rm.GetString("OpenFile");
            SkinFileSelect.Multiselect = false;
            SkinFileSelect.RestoreDirectory = true;
            if (this.SkinFileSelect.ShowDialog() == DialogResult.OK)
            {
                PathText.Text = this.SkinFileSelect.FileName;
                Array.Clear(ImageCheck, 0, ImageCheck.Length);
                Array.Clear(FilePath,0,FilePath.Length);

            }
        }

        private void Menu_SettingGamePath_Click(object sender, EventArgs e)
        {
            SkinFileSelect.ShowHelp = false;
            SkinFileSelect.InitialDirectory = @"F:\"; 
            SkinFileSelect.Filter = rm.GetString("Game")+"(Titanfall2.exe)|Titanfall2.exe";
            SkinFileSelect.Title = rm.GetString("OpenFile");
            SkinFileSelect.Multiselect = false;
            SkinFileSelect.RestoreDirectory = true;
            if (this.SkinFileSelect.ShowDialog() == DialogResult.OK)
            {
                GamePath = System.IO.Path.GetDirectoryName(this.SkinFileSelect.FileName);

                File.WriteAllText($"{filePath}\\Path.txt", GamePath);
                textBox1.AppendText(rm.GetString("GameLoadSuccess") + "\r\n");

                Console.WriteLine(GamePath);
            }
        }

        private void Menu_Author_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者：zxcPandora\r\nDiscord：zxcPandora#1581\r\nBilibili：极度分裂的潘多拉\r\nWeaponData:MrSteyk's Tool", "关于作者", MessageBoxButtons.OK);
        }

        private void Test_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(GamePath + "\\Titanfall2.exe"))
                    throw new MyException(rm.GetString("GameLoadFailed"));
                if (!File.Exists(PathText.Text) || PathText.Text == "")
                    throw new MyException(rm.GetString("ZipLoadFailed"));
                try
                {
                    // 打开zip文件
                    ZipArchive archive = ZipFile.OpenRead(PathText.Text);
                    // 获取文件列表
                    var files = archive.Entries;
                    // 显示列表
                    string lastfilename = "test";
                    int check = 0;
                    int lastcheck = 0;
                    int i = 0;
                    int total = 0;

                    foreach (ZipArchiveEntry zav in files)
                    {
                        textBox1.AppendText(zav.FullName.Replace("/", "\\") + "\r\n");
                        if (zav.Name.Contains(".dds"))
                        {
                            if (check == 1)
                                lastcheck = 1;
                            check = 1;
                        }
                        else
                        {
                            lastfilename = zav.FullName;
                            lastfilename = lastfilename.Replace("/", "\\");
                            check = 0;
                            lastcheck = 0;
                            total = 0;
                        }
                        if (check == 1 && lastcheck == 0)
                        {
                            Console.WriteLine(lastfilename);

                        }
                        if (check == 1)
                        {
                            if (lastfilename.Contains("512"))
                            {
                                ImageCheck[0] = lastfilename;
                                FilePath[0, total] = zav.Name;
                            }

                            if (lastfilename.Contains("1024"))
                            {
                                ImageCheck[1] = lastfilename;
                                FilePath[1, total] = zav.Name;
                            }
                            if (lastfilename.Contains("2048"))
                            {
                                ImageCheck[2] = lastfilename;
                                FilePath[2, total] = zav.Name;
                            }
                            total++;
                        }
                    }
                    //ZipList.Items = files;
                    textBox1.AppendText(rm.GetString("ZipReadSuccess") + "\r\n");
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }

                for (int i = 0; i <= 2; i++)
                {
                    DDSFolderExist = 0;
                    if (ImageCheck[i] != null)
                    { DDSFolderExist++; }
                }
                if (DDSFolderExist == 0)
                {
                    throw new MyException(rm.GetString("FindSkinFailed"));
                }

                string ExtractPath = filePath + "\\"+ rm.GetString("SaveFolder");
                if (!Directory.Exists(ExtractPath))
                {
                    Directory.CreateDirectory(ExtractPath);
                }
                try
                {
                    ZipFile.ExtractToDirectory(PathText.Text, ExtractPath);
                    //textBox1.AppendText(ExtractPath+"\\"+filename + "\r\n");
                    textBox1.AppendText(rm.GetString("ZipLoadSuccess") + "\r\n");
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }
                for (int i = 0; i <= 2; i++)
                {
                    if (ImageCheck[i] != null)
                    {
                        int folder = 4;
                        //string result = System.Text.RegularExpressions.Regex.Replace(ImageCheck[i], @"[^0-9]+", "");
                        if(ImageCheck[i].LastIndexOf("\\") - folder == -1)
                        {
                            folder = 3;
                        }
                        string result = ImageCheck[i].Substring((ImageCheck[i].LastIndexOf("\\") - folder)).Replace("\\", "");
                        int imagecheck = Convert.ToInt32(result);
                        Console.WriteLine(imagecheck);

                        if (imagecheck == 512)
                            imagecheck = 0;
                        if (imagecheck == 1024)
                            imagecheck = 1;
                        if (imagecheck == 2048)
                            imagecheck = 2;
                        for (int j = 0; FilePath[i, j] != null; j++)
                        {
                            //传递数组内容
                            WeaponDataControl wdc = new WeaponDataControl(FilePath[i, j], imagecheck);
                            Int64 toseek = Convert.ToInt64(wdc.FilePath[0, 1]);
                            int tolength = Convert.ToInt32(wdc.FilePath[0, 2]);
                            int totype = Convert.ToInt32(wdc.FilePath[0, 3]);
                            string reallypath = ExtractPath + "\\" + ImageCheck[i] + FilePath[i, j];
                            StarpakControl sc = new StarpakControl(reallypath, toseek, tolength, totype, GamePath);

                            Console.WriteLine(reallypath);
                            Console.WriteLine(toseek);
                            Console.WriteLine(tolength);
                            Console.WriteLine(totype);
                            Console.WriteLine(GamePath);
                        }
                    }

                }
                msg = rm.GetString("InstallSuccess");
                textBox1.AppendText(msg + "\r\n");
                MessageBox.Show(msg, rm.GetString("Tip"), MessageBoxButtons.OK);
            }
            catch (MyException myException)
            {
                MessageBox.Show(myException.Message);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            GC.Collect();
        }

        private void LanguageChinese_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
            this.label1.Text = rm.GetString("label");
            this.Text = rm.GetString("Form");
            this.Menu_Setting.Text = rm.GetString("MenuSet");
            this.Menu_SettingGamePath.Text = rm.GetString("MenuSetPath");
            this.Menu_About.Text = rm.GetString("MenuAbout");
            this.Menu_Author.Text = rm.GetString("MenuAboutAuthor");
            this.ToolLanguageMenu.Text = rm.GetString("Language");
            this.LanguageChinese.Text = rm.GetString("Chinese");
            this.LanguageEnglish.Text = rm.GetString("English");
            this.Test.Text = rm.GetString("ImportBtn");
            this.LanguageChinese.Checked = true;
            this.LanguageEnglish.Checked = false;
        }

        private void LanguageEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            this.label1.Text = rm.GetString("label");
            this.Text = rm.GetString("Form");
            this.Menu_Setting.Text = rm.GetString("MenuSet");
            this.Menu_SettingGamePath.Text = rm.GetString("MenuSetPath");
            this.Menu_About.Text = rm.GetString("MenuAbout");
            this.Menu_Author.Text = rm.GetString("MenuAboutAuthor");
            this.ToolLanguageMenu.Text = rm.GetString("Language");
            this.LanguageChinese.Text = rm.GetString("Chinese");
            this.LanguageEnglish.Text = rm.GetString("English");
            this.Test.Text = rm.GetString("ImportBtn");
            this.LanguageChinese.Checked = false;
            this.LanguageEnglish.Checked = true;
        }
    }
}