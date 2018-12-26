namespace CreatScenesFile
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_tip1 = new System.Windows.Forms.Label();
            this.textBox_inputPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ExcelOpenFileSelec = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_OutputPath = new System.Windows.Forms.Button();
            this.textBox_outputPath = new System.Windows.Forms.TextBox();
            this.label_outPutPath = new System.Windows.Forms.Label();
            this.btn_buildXML = new System.Windows.Forms.Button();
            this.btn_buildmusic = new System.Windows.Forms.Button();
            this.btn_buildScript = new System.Windows.Forms.Button();
            this.btn_allBuild = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ScenesPartName = new System.Windows.Forms.TextBox();
            this.textBox_SceneClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ComBoxRang = new System.Windows.Forms.ComboBox();
            this.ComBoxNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_tip1
            // 
            this.label_tip1.AutoSize = true;
            this.label_tip1.Location = new System.Drawing.Point(6, 7);
            this.label_tip1.Name = "label_tip1";
            this.label_tip1.Size = new System.Drawing.Size(83, 12);
            this.label_tip1.TabIndex = 0;
            this.label_tip1.Text = "excel表位置：";
            // 
            // textBox_inputPath
            // 
            this.textBox_inputPath.Location = new System.Drawing.Point(9, 29);
            this.textBox_inputPath.Name = "textBox_inputPath";
            this.textBox_inputPath.Size = new System.Drawing.Size(193, 21);
            this.textBox_inputPath.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ExcelOpenFileSelec);
            this.panel1.Controls.Add(this.textBox_inputPath);
            this.panel1.Controls.Add(this.label_tip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 65);
            this.panel1.TabIndex = 2;
            // 
            // btn_ExcelOpenFileSelec
            // 
            this.btn_ExcelOpenFileSelec.Location = new System.Drawing.Point(208, 28);
            this.btn_ExcelOpenFileSelec.Name = "btn_ExcelOpenFileSelec";
            this.btn_ExcelOpenFileSelec.Size = new System.Drawing.Size(37, 21);
            this.btn_ExcelOpenFileSelec.TabIndex = 5;
            this.btn_ExcelOpenFileSelec.Text = "...";
            this.btn_ExcelOpenFileSelec.UseVisualStyleBackColor = true;
            this.btn_ExcelOpenFileSelec.Click += new System.EventHandler(this.button_ExcelOpenFileSelec_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_OutputPath);
            this.panel2.Controls.Add(this.textBox_outputPath);
            this.panel2.Controls.Add(this.label_outPutPath);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 56);
            this.panel2.TabIndex = 3;
            // 
            // btn_OutputPath
            // 
            this.btn_OutputPath.Location = new System.Drawing.Point(208, 28);
            this.btn_OutputPath.Name = "btn_OutputPath";
            this.btn_OutputPath.Size = new System.Drawing.Size(37, 21);
            this.btn_OutputPath.TabIndex = 6;
            this.btn_OutputPath.Text = "...";
            this.btn_OutputPath.UseVisualStyleBackColor = true;
            this.btn_OutputPath.Click += new System.EventHandler(this.btn_OutputPath_Click);
            // 
            // textBox_outputPath
            // 
            this.textBox_outputPath.Location = new System.Drawing.Point(9, 29);
            this.textBox_outputPath.Name = "textBox_outputPath";
            this.textBox_outputPath.Size = new System.Drawing.Size(193, 21);
            this.textBox_outputPath.TabIndex = 1;
            // 
            // label_outPutPath
            // 
            this.label_outPutPath.AutoSize = true;
            this.label_outPutPath.Location = new System.Drawing.Point(6, 7);
            this.label_outPutPath.Name = "label_outPutPath";
            this.label_outPutPath.Size = new System.Drawing.Size(65, 12);
            this.label_outPutPath.TabIndex = 0;
            this.label_outPutPath.Text = "输出路径：";
            // 
            // btn_buildXML
            // 
            this.btn_buildXML.Location = new System.Drawing.Point(1, 9);
            this.btn_buildXML.Name = "btn_buildXML";
            this.btn_buildXML.Size = new System.Drawing.Size(123, 28);
            this.btn_buildXML.TabIndex = 4;
            this.btn_buildXML.Text = "生成XML";
            this.btn_buildXML.UseVisualStyleBackColor = true;
            this.btn_buildXML.Click += new System.EventHandler(this.btn_buildXML_Click);
            // 
            // btn_buildmusic
            // 
            this.btn_buildmusic.Location = new System.Drawing.Point(1, 43);
            this.btn_buildmusic.Name = "btn_buildmusic";
            this.btn_buildmusic.Size = new System.Drawing.Size(123, 28);
            this.btn_buildmusic.TabIndex = 5;
            this.btn_buildmusic.Text = "生成音频";
            this.btn_buildmusic.UseVisualStyleBackColor = true;
            this.btn_buildmusic.Click += new System.EventHandler(this.btn_buildmusic_Click);
            // 
            // btn_buildScript
            // 
            this.btn_buildScript.Location = new System.Drawing.Point(130, 9);
            this.btn_buildScript.Name = "btn_buildScript";
            this.btn_buildScript.Size = new System.Drawing.Size(123, 28);
            this.btn_buildScript.TabIndex = 6;
            this.btn_buildScript.Text = "生成脚本";
            this.btn_buildScript.UseVisualStyleBackColor = true;
            this.btn_buildScript.Click += new System.EventHandler(this.btn_buildScript_Click);
            // 
            // btn_allBuild
            // 
            this.btn_allBuild.Location = new System.Drawing.Point(130, 43);
            this.btn_allBuild.Name = "btn_allBuild";
            this.btn_allBuild.Size = new System.Drawing.Size(123, 28);
            this.btn_allBuild.TabIndex = 7;
            this.btn_allBuild.Text = "一键生成";
            this.btn_allBuild.UseVisualStyleBackColor = true;
            this.btn_allBuild.Click += new System.EventHandler(this.btn_allBuild_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "提示：",
            "1.answer配制表，因为不好确定长度，所以没有",
            "加 S\\\\n,可能要手动加一下;",
            "2.Question配制表中，如果出现\"moshengnanzi\"",
            "的人物名，则表示加载时人物名出错（新增人物，",
            "或者不是常用人物）;",
            "3.分镜表的“配置表”须更改成A列开始，原表是",
            "从I列开始，懒得添加数据匹配项，生成前删下",
            "Excell表列数就好；",
            "4.生成音频前，输出路径需要有配制表文件",
            "5.如有发现未解决问题，请联系XXX！!"});
            this.listBox1.Location = new System.Drawing.Point(1, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 220);
            this.listBox1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.btn_allBuild);
            this.panel3.Controls.Add(this.btn_buildScript);
            this.panel3.Controls.Add(this.btn_buildmusic);
            this.panel3.Controls.Add(this.btn_buildXML);
            this.panel3.Location = new System.Drawing.Point(12, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 303);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBox_ScenesPartName);
            this.panel4.Controls.Add(this.textBox_SceneClassName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 120);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "专题名字：";
            // 
            // textBox_ScenesPartName
            // 
            this.textBox_ScenesPartName.Location = new System.Drawing.Point(8, 83);
            this.textBox_ScenesPartName.Name = "textBox_ScenesPartName";
            this.textBox_ScenesPartName.Size = new System.Drawing.Size(193, 21);
            this.textBox_ScenesPartName.TabIndex = 7;
            this.textBox_ScenesPartName.Text = "QingMing";
            // 
            // textBox_SceneClassName
            // 
            this.textBox_SceneClassName.Location = new System.Drawing.Point(9, 29);
            this.textBox_SceneClassName.Name = "textBox_SceneClassName";
            this.textBox_SceneClassName.Size = new System.Drawing.Size(193, 21);
            this.textBox_SceneClassName.TabIndex = 1;
            this.textBox_SceneClassName.Text = "Frist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "专题分类：";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ComBoxRang);
            this.panel5.Controls.Add(this.ComBoxNum);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(12, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 34);
            this.panel5.TabIndex = 10;
            // 
            // ComBoxRang
            // 
            this.ComBoxRang.FormattingEnabled = true;
            this.ComBoxRang.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ComBoxRang.Location = new System.Drawing.Point(169, 8);
            this.ComBoxRang.Name = "ComBoxRang";
            this.ComBoxRang.Size = new System.Drawing.Size(83, 20);
            this.ComBoxRang.TabIndex = 14;
            // 
            // ComBoxNum
            // 
            this.ComBoxNum.FormattingEnabled = true;
            this.ComBoxNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.ComBoxNum.Location = new System.Drawing.Point(39, 8);
            this.ComBoxNum.Name = "ComBoxNum";
            this.ComBoxNum.Size = new System.Drawing.Size(83, 20);
            this.ComBoxNum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(128, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "年级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "期数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 667);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "专题生成工具";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_tip1;
        private System.Windows.Forms.TextBox textBox_inputPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_outputPath;
        private System.Windows.Forms.Label label_outPutPath;
        private System.Windows.Forms.Button btn_buildXML;
        private System.Windows.Forms.Button btn_ExcelOpenFileSelec;
        private System.Windows.Forms.Button btn_OutputPath;
        private System.Windows.Forms.Button btn_buildmusic;
        private System.Windows.Forms.Button btn_buildScript;
        private System.Windows.Forms.Button btn_allBuild;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_SceneClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ScenesPartName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComBoxNum;
        private System.Windows.Forms.ComboBox ComBoxRang;
    }
}

