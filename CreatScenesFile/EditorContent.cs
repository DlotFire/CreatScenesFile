using System;
using System.Data;
using System.IO;
using System.Linq;

namespace CreatScenesFile
{
    class EditorContent
    {
        //private DataTable dateTab;
        //private List<string> taskList;
        //public List<string> TaskList
        //{
        //    set
        //    {
        //        if (taskList == null)
        //        {
        //            taskList = new List<string>();
        //        }
        //        else
        //            taskList = value;
        //    }
        //    get
        //    {
        //        return taskList;
        //    }
        //}

        /// <summary>
        /// 入口
        /// </summary>
        public void editConten()
        {
            //dateTab = LoadExcell.DtExcel;
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < dateTab.Columns.Count; j++)
            //    {
            //if (!ToolHelp.GetInstants.StrDict.ContainsKey(dateTab.Rows[i][j].ToString()))
            //{
            //    ToolHelp.GetInstants.StrDict.Add(dateTab.Rows[i][j].ToString(), j);
            //}
            //    }
            //}

            Content_int();
            Content_Awake();
            Content_Start();
            Content_update();
            Content_task();
        }

        /// <summary>
        /// 添加内容到文本当中
        /// </summary>
        /// <param name="Word"></param>
        private void AddContents(string Word)
        {
            StreamWriter writeStr = File.AppendText(
                Single<ToolHelp>.GetInstance.OutputPath +
                Single<ToolHelp>.GetInstance.SceneClassName + "_" +
                Single<ToolHelp>.GetInstance.SceneNum + "_" +
                Single<ToolHelp>.GetInstance.SceneRang + "_" +
                Single<ToolHelp>.GetInstance.ScenePartName + ".txt"
                );
            writeStr.WriteLine(Word);
            writeStr.Close();
        }

        /// <summary>
        /// 内容中，方法的开头
        /// </summary>
        private void Content_FuncStar(string FuncName)
        {
            AddContents("function " + FuncName + "()");
        }

        /// <summary>
        /// 内容中，在update里的if
        /// </summary>
        /// <param name="shootStr">镜头号</param>
        /// <param name="bol">是否是同一个镜头的第二个方法</param>
        private void Contetn_if(string shootStr, bool bol)
        {
            if (bol)
                AddContents("  if(animatorState:IsName(\"" + shootStr + "\") and (ft == 0) and record ~= ft) then");
            else
                AddContents("  if(animatorState:IsName(\"" + shootStr + "\") and (ft == 0.4) and record ~= ft) then");
        }

        /// <summary>
        /// 内容中，初始化
        /// </summary>
        private void Content_int()
        {
            AddContents(string.Format("local {0} = {1}", "unity", "CS.UnityEngine"));
            AddContents(string.Format("local {0} = {1}", "HotKeys", "CS.HotKeys"));
            AddContents(string.Format("local {0} = {1}", "sepUtils", "CS.sepUtils"));
            AddContents(string.Format("local {0} = {1}", "Audio", "CS.Audio"));
            AddContents(string.Format("local {0} = {1}", "record", "1000"));
            AddContents(string.Format("local {0} = {1}", "animator", "self:GetComponent(\"Animator\")"));
            AddContents("");
            AddContents("");

            //人物
            //for (int i = 0; i < Single<ToolHelp>.GetInstance.ListNPC.Count; i++)
            //{
            //    AddContents("local " + ToolHelp.GetInstants.ListNPC[i] + " = "
            //                + "unity.GameObject.Find(\"" + ToolHelp.GetInstants.ListNPC[i] + "\")");
            //}
            AddContents("");
            AddContents("");

        }

