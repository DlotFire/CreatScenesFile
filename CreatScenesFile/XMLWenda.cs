using System.Data;

namespace CreatScenesFile
{
    class XMLWenda : Single<XMLWenda>
    {
        public static string fileName = "WenDa";
        public string name { get; set; }
        public string image { get; set; }
        public string npcName { get; set; }
        public string type { get; set; }
        public string wendatimu { get; set; }
        public string wendatimuMusic { get; set; }
        public string wendaTishi { get; set; }
        public string wendatishiMusic { get; set; }
        public string wendajingtou { get; set; }

        #region 各个属性的值

        public string name1(shootItem t)
        {
            return Single<ToolHelp>.GetInstance.GetNPCName(t.word);
        }

        public string image1(shootItem t)
        {
            if (Single<NPCName>.GetInstance.NpcNameDictionary.
                ContainsKey(Single<ToolHelp>.GetInstance.GetNPCName(t.word)))
            {
                return Single<NPCName>.GetInstance.NpcNameDictionary
                    [Single<ToolHelp>.GetInstance.GetNPCName(t.word)];
            }
            else
            {
                return "moshengnanzi";
            }


        }

        public string npcName1(shootItem t)
        {
            return string.Format("{0}/Chat1", image1(t));
        }

        public string type1(shootItem t)
        {
            return "equipment";
        }

        public string wendatimu1(shootItem t)
        {
            return Single<ToolHelp>.GetInstance.Getword(t.word);
        }

        public string wendatimuMusic1(shootItem t)
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

        public string wendaTishi1(shootItem t)
        {
            return t.TeachWord;
        }

        public string wendatishiMusic1(shootItem t)
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

        public string wendajingtou1(shootItem t)
        {
            return Single<ToolHelp>.GetInstance.GetCameraNumber(t.shootid, true);
        }

        #endregion
    }
}
