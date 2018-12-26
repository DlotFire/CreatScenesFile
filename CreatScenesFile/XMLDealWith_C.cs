using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatScenesFile
{
    class XMLDealWith_C:Single<XMLDealWith_C>
    {
        private int index = -1;//每页的索引
        public static string fileName = "DealWith_C";
        public string titls { get; set; }
        public string contents { get; set; }
        public string contentPiont { get; set; }
        public string contentPaths { get; set; }
        public string ImgPiont { get; set; }
        public string ImgSize { get; set; }
        public string ImgPaths { get; set; }
        public string nextShoot { get; set; }

        #region 各个属性的值

        public string titls1(shootItem t)
        {
            return "温馨提示,-131*306";
        }

        public string contents1(shootItem t)
        {
            index = Single<ToolHelp>.GetInstance.dictionaryId("当前应对界面索引");
            index--;
            string contents = t.TeachWord.ToString().Split('*')[index].ToString();
            if (index == Single<ToolHelp>.GetInstance.IdDictionary["当前应对界面页面数"]-1)
            {
                Single<ToolHelp>.GetInstance.IdDictionary["当前应对界面索引"] = 0;   //使用完后把索引归零
            }
            return contents;
        }

        public string contentPiont1(shootItem t)
        {
            return "-454,207";
        }

        public string contentPaths1(shootItem t)
        {
            //return string.Format("Scene/{0}/{1}/Music/answer/scenario_{2}/{3}",
            //    Single<ToolHelp>.GetInstance.GetSceneName().Split('_').First(),
            //    Single<ToolHelp>.GetInstance.GetSceneName(),
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["情景号"]].ToString().Split('景').LastOrDefault(),
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["镜头号"]]);

            return string.Format("Scene/{0}/{1}/Music/answer/{2}/{3}",
                Single<ToolHelp>.GetInstance.SceneClassName,
                Single<ToolHelp>.GetInstance.GetSceneName(), t.scenesId, t.shootid);
        }

        public string ImgPiont1(shootItem t)
        {
            return "209*0";
        }

        public string ImgSize1(shootItem t)
        {
            return "512*512";
        }

        public string ImgPaths1(shootItem t)
        {
            //return string.Format("Scene/{0}/{1}/IMG/DealWith/1",
            //    Single<ToolHelp>.GetInstance.GetSceneName().Split('_')[0],
            //    Single<ToolHelp>.GetInstance.GetSceneName());
            return string.Format("Scene/{0}/{1}/IMG/DealWith/1",
                Single<ToolHelp>.GetInstance.SceneClassName,
                Single<ToolHelp>.GetInstance.GetSceneName());
        }

        public string nextShoot1(shootItem t)
        {
            return Single<ToolHelp>.GetInstance.GetCameraNumber(t.shootid, true);
        }
        
        #endregion
    }
}
