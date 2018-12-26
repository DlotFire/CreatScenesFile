using System;
using System.Collections.Generic;
using System.Linq;

namespace CreatScenesFile
{
    internal class ToolHelp : Single<ToolHelp>
    {
        private Dictionary<string, int> idDictionary; //ID字典，用于保存ID索引使用到多少
        public Dictionary<string, int> IdDictionary
        {
            get
            {
                if (idDictionary == null)
                {
                    idDictionary = new Dictionary<string, int>();
                }
                return idDictionary;
            }
            set { }
        }
        private int id;

        public string SceneNum;//期数
        public string SceneRang;//年级
        public string SceneClassName;//专题分类
        public string ScenePartName;//专题名字
        public string InputPath;//输入路径
        public string OutputPath;//输出路径
        
        /// <summary> 从对话中获取NPC名字 
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        public string GetNPCName(string details)
        {
            return details.Split('：')[0].Replace("os","");
        }

        /// <summary> 返回对话 
        /// </summary>
        /// <returns></returns>
        public string Getword(string details)
        {
            //return details.Substring(4, details.Length - 4);
            return details.Split('：').LastOrDefault();
        }

        /// <summary>
        /// 处理过的专题名字
        /// </summary>
        /// <returns></returns>
        public string GetSceneName()
        {
            return SceneClassName + "_" + SceneNum + "_" + SceneRang + "_" + ScenePartName;
        }

        /// <summary> 生成XML的路径 
        /// </summary>
        /// <returns></returns>
        public string xmlPath(string fileName)
        {
            return OutputPath + fileName + ".xml";
        }
        
        /// <summary> 返回增加或减少后的镜头号;ture为返回增加后的镜头号
        /// </summary>
        /// <returns></returns>
        public string GetCameraNumber(string Number, bool addNumber)
        {
            if (Number.Length < 7) return null;
            string NuberStr = Number.Substring(5, Number.Length - 5);
            int Nu = int.Parse(NuberStr.Split('_')[0]);
            if (addNumber)
            {
                Nu++;
            }
            else
            {
                Nu--;
            }
            return string.Format("shoot{0:d3}", Nu);
        }

        /// <summary> 获取下一个可用的id号 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int dictionaryId(string key)
        {
            if (IdDictionary.ContainsKey(key))
            {
                id = IdDictionary[key];
                id++;
                IdDictionary[key] = id;
            }
            else
            {
                id = 0;
                id++;
                IdDictionary.Add(key, id);
            }
            return id;
        }

        /// <summary>
        /// 获取字典，如果没有则返回1
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetDict(string key)
        {
            if (!IdDictionary.ContainsKey(key))
            {
                IdDictionary[key] = 1;
            }
            return IdDictionary[key];
        }
    }



    internal class NPCName : Single<NPCName>
    {
        private Dictionary<string, string> npcName;

        /// <summary> 所有NPC的名字（字典） 
        /// </summary>
        public Dictionary<string, string> NpcNameDictionary
        {
            get
            {
                if (npcName == null)
                {
                    npcName = GetDictionary();
                }
                return npcName;
            }
        }

        /// <summary> 添加键值对 
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("陈芳芳", NPC.chen_fang_fang.ToString());
            dictionary.Add("刘安全", NPC.liu_an_quan.ToString());
            dictionary.Add("刘嘉嘉", NPC.liu_jia_jia.ToString());
            dictionary.Add("曾小闲", NPC.zeng_xiao_xian.ToString());
            dictionary.Add("徐小富", NPC.xu_xiao_fu.ToString());
            dictionary.Add("徐小福", NPC.xu_xiao_fu2.ToString());
            dictionary.Add("杨小杰", NPC.yang_xiao_jie.ToString());
            dictionary.Add("李阿弟", NPC.li_a_di.ToString());
            dictionary.Add("夏美美", NPC.xia_mei_mei.ToString());
            dictionary.Add("刘鸿鸿", NPC.liu_hong_hong.ToString());
            dictionary.Add("刘弘弘", NPC.liu_hong_hong.ToString());

            dictionary.Add("吕老师", NPC.lu_lao_shi.ToString());
            dictionary.Add("老师", NPC.lu_lao_shi.ToString());
            dictionary.Add("蓝老师", NPC.lan_lao_shi.ToString());
            dictionary.Add("男医生", NPC.Male_doctor.ToString());
            dictionary.Add("女护士", NPC.Female_nurse.ToString());
            dictionary.Add("消防员", NPC.xiao_fang_yuan.ToString());
            dictionary.Add("曾大牛", NPC.zeng_da_niu.ToString());
            dictionary.Add("路人", NPC.lu_ren.ToString());
            dictionary.Add("警察", NPC.jing_cha.ToString());
            dictionary.Add("张贤惠", NPC.zhang_xian_hui.ToString());
            dictionary.Add("老司机", NPC.lao_si_ji.ToString());
            dictionary.Add("青年", NPC.qing_nian.ToString());
            dictionary.Add("刘稳健", NPC.liu_wen_jian.ToString());
            dictionary.Add("吴叔叔", NPC.wu_shu_shu.ToString());
            dictionary.Add("曾二牛", NPC.zeng_er_niu.ToString());
            dictionary.Add("莫生仁", NPC.mo_sheng_ren.ToString());
            dictionary.Add("陈国华", NPC.cheng_guo_hua.ToString());
            dictionary.Add("魏松南", NPC.wei_song_nan.ToString());
            dictionary.Add("高喜坤", NPC.gao_xi_kun.ToString());
            dictionary.Add("尹军智", NPC.yin_jun_zhi.ToString());
            dictionary.Add("蔡玉琴", NPC.cai_yu_qin.ToString());
            dictionary.Add("程少琪", NPC.cheng_shao_qi.ToString());
            dictionary.Add("刘美珠", NPC.liu_mei_zhu.ToString());
            dictionary.Add("单瑛", NPC.shan_ying.ToString());
            return dictionary;
        }
    }
    

    /// <summary>
    /// NPC列表
    /// </summary>
    public enum NPC
    {
        liu_an_quan,
        liu_jia_jia,
        zeng_xiao_xian,
        xu_xiao_fu,
        yang_xiao_jie,
        li_a_di,
        xia_mei_mei,
        chen_fang_fang,
        liu_hong_hong,

        lu_lao_shi,
        lan_lao_shi,
        Male_doctor,
        Female_nurse,
        xiao_fang_yuan,
        zeng_da_niu,
        lu_ren,
        jing_cha,
        zhang_xian_hui,
        lao_si_ji,
        qing_nian,
        liu_wen_jian,
        wu_shu_shu,
        zeng_er_niu,
        mo_sheng_ren,
        cheng_guo_hua,
        wei_song_nan,
        gao_xi_kun,
        yin_jun_zhi,
        cai_yu_qin,
        cheng_shao_qi,
        liu_mei_zhu,
        shan_ying,
        jiu_sheng_yuan,
        xu_xiao_fu2
    }
}