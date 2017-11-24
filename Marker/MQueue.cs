using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marker
{
    /// <summary>
    /// 自定义队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MQueue<T> where T:class
    {
        private HashSet<T> hs = new HashSet<T>();
        /// <summary>
        /// 执行事件
        /// </summary>
        public event Action<T> DoMain;
        /// <summary>
        /// 构造函数，用于任务列表
        /// </summary>
        public MQueue() { }

        /// <summary>
        /// 将元素放入队列
        /// </summary>
        /// <param name="ms"></param>
        public void Add(T ms)
        {
            if (!hs.Contains(ms))
            {
                hs.Add(ms);
                //生成新任务放入到线程池
                DoMain(ms);
            }
        }

        /// <summary>
        /// 删除队首元素
        /// </summary>
        public void Delete(T ms)
        {
            if (hs.Count > 0)
            {
                hs.Remove(ms);
            }
        }

        /// <summary>
        /// 获取队首元素
        /// </summary>
        /// <returns></returns>
        public T First()
        {
            if (hs.Count > 0)
            {
                return hs.First<T>();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取队尾元素
        /// </summary>
        /// <returns></returns>
        public T Last()
        {
            if (hs.Count > 0)
            {
                return hs.Last<T>();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 返回队列中的元素个数
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return hs.Count;
        }


    }
}
