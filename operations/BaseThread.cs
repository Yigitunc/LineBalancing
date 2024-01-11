using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HatDengelemeProject.operations
{
    abstract class BaseThread
    {

       
        private static readonly object lockObject = new object();

        public static List<BaseThread> threadObjects = new List<BaseThread>();

        private Thread _thread;

        public String ThreadName;

        protected BaseThread()
        {
            lock (lockObject)
            {
                    _thread = new Thread(new ThreadStart(this.RunThread));
                    threadObjects.Add(this);
            }
        }

        // Thread methods / properties
        public void Start() => _thread.Start();
        public void Join() => _thread.Join();
        public bool IsAlive => _thread.IsAlive;

        // Override in base class
        public abstract void RunThread();

        // Static method to get all created objects
        public static List<BaseThread> GetAllThreadObjects()
        {
            return threadObjects;
        }
    }
}
