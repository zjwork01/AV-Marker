using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marker
{
    public class MQueue<T> where T:class
    {
        private static MQueue<T> mqueue = null;
        private static HashSet<T> hs = new HashSet<T>();
        private MQueue() { }

        public static MQueue<T> GetInstance()
        {
            if (mqueue == null)
            {
                mqueue = new MQueue<T>();
            }
            return mqueue;
        }
        /// <summary>
        /// 将元素放入队尾
        /// </summary>
        /// <param name="ms"></param>
        public void Push(T ms)
        {
            if (!hs.Contains(ms))
            {
                hs.Add(ms);
            }
        }

        /// <summary>
        /// 删除队首元素
        /// </summary>
        public void Pop()
        {
            if (hs.Count > 0)
            {
                hs.Remove(hs.First());
            }
        }

        /// <summary>
        /// 获取队首元素
        /// </summary>
        /// <returns></returns>
        public T Front()
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
        public T Back()
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
