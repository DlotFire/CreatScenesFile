
using System.Data;

namespace CreatScenesFile
{
    class XMLWiseManAsk:Single<XMLWiseManAsk>
    {
        public static string fileName = "WiseManAsk";
        //public string name { get; set; }
        //public string image { get; set; }
        //public string chatPoint { get; set; }
        public string type { get; set; }
        public string bTip { get; set; }
        public string askdetails { get; set; }
        public string askdetailsPath { get; set; }
        public string answerdetails { get; set; }
        public string answerdetailsPath { get; set; }


        #region 各个属性的值

        //public string name1(shootItem t)
        //{
        //    return Single<ToolHelp>.GetInstance.GetNPCName(t[Single<ToolHelp>.GetInstance.IdDictionary["对白"]].ToString());
        //}

        //public string image1(shootItem t)
        //{
        //    if (Single<NPCName>.GetInstance.NpcNameDictionary.
        //        ContainsKey(Single<ToolHelp>.GetInstance.GetNPCName(t[Single<ToolHelp>.GetInstance.IdDictionary["对白"]].ToString())))
        //    {
        //        return Single<NPCName>.GetInstance.NpcNameDictionary
        //            [Single<ToolHelp>.GetInstance.GetNPCName(t[Single<ToolHelp>.GetInstance.IdDictionary["对白"]].ToString())];
        //    }
        //    else
        //    {
        //        return "？？";
        //    }


        //}

        //public string chatPoint1(shootItem t)
        //{
        //    return string.Format("{0}/Chat1", image1(t));
        //}

        public string type1(shootItem t)
        {
            return "1";
        }

        public string bTip1(shootItem t)
        {
            return "false";
        }

        public string askdetails1(shootItem t)
        {
            return Single<ToolHelp>.GetInstance.Getword(t.word);
        }

        public string askdetailsPath1(shootItem t)
        {
            //return string.Format("Scene/{0}/{1}/Music/dialogue/scenario_{2}/{3}",
            //    Single<ToolHelp>.GetInstance.GetSceneName().Split('_')[0],
            //    Single<ToolHelp>.GetInstance.GetSceneName(),
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["情景号"]].ToString().Split('景')[1],
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["镜头号"]]);
            return string.Format("Scene/{0}/{1}/Music/dialogue/{2}/{3}",
                Single<ToolHelp>.GetInstance.SceneClassName,
                Single<ToolHelp>.GetInstance.GetSceneName(), t.scenesId, t.shootid);

        }

        public string answerdetails1(shootItem t)
        {
            return t.TeachWord;
        }

        public string answerdetailsPath1(shootItem t)
        {
            //return string.Format("Scene/{0}/{1}/Music/answer/scenario_{2}/{3}",
            //    Single<ToolHelp>.GetInstance.GetSceneName().Split('_')[0],
            //    Single<ToolHelp>.GetInstance.GetSceneName(),
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["情景号"]].ToString().Split('景')[1],
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["镜头号"]]);
            return string.Format("Scene/{0}/{1}/Music/answer/{2}/{3}",
                Single<ToolHelp>.GetInstance.SceneClassName,
                Single<ToolHelp>.GetInstance.GetSceneName(), t.scenesId, t.shootid);

        }

        #endregion
    }
}