        /// <summary>
        /// 内容中，awake方法
        /// </summary>
        private void Content_Awake()
        {
            AddContents("");
            Content_FuncStar("awake");
            //hotkeys脚本
            //AddContents(string.Format("  local {0} = {1}", "CS.Cursor.visible", "true"));
            AddContents("  HotKeys.ORI(\"Scene/Playtime/Playtime_2\")");
            AddContents("  HotKeys.PlayAnimation(self:GetComponent(\"LuaBehaviour\").Action)");
            AddContents("  HotKeys.currentTask = \"shoot001\"");
            AddContents("");

            //控制器路径
            AddContents("  local Woman = \"??\"");
            AddContents("  local Man = \"??\"");
            AddContents("  local boy = \"??\"");
            AddContents("  local gril = \"??\"");
            AddContents("");
            AddContents("");

            //加载人物
            AddContents("  CS.XMLDataNPC1:dataMapClear()");
            AddContents("  CS.XMLDataNPC1.fileName = \"NPC1\"");
            for (int i = 1; i < 10; i++)
            {
                //AddContents(string.Format("  CS.sepUtils.GetSkin({0},{1},\"??\")",
                //    ToolHelp.GetInstants.ListNPC[i], 300000 + i));
            }
            AddContents("");
            AddContents("");

            AddContents("  CS.XMLDataNPC1:dataMapClear()");
            AddContents("  CS.XMLDataNPC1.fileName = \"NPCAdult\"");
            //for (int i = 9; i < ToolHelp.GetInstants.ListNPC.Count; i++)
            //{
            //    AddContents(string.Format("  CS.sepUtils.GetSkin({0},{1},\"??\")",
            //        ToolHelp.GetInstants.ListNPC[i], 900000 + i - 8));
            //}
            AddContents("");
            AddContents("");

            //加载配制表
            AddContents(string.Format("  --local {0} = {1}", "sceID", "CS.Globe.SceneId"));
            AddContents(string.Format("  local {0} = {1}", "sceID", "88888"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataDialog", "DialogPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataQuestion", "QuestionPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataAnswer", "AnswerPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataSelection", "SelectionPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataWiseMan", "WiseAskPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataKepu", "KepuPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataGuoChang", "GuochangPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataWenDa", "WenDaPath"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataDealWith_T", "DealWith_T"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataDealWith_C", "DealWith_C"));
            AddContents(string.Format("  CS.{0}.fileName = CS.XMLDataMap.dataMap[sceID].{1}",
                "XMLDataRecordPoint", "RecordPointXMLPath"));
            AddContents("  CS.XMLDataEffMusic.fileName = CS.XMLDataMap.dataMap[sceID].effMusicPath");


            AddContents("");
            AddContents("end");
        }

        /// <summary>
        /// 内容中，start方法
        /// </summary>
        private void Content_Start()
        {
            AddContents("");
            Content_FuncStar("start");

            AddContents("  --this is start function!!");
            AddContents("");

            AddContents("end");
            AddContents("");
        }

        /// <summary>
        /// 内容中，update方法 
        /// </summary>
        private void Content_update()
        {
            AddContents("");
            Content_FuncStar("update");

            AddContents(string.Format("  local {0} = {1}",
                "animatorState", "animator:GetCurrentAnimatorStateInfo(0)"));
            AddContents("if animatorState.normalizedTime ~= 0 and string.len(animatorState.normalizedTime) > 3 then");
            AddContents(string.Format("  local {0} = {1}",
                "ft", "tonumber(string.format(\"% 0.1f\", animatorState.normalizedTime))"));
            AddContents("  self:GetComponent(\"LuaBehaviour\").ft = ft");
            AddContents("  self:GetComponent(\"LuaBehaviour\").record = record");
            AddContents("");
            AddContents("");

            string strShoot;
            for (int i = 1; i < 120; i++)
            {
                strShoot = string.Format("shoot{0:d3}", i);
                //if (Single<LoadExcell>.GetInstance.InfoDict.ContainsKey(istr))
                if (Single<LoadExcell>.GetInstance.InfoDict.ContainsKey(strShoot))
                {

                    //注释
                    AddContents("  -- " + Single<LoadExcell>.GetInstance.InfoDict[strShoot].word);
                    //dateTab.Rows[i][ToolHelp.GetInstants.StrDict["对白"]].ToString() ??
                    //dateTab.Rows[i][ToolHelp.GetInstants.StrDict["备注"]].ToString());

                    //if....
                    Contetn_if(Single<LoadExcell>.GetInstance.InfoDict[strShoot].shootid, true);

                    //内容
                    AddContents("    record = ft");
                    switch (Single<LoadExcell>.GetInstance.InfoDict[strShoot].type)
                    {
                        case "log": //对白
                            {

                                AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                                AddContents(
                                    "    CS.DialogUIController.GetInstance():SwitchTechDialogUI():updataDailogUI5(" +
                                   Single<ToolHelp>.GetInstance.GetDict("对白题_ID号") + ")");
                                Single<ToolHelp>.GetInstance.IdDictionary["对白题_ID号"] =
                                 Single<ToolHelp>.GetInstance.GetDict("对白题_ID号") + 1;
                                //ID号增加
                                //AddContents("  end");
                                //AddContents("");

                                //Contetn_if("  " + dateTab.Rows[i][ToolHelp.GetInstants.StrDict["镜头号"]].ToString(),false);
                                //AddContents("    record = ft");
                                //AddContents("    HotKeys.PlayAnimation("+ dateTab.Rows[i][ToolHelp.GetInstants.StrDict["镜头号"]+1].ToString() + ")");//切镜
                                //

                            }
                            break;

                        case "pd": //判断
                            {

                                AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                                AddContents("    CS.DialogUIController.GetInstance():SwitchTechDialogUI():updataDailogUI2(" +
                                            Single<ToolHelp>.GetInstance.GetDict("判断题_ID号") + ")");
                                Single<ToolHelp>.GetInstance.IdDictionary["判断题_ID号"] = Single<ToolHelp>.GetInstance.GetDict("判断题_ID号") + 1; //ID号增加
                            }
                            break;

                        case "xz": //选择
                            {

                                AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                                AddContents("    CS.DialogUIController.GetInstance():SwitchTechDialogUI():updataDailogUI6(" +
                                            Single<ToolHelp>.GetInstance.GetDict("选择题_ID号") + ")");
                                Single<ToolHelp>.GetInstance.IdDictionary["选择题_ID号"] = Single<ToolHelp>.GetInstance.GetDict("选择题_ID号") + 1; //ID号增加
                            }
                            break;

                        case "wd": //问答
                            {

                                AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                                AddContents("    CS.DialogUIController.GetInstance():SwitchTechDialogUI():updataDailogUI7(" +
                                            Single<ToolHelp>.GetInstance.GetDict("问答题_ID号") + ")");
                                Single<ToolHelp>.GetInstance.IdDictionary["问答题_ID号"] = Single<ToolHelp>.GetInstance.GetDict("问答题_ID号") + 1; //ID号增加
                            }
                            break;

                        case "tw": //智者提问
                            {

                                AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                                AddContents("    CS.WisemanMgr.GetInstans():WisemansGo(" +
                                            Single<ToolHelp>.GetInstance.GetDict("智者提问题_ID号") + ")");
                                Single<ToolHelp>.GetInstance.IdDictionary["智者提问题_ID号"] = Single<ToolHelp>.GetInstance.GetDict("智者提问题_ID号") + 1;
                                //ID号增加
                                AddContents("  end");
                                AddContents("");


                                AddContents("  -- 切镜");
                                Contetn_if(Single<LoadExcell>.GetInstance.InfoDict[strShoot].shootid, false);
                                AddContents("    record = ft");

                                AddContents("    HotKeys.PlayAnimation(\"" +
                                            Single<ToolHelp>.GetInstance.GetCameraNumber(strShoot, true) + "\")"); //切镜
                            }
                            break;

                        case "gc": //智者过场动画
                            {

                                AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                                AddContents("    CS.WisemanMgr.GetInstans():WisemanFly(" +
                                            Single<ToolHelp>.GetInstance.GetDict("智者过场动画题_ID号") + ")");
                                Single<ToolHelp>.GetInstance.IdDictionary["智者过场动画题_ID号"] = Single<ToolHelp>.GetInstance.GetDict("智者过场动画题_ID号") + 1;
                                //ID号增加
                                AddContents("  end");
                                AddContents("");


                                AddContents("  -- 切镜");
                                Contetn_if(Single<LoadExcell>.GetInstance.InfoDict[strShoot].shootid, false);
                                AddContents("    record = ft");

                                AddContents("    HotKeys.PlayAnimation(\"" +
                                            Single<ToolHelp>.GetInstance.GetCameraNumber(strShoot, true) + "\")"); //切镜
                            }
                            break;

                        case "kp": //科普
                            {

                                AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                                AddContents("    CS.WisemanMgr.GetInstans():WisemanKepu(" +
                                            Single<ToolHelp>.GetInstance.GetDict("智者科普题_ID号") + ")");
                                Single<ToolHelp>.GetInstance.IdDictionary["智者科普题_ID号"] = Single<ToolHelp>.GetInstance.GetDict("智者科普题_ID号") + 1;
                                //ID号增加
                                AddContents("  end");
                                AddContents("");


                                AddContents("  -- 切镜");
                                Contetn_if(Single<LoadExcell>.GetInstance.InfoDict[strShoot].shootid, false);
                                AddContents("    record = ft");

                                AddContents("    HotKeys.PlayAnimation(\"" +
                                            Single<ToolHelp>.GetInstance.GetCameraNumber(strShoot, true) + "\")"); //切镜
                            }
                            break;
                        case "wx": //应对界面

                            AddContents("    HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                            AddContents("    CS.DealWithControlle.GetInstance():SwitchDealWithUI():UpdataDealWithUI(" +
                                        Single<ToolHelp>.GetInstance.GetDict("应对界面题_ID号") + ")");
                            Single<ToolHelp>.GetInstance.IdDictionary["应对界面题_ID号"] = Single<ToolHelp>.GetInstance.GetDict("应对界面题_ID号") + 1;
                            //ID号增加
                            break;
                    }

                    //"end",if方法结束
                    AddContents("  end");
                    AddContents("  ");

                }
                else
                {
                    AddContents("  --切镜");
                    //if
                    Contetn_if(string.Format("shoot{0:d3}", i), false);
                    //内容
                    AddContents("  record = ft");
                    AddContents("  HotKeys.currentTask =\"" + string.Format("shoot{0:d3}", i + 1) + "\"");
                    AddContents("  HotKeys.PlayAnimation(\"" + string.Format("shoot{0:d3}", i + 1) + "\")");//切镜

                    //"end",if方法结束
                    AddContents("end");
                    AddContents("");
                }

            }

            AddContents("  if (record ~= ft) then");
            AddContents("    record = 1000");
            AddContents("  end");

            //动画判断的结束
            AddContents("");
            AddContents("end");

            //updata方法结束
            AddContents("");
            AddContents("end");
        }

        /// <summary>
        /// 内容中，task方法
        /// </summary>
        private void Content_task()
        {
            AddContents("");
            Content_FuncStar("task");

            AddContents("  --this is task function!!");
            AddContents("");

            AddContents("");
            AddContents("end");
        }
    }
}
