using System;
using System.Collections.Generic;
using System.Threading;

namespace CBT.Domain.Extensions
{
    static class EntityExtension
    {
        /// <summary>
        /// This Code is from http://stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp StackOverFlow
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}

public static class ThreadSafeRandom
{
    [ThreadStatic]
    private static Random Local;

    public static Random ThisThreadsRandom
    {
        get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
    }
}