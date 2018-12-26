using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;
using System.Xml;

namespace CreatScenesFile
{
    class CreatAudio : Single<CreatAudio>
    {
        private List<string> FileList;
        private string MusicPath01;
        private string MusicWord01;
        private string MusicPath02;
        private string MusicWord02;

        public void CreatAudioMain()
        {
            //Console.WriteLine("请输入存放配制表文件夹路径：");
            //Console.WriteLine("如：C:/XMLFile");
            //Path = Console.ReadLine();

            TipShow.Tip.Show();
            ShowFileName();
            if (FileList.Count != 0)
                for (int i = 0; i < FileList.Count; i++)
                {
                    eachXMLLoad(FileList[i]);
                    //Console.WriteLine(FileList[i]);
                }

        }

        /// <summary>
        ///  读取C盘XMLFile文件下的所有文件名，并存到FileList里面
        /// </summary>
        private void ShowFileName()
        {
            if (!Directory.Exists(Single<ToolHelp>.GetInstance.OutputPath)) //是否有放XML的文件夹
                Directory.CreateDirectory(Single<ToolHelp>.GetInstance.OutputPath);

            DirectoryInfo info = new DirectoryInfo(Single<ToolHelp>.GetInstance.OutputPath);
            FileInfo[] fili = info.GetFiles();
            FileList = new List<string>();
            for (int i = 0; i < fili.Length; i++)
            {
                FileList.Add(fili[i].Name);
                //Console.WriteLine(fili[i].Name);
            }
        }

        /// <summary>
        /// 加载XML
        /// </summary>
        /// <param name="path"></param>
        private void eachXMLLoad(string Name)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(Single<ToolHelp>.GetInstance.OutputPath + "/" + Name);
            string FileName = Name.Split('.')[0].ToLower();
            XmlNode xmlNode = xmldoc.SelectSingleNode("root");
            XmlNodeList xmlNodes = xmlNode.SelectNodes(FileName);
            for (int i = 0; i < xmlNodes.Count; i++)
            {
                for (int j = 0; j < xmlNodes[i].ChildNodes.Count; j++)
                {
                    //第一个音频
                    if (xmlNodes[i].ChildNodes[j].Name == "details" ||
                        xmlNodes[i].ChildNodes[j].Name == "wendatimu" ||
                        xmlNodes[i].ChildNodes[j].Name == "askdetails" ||
                        xmlNodes[i].ChildNodes[j].Name == "xuanzetiTimu" ||
                        xmlNodes[i].ChildNodes[j].Name == "contents")
                    {
                        MusicWord01 = xmlNodes[i].ChildNodes[j].InnerText;
                    }
                    if (xmlNodes[i].ChildNodes[j].Name == "path" ||
                        xmlNodes[i].ChildNodes[j].Name == "wendatimuMusic" ||
                        xmlNodes[i].ChildNodes[j].Name == "askdetailsPath" ||
                        xmlNodes[i].ChildNodes[j].Name == "xuanzetiTimuPath" ||
                        xmlNodes[i].ChildNodes[j].Name == "contentPaths")
                    {
                        MusicPath01 = Single<ToolHelp>.GetInstance.OutputPath + "/" + xmlNodes[i].ChildNodes[j].InnerText;
                    }
                    //第二个音频；如果存在
                    if (xmlNodes[i].ChildNodes[j].Name == "wendaTishi" ||
                        xmlNodes[i].ChildNodes[j].Name == "answerdetails" ||
                        xmlNodes[i].ChildNodes[j].Name == "xuanzetiXuanxiang")
                    {
                        MusicWord02 = xmlNodes[i].ChildNodes[j].InnerText;
                    }
                    if (xmlNodes[i].ChildNodes[j].Name == "wendatishiMusic" ||
                        xmlNodes[i].ChildNodes[j].Name == "answerdetailsPath" ||
                        xmlNodes[i].ChildNodes[j].Name == "xuanzetiXuanxiangPath")
                    {
                        MusicPath02 = Single<ToolHelp>.GetInstance.OutputPath + "/" + xmlNodes[i].ChildNodes[j].InnerText;
                    }
                }

                if (MusicPath01 != null && MusicWord01 != null)
                {
                    CreatSpeechSyn(MusicPath01, MusicWord01);
                    //Console.WriteLine(MusicWord01);
                }
                if (MusicPath02 != null && MusicWord02 != null)
                {
                    CreatSpeechSyn(MusicPath02, MusicWord02);
                    //Console.WriteLine(MusicWord02);
                }
                //TipShow.Tip.TipShowWord("word01:" + MusicWord01);
                //TipShow.Tip.TipShowWord("word02" + MusicWord02);
                MusicPath01 = null;
                MusicWord01 = null;
                MusicPath02 = null;
                MusicWord02 = null;

                if (FileName == "answer")     //因为answer这个配制表有两个相同的节点，所以要跳过一个
                    i++;
            }
        }

        /// <summary>
        /// 创建音频
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="SpeechWord">音频内容</param>
        private static void CreatSpeechSyn(string path, string SpeechWord)
        {
            string BoolFilePath = path.Split('/')[path.Split('/').Length - 1];
            if (!Directory.Exists(path.Remove(path.Length - BoolFilePath.Length)))
                Directory.CreateDirectory(path.Remove(path.Length - BoolFilePath.Length));

            TipShow.Tip.TipShowWord("正在生成MP3音频： \n" + SpeechWord);

            if (SpeechWord.Contains("S\\n"))
            {
                SpeechWord = SpeechWord.Replace("S\\n", "*");
            }
            if (SpeechWord.Contains("\\n"))
            {
                SpeechWord = SpeechWord.Replace("\\n", "");
            }
            string[] speechWords = SpeechWord.Split('*');
            string NewPathName = path;
            for (int i = 0; i < speechWords.Length; i++)
            {
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Volume = 100;
                for (int j = 0; j < i; j++)
                {
                    NewPathName += 1;
                }
                speech.SetOutputToWaveFile(NewPathName + ".mp3");
                speech.Speak(speechWords[i]);
                //speech.SetOutputToDefaultAudioDevice();
                speech.Dispose();

                TipShow.Tip.TipShowWord("正在生成MP3音频： \n" + speechWords[i]);
                NewPathName = path;
            }
        }
    }
}
