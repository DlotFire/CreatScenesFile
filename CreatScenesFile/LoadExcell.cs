using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CreatScenesFile
{
    class LoadExcell : Single<LoadExcell>
    {

        private Dictionary<string, shootItem> infoDict;        
        /// <summary>
        /// 要生成的全部内容，string 是镜头号，shootItem是分镜内容
        /// </summary>
        public Dictionary<string, shootItem> InfoDict
        {
            get
            {
                if (infoDict == null)
                {
                    infoDict = new Dictionary<string, shootItem>();
                    GetExcelTableByOleDB(Single<ToolHelp>.GetInstance.InputPath);
                }
                return infoDict;
            }
        }
        

        /// <summary> 根据路径加载excell表到DataTable 
        /// </summary>
        /// <param name="strExcelPath"></param>
        /// <returns></returns>
        private void GetExcelTableByOleDB(string strExcelPath)
        {
            //获取文件扩展名
            string strExtension = System.IO.Path.GetExtension(strExcelPath);
            //string strFileName = System.IO.Path.GetFileName(strExcelPath);
            //Excel的连接
            OleDbConnection objConn = null;
            switch (strExtension)
            {
                case ".xls":
                    objConn =
                        new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strExcelPath + ";" +
                                            "Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                    break;
                case ".xlsx":
                    objConn =
                        new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strExcelPath + ";" +
                                            "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                    break;
                default:
                    objConn = null;
                    break;
            }
            if (objConn == null)
            {
                return;
            }
            objConn.Open();
            //获取Excel中所有Sheet表的信息
            System.Data.DataTable schemaTable = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            //获取Excel指定Sheet表中的信息
            //OleDbCommand objCmd = new OleDbCommand(strSql, objConn);

            TipShow.Tip.TipShowWord("Eexcell sheet 表名：" + schemaTable.Rows[0][2].ToString().Trim());
            //获取Excel的第一个Sheet表名
            DataTable datTabl = new DataTable();
            OleDbDataAdapter myData = new OleDbDataAdapter("select * from [" + schemaTable.Rows[0][2].ToString().Trim() + "]", objConn);
            myData.Fill(datTabl); //填充数据
            

            for (int i = 0; i < datTabl.Rows.Count; i++)
            {                
                if (datTabl.Rows[i][1].ToString().Contains("shoot") 
                    && (datTabl.Rows[i][4] as string) != null
                    && !InfoDict.ContainsKey(datTabl.Rows[i][1].ToString()))
                {
                    shootItem shootIt = new shootItem();
                    shootIt.shootid = datTabl.Rows[i][1].ToString();
                    shootIt.scenesId = datTabl.Rows[i][0].ToString();
                    shootIt.word = datTabl.Rows[i][4].ToString();
                    shootIt.type = "log";
                    InfoDict.Add(shootIt.shootid, shootIt);                    
                }
            }

            datTabl.Dispose();

            TipShow.Tip.TipShowWord("Eexcell sheet 表名：" + schemaTable.Rows[2][2].ToString().Trim());
            //获取Excel的第二个Sheet表名
            datTabl = new DataTable();
            myData = new OleDbDataAdapter("select * from [" + schemaTable.Rows[2][2].ToString().Trim() + "]", objConn);
            myData.Fill(datTabl); //填充数据

            for (int i = 0; i < datTabl.Rows.Count; i++)
            {
                if (datTabl.Rows[i][1].ToString().Contains("shoot") && InfoDict.ContainsKey(datTabl.Rows[i][1].ToString()))
                {
                    InfoDict[datTabl.Rows[i][1].ToString()].type = datTabl.Rows[i][2].ToString();
                    InfoDict[datTabl.Rows[i][1].ToString()].TeachWord = datTabl.Rows[i][5].ToString();
                    
                    switch (InfoDict[datTabl.Rows[i][1].ToString()].type)
                    {
                        //case null: //对白
                        //    {
                        //    }
                        //    break;

                        case "pd": //判断
                            {
                                InfoDict[datTabl.Rows[i][1].ToString()].Result = datTabl.Rows[i][4].ToString();
                            }
                            break;

                        case "xz": //选择
                            {
                                InfoDict[datTabl.Rows[i][1].ToString()].Result = datTabl.Rows[i][4].ToString();
                                InfoDict[datTabl.Rows[i][1].ToString()].selectItem = datTabl.Rows[i][3].ToString();
                            }
                            break;

                        //case "wd": //问答
                        //    {
                        //    }
                        //    break;

                        //case "tw": //智者提问
                        //    {

                        //    }
                        //    break;

                        //case "gc": //智者过场动画
                        //    {

                        //    }
                        //    break;

                        //case "kp": //科普
                        //    {

                        //    }
                        //    break;
                        //case "yd": //应对界面
                        //    break;
                    }
                }
            }

            objConn.Close();
        }
    }
}
