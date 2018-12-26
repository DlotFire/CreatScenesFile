using System;
using System.Data;

namespace CreatScenesFile
{
    class XMLQuestion : Single<XMLQuestion>
    {
        public static string fileName = "Question";
        public string name { get; set; }
        public string image { get; set; }
        public string npcName { get; set; }
        public string type { get; set; }
        public string details { get; set; }
        public string path { get; set; }
        public string yes { get; set; }
        public string no { get; set; }


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
                    [
                        Single<ToolHelp>.GetInstance.GetNPCName(t.word)];
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

        public string details1(shootItem t)
        {
            //return Single<ToolHelp>.GetInstance.Getword(t[Single<ToolHelp>.GetInstance.IdDictionary["对白"]].ToString());
            return Single<ToolHelp>.GetInstance.Getword(t.word);
        }

        public string path1(shootItem t)
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

        public string yes1(shootItem t)
        {
            return String.Format("{0}{1:d5}",
                Single<ToolHelp>.GetInstance.SceneNum, PdIdNumber(t)[0]);

        }

        public string no1(shootItem t)
        {
            return String.Format("{0}{1:d5}",
                Single<ToolHelp>.GetInstance.SceneNum, PdIdNumber(t)[1]);

        }

        /// <summary> 选择answer这个配制表ID在Question配制的位置 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private int[] PdIdNumber(shootItem t)
        {
            int[] id = new int[2];
            switch (t.Result)
            {
                case "正确":
                    id[0] = Single<ToolHelp>.GetInstance.IdDictionary["answer"];
                    id[0]--;
                    id[1]= Single<ToolHelp>.GetInstance.IdDictionary["answer"];
                    break;
                case "错误":
                    id[1] = Single<ToolHelp>.GetInstance.IdDictionary["answer"];
                    id[1]--;
                    id[0] = Single<ToolHelp>.GetInstance.IdDictionary["answer"];
                    break;
            }
            return id;
        }

        #endregion
    }
}
