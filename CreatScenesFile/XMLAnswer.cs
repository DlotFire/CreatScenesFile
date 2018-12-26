using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatScenesFile
{
    class XMLAnswer : Single<XMLAnswer>
    {
        public static string fileName = "Answer";
        public string name { get; set; }
        public string image { get; set; }
        public string type { get; set; }
        public string YesOrNoID { get; set; }
        public string typePath { get; set; }
        public string details { get; set; }
        public string path { get; set; }
        public string cutCamera { get; set; }
        public string cameraState { get; set; }

        #region 各个属性的值

        public string name1(shootItem t)
        {
            return "老师";
        }

        public string image1(shootItem t)
        {
            if (boolCorrect())
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }
        
        public string type1(shootItem t)
        {
            if (boolCorrect())
            {
                return "[00ff00]回答正确，你真棒！[-]";
            }
            else
            {
                return "[ff0000]很遗憾，回答错误！[-]";
            }
        }

        public string YesOrNoID1(shootItem t)
        {
            if (boolCorrect())
            {
                return "100011";
            }
            else
            {
                return "100012";
            }
        }

        public string typePath1(shootItem t)
        {
            if (boolCorrect())
            {
                return "Music/Teach/回答正确";
            }
            else
            {
                return "Music/Teach/回答错误";
            }
        }

        public string details1(shootItem t)
        {
            //return t[Single<ToolHelp>.GetInstance.IdDictionary["判断题_系"]].ToString();
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

        public string cutCamera1(shootItem t)
        {
            return "CameraCube";
        }

        public string cameraState1(shootItem t)
        {
            //return Single<ToolHelp>.GetInstance.GetCameraNumber(
            //    t[Single<ToolHelp>.GetInstance.IdDictionary["镜头号"]].ToString(), true);
            return Single<ToolHelp>.GetInstance.GetCameraNumber(t.shootid, true);
        }

        /// <summary> answer这个配制表是不是正确这个节点
        /// </summary>
        /// <returns></returns>
        private bool boolCorrect()
        {
            if (Single<ToolHelp>.GetInstance.IdDictionary["answer"] % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}
