using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CreatScenesFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取Excell表路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ExcelOpenFileSelec_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            path.ShowDialog();
            textBox_inputPath.Text = path.FileName;
        }

        /// <summary>
        /// 获取输出目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DicrtPath = new FolderBrowserDialog();
            DicrtPath.ShowDialog();
            textBox_outputPath.Text = DicrtPath.SelectedPath;
        }

        /// <summary>
        /// 生成XML表按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buildXML_Click(object sender, EventArgs e)
        {
            intPath();
            CreatXml();
        }

        /// <summary>
        /// 生成脚本按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buildScript_Click(object sender, EventArgs e)
        {
            intPath();
            CreatScript();
            TipShow.Tip.Show();
        }

        /// <summary>
        /// 生成音频按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buildmusic_Click(object sender, EventArgs e)
        {
            intPath();
            CreatAudio();
        }

        /// <summary>
        /// 一键生成全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_allBuild_Click(object sender, EventArgs e)
        {
            intPath();
            CreatXml();
            CreatAudio();
            CreatScript();
        }

        /// <summary>
        /// 初始化输入、输出路径给toolHelp
        /// </summary>
        private void intPath()
        {
            Single<ToolHelp>.GetInstance.InputPath = textBox_inputPath.Text;
            Single<ToolHelp>.GetInstance.OutputPath = textBox_outputPath.Text.Replace("\\", "/");
            Single<ToolHelp>.GetInstance.SceneNum = ComBoxNum.SelectedIndex.ToString();
            Single<ToolHelp>.GetInstance.SceneRang = ComBoxRang.SelectedIndex.ToString();
            Single<ToolHelp>.GetInstance.SceneClassName = textBox_SceneClassName.Text.ToString();
            Single<ToolHelp>.GetInstance.ScenePartName = textBox_ScenesPartName.Text.ToString();
            TipShow.Tip.TipShowWord("输入文件路径：" + Single<ToolHelp>.GetInstance.InputPath);
            TipShow.Tip.TipShowWord("输出文件路径：" + Single<ToolHelp>.GetInstance.OutputPath);
        }

        /// <summary>
        /// 生成配制表
        /// </summary>
        private void CreatXml()
        {
            string istr;
            TipShow.Tip.Show();
            for (int i = 1; i < 100; i++)
            {
                istr = string.Format("shoot{0:d3}", i);
                if (Single<LoadExcell>.GetInstance.InfoDict.ContainsKey(istr))
                {
                    TipShow.Tip.TipShowWord(Single<LoadExcell>.GetInstance.InfoDict[istr].shootid);
                    //TipShow.Tip.TipShowWord(Single<LoadExcell>.GetInstance.InfoDict[istr].scenesId);
                    //TipShow.Tip.TipShowWord(Single<LoadExcell>.GetInstance.InfoDict[istr].word);
                    //TipShow.Tip.TipShowWord(Single<LoadExcell>.GetInstance.InfoDict[istr].type);
                    //TipShow.Tip.TipShowWord(Single<LoadExcell>.GetInstance.InfoDict[istr].selectItem);
                    //TipShow.Tip.TipShowWord(Single<LoadExcell>.GetInstance.InfoDict[istr].Result);
                    //TipShow.Tip.TipShowWord(Single<LoadExcell>.GetInstance.InfoDict[istr].TeachWord);

                    Single<merge>.GetInstance.selectDetails(Single<LoadExcell>.GetInstance.InfoDict[istr]);

                    TipShow.Tip.TipShowWord("------------------\n");
                }
            }
        }
        
        /// <summary>
        /// 生成脚本
        /// </summary>
        private void CreatScript()
        {
            Single<EditorContent>.GetInstance.editConten();
        }

        /// <summary>
        /// 生成音频
        /// </summary>
        private void CreatAudio()
        {
            Single<CreatAudio>.GetInstance.CreatAudioMain();
        }
        
    }
}
