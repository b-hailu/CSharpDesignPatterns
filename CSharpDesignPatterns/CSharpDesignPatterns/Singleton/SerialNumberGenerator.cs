using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        //private - Access modifier that restirect access to the class only.
        //static - no instance of this variable are created . it is only 1.
        //volatile - may be modified by multiple thread that are executting at the same time. 
        private static volatile SerialNumberGenerator instance; //volatile means the way the variable is treated. 

        //object - root all objects in .Net
        private static object synchronizlationRoot = new object();

        private int _count = 12345;

        // property of the class SerialNumberGeneratorthat is read- only, it does not have set only get
        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)//if this is instance is not null it will just return
                {
                    lock (synchronizlationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();// if the first try has nothing it will creat object instance, value
                        }
                    }
                }
                return instance;
            }

        }
        private SerialNumberGenerator() { }// by making this private we are makeing anyone not to creat any object

        public int NextSerial
        {
            get { return ++_count; }
        }

    }
}
