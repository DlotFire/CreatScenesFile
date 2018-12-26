using System.Data;

namespace CreatScenesFile
{
    class XMLGuochangdonghua : Single<XMLGuochangdonghua>
    {
        public static string fileName = "Guochangdonghua";
        //public string name { get; set; }
        //public string image { get; set; }
        //public string chatPoint { get; set; }
        //public string type { get; set; }
        public string details { get; set; }
        public string path { get; set; }
        //public string cameraState { get; set; }

        #region 各个属性的值

        //public string name1(shootItem t)
        //{
        //    return Single<ToolHelp>.GetInstance.GetNPCName(t.word);
        //}

        //public string image1(shootItem t)
        //{
        //    if (Single<NPCName>.GetInstance.NpcNameDictionary.
        //        ContainsKey(Single<ToolHelp>.GetInstance.GetNPCName(t.word)))
        //    {
        //        return Single<NPCName>.GetInstance.NpcNameDictionary
        //            [Single<ToolHelp>.GetInstance.GetNPCName(t.word)];
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

        //public string type1(shootItem t)
        //{
        //    return "equipment";
        //}

        public string details1(shootItem t)
        {
            return t.TeachWord;
        }

        public string path1(shootItem t)
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

        //public string cameraState1(shootItem t)
        //{
        //    return Single<ToolHelp>.GetInstance.GetCameraNumber(t[Single<ToolHelp>.GetInstance.IdDictionary["镜头号"]].ToString());
        //}

        #endregion
    }
}
