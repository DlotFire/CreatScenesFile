using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatScenesFile
{
    class XMLDealWith_T:Single<XMLDealWith_T>
    {
        public static string fileName = "DealWith_T";
        public string pageIds { get; set; }
        public string nextShoot { get; set; }

        #region 各个属性的值
        
        public string pageIds1(shootItem t)
        {
            string[] pageIdContent = new string[Single<ToolHelp>.GetInstance.IdDictionary["当前应对界面页面数"]];
            int pageId = Single<ToolHelp>.GetInstance.IdDictionary["dealwith_c"];
            for (int i = Single<ToolHelp>.GetInstance.IdDictionary["当前应对界面页面数"] - 1; i >= 0 ; i--)
            {
                pageIdContent[i] = string.Format("{0}{1:d5}",
                    Single<ToolHelp>.GetInstance.SceneNum, pageId);
                pageId--;
                if (pageId < 0) break;
            }
            string pageIDStr = null;
            for (int i = 0; i < pageIdContent.Length; i++)
            {
                if (i == 0)
                {
                    pageIDStr = pageIdContent[i];
                }
                else
                {
                    pageIDStr += "," + pageIdContent[i];
                }
            }
            return pageIDStr;
        }

        public string nextShoot1(shootItem t)
        {
            return Single<ToolHelp>.GetInstance.GetCameraNumber(t.shootid, true);
        }
        
        #endregion
    }
}
