using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CreatScenesFile
{
    internal class merge
    {
        private string methodReturn;//调用的方法返回的值
        private string path;//生成XML的路径
        private string secondNodStr;//二级节点名字
        private int id;//ID号
        private Type type;//反射类
        private object obj;//实例化
        private object[] paramer = new object[1];//实参装箱 
        private PropertyInfo[] propertyInfos;//公共属性
        
        /// <summary> 给内容分类，如选择、判断、对白等 
        /// </summary>
        /// <param name="strType">题目类型</param>
        public void selectDetails(shootItem shootItm)
        {
            switch (shootItm.type)
            {
                case "log": //对白
                    {
                        creatXML(typeof(XMLDialog), shootItm);
                    }
                    break;

                case "pd": //判断
                    {
                        creatXML(typeof(XMLAnswer), shootItm);
                        creatXML(typeof(XMLAnswer), shootItm);
                        creatXML(typeof(XMLQuestion), shootItm);
                    }
                    break;

                case "xz": //选择
                    {
                        creatXML(typeof(XMLAnswer), shootItm);
                        creatXML(typeof(XMLAnswer), shootItm);
                        creatXML(typeof(XMLXuanZeTi), shootItm);
                    }
                    break;

                case "wd": //问答
                    {
                        creatXML(typeof(XMLWenda), shootItm);
                    }
                    break;

                case "tw": //智者提问
                    {
                        creatXML(typeof(XMLWiseManAsk), shootItm);

                    }
                    break;

                case "gc": //智者过场动画
                    {
                        creatXML(typeof(XMLGuochangdonghua), shootItm);

                    }
                    break;

                case "kp": //科普
                    {
                        creatXML(typeof(XMLkepu), shootItm);

                    }
                    break;
                case "wx": //应对界面
                    Single<ToolHelp>.GetInstance.IdDictionary["当前应对界面页面数"] = shootItm.TeachWord.Split('*').Length;

                    for (int i = 0; i < Single<ToolHelp>.GetInstance.IdDictionary["当前应对界面页面数"]; i++)
                    {
                        creatXML(typeof(XMLDealWith_C),shootItm);
                    }
                    creatXML(typeof(XMLDealWith_T),shootItm);
                    break;
            }
        }

        /// <summary> 创建XML 
        /// </summary>
        private void creatXML(Type type,shootItem details)
        {
            path = Single<ToolHelp>.GetInstance.xmlPath(
                type.GetField("fileName").GetValue(null).ToString());
            secondNodStr = type.GetField("fileName").GetValue(null).ToString().ToLower();
            id = Single<ToolHelp>.GetInstance.dictionaryId(secondNodStr);

            if (secondNodStr == "answer" || secondNodStr == "dealwith_c")
            {
                id += int.Parse(Single<ToolHelp>.GetInstance.SceneNum) * 100000;
            }

            Single<XMLData>.GetInstance.CreatXML(path); //创建一个空的XML，有名字的

            obj = Activator.CreateInstance(type);
            propertyInfos = type.GetProperties();
            paramer[0] = details;

            for (int i = 0; i < propertyInfos.Count(); i++)
            {
                methodReturn = (string)type.InvokeMember(propertyInfos[i].Name + "1",
                    BindingFlags.Default | BindingFlags.InvokeMethod, null, obj, paramer); //调用方法
                Single<XMLData>.GetInstance.addXML(path, secondNodStr, id, propertyInfos[i].Name, methodReturn);//创建XML表
            }

        }

        /// <summary>
        /// 打印
        /// </summary>
        private void printDictionary()
        {
            foreach (string key in Single<ToolHelp>.GetInstance.IdDictionary.Keys)
            {
                Console.WriteLine("key :"+key);
            }
            foreach (int key in Single<ToolHelp>.GetInstance.IdDictionary.Values)
            {
                Console.WriteLine("Values :"+key);
            }
        }
    }
}
