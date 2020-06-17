using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearFacts
{
    public sealed class RemoveMessage
    {
        private static RemoveMessage instance;

        private static object lockObject = new Object();

        private string message;

        public RemoveMessage()
        {
            this.message = "Не можеш да изтриеш факт, който се е случил вече.";
        }

        public static RemoveMessage Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new RemoveMessage();
                    }
                }

                return instance;
            }
        }

        public string DisplayInstance()
        {
            return string.Format("{0}: {1}\n", Instance, this.message);
        }
    }
}
