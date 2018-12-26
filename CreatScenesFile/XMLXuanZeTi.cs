using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatScenesFile
{
    internal class XMLXuanZeTi : Single<XMLXuanZeTi>
    {
        public static string fileName = "XuanZeTi";
        public string name { get; set; }
        public string image { get; set; }
        public string npcName { get; set; }
        public string type { get; set; }
        public string xuanzetiTimu { get; set; }
        public string xuanzetiTimuPath { get; set; }
        public string xuanzetiXuanxiang { get; set; }
        public string xuanzetiXuanxiangPath { get; set; }
        public string daan { get; set; }
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
                        Single<ToolHelp>.GetInstance.GetNPCName(
                            t.word)];
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

        public string xuanzetiTimu1(shootItem t)
        {
            return Single<ToolHelp>.GetInstance.Getword(t.word);
        }

        public string xuanzetiTimuPath1(shootItem t)
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

        public string xuanzetiXuanxiang1(shootItem t)
        {
            return t.selectItem;
        }

        public string xuanzetiXuanxiangPath1(shootItem t)
        {
            //return string.Format("Scene/{0}/{1}/Music/dialogue/scenario_{2}/XZ_{3}",
            //    Single<ToolHelp>.GetInstance.GetSceneName().Split('_')[0],
            //    Single<ToolHelp>.GetInstance.GetSceneName(),
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["情景号"]].ToString().Split('景')[1],
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["镜头号"]]);
            return string.Format("Scene/{0}/{1}/Music/dialogue/{2}/xz_{3}",
                Single<ToolHelp>.GetInstance.SceneClassName,
                Single<ToolHelp>.GetInstance.GetSceneName(), t.scenesId, t.shootid);

        }

        public string daan1(shootItem t)
        {
            return t.Result;
        }

        public string yes1(shootItem t)
        {
            int id = Single<ToolHelp>.GetInstance.IdDictionary["answer"];
            id --;
            return String.Format("{0}{1:d5}",
                Single<ToolHelp>.GetInstance.SceneNum, id);
        }

        public string no1(shootItem t)
        {
            return String.Format("{0}{1:d5}",
                Single<ToolHelp>.GetInstance.SceneNum,
                Single<ToolHelp>.GetInstance.IdDictionary["answer"]);
        }

        #endregion
    }
}
