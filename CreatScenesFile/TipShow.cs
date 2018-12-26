using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreatScenesFile
{
    public partial class TipShow : Form
    {
        private static TipShow tip;
        public static TipShow Tip
        {
            get
            {
                if (tip == null)
                    tip = new TipShow();

                return tip;
            }
        }

        private TipShow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 向提示窗口添加内容
        /// </summary>
        /// <param name="word"></param>
        public void TipShowWord(string word)
        {
            richTextBox1.AppendText(word);
            richTextBox1.AppendText("\n");
        }
        
    }
}
