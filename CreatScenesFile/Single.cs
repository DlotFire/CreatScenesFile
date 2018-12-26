using System;

namespace CreatScenesFile
{
    class Single<T> where T : new()
    {
        private static T single;

        public static T GetInstance
        {
            get
            {
                if (single == null)
                {
                    single = new T();
                    //Console.WriteLine("创建{0}成功!!", typeof(T).Name);
                    TipShow.Tip.TipShowWord(string.Format("============ 创建{0}成功!! ============", typeof(T).Name));
                }
                return single;
            }
        }
    }
}
