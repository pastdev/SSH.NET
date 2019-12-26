﻿using System;
using System.Threading.Tasks;

namespace Renci.SshNet.Abstractions
{
    internal static class ThreadAbstraction
    {
        /// <summary>
        /// Suspends the current thread for the specified number of milliseconds.
        /// </summary>
        /// <param name="millisecondsTimeout">The number of milliseconds for which the thread is suspended.</param>
        public static void Sleep(int millisecondsTimeout)
        {
            System.Threading.Thread.Sleep(millisecondsTimeout);
        }

        public static void ExecuteThreadLongRunning(Action action)
        {
            var taskCreationOptions = TaskCreationOptions.LongRunning;
            Task.Factory.StartNew(action, taskCreationOptions);
        }

        /// <summary>
        /// Executes the specified action in a separate thread.
        /// </summary>
        /// <param name="action">The action to execute.</param>
        public static void ExecuteThread(Action action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            System.Threading.ThreadPool.QueueUserWorkItem(o => action());
        }
    }
}
