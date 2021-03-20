 //sealed , to prevent a nested class inheriting this class
    sealed class SingletonDesign
    {
        private static SingletonDesign _singleton = null;
        
        // volatile keyword guarantees that your temp reference will be stored on main memory but cache on CPU;
        private static volatile object ThreadSafe = new object();
        //private constructor to prevent other classes creating an instance from this class
        private SingletonDesign() { }

        public static SingletonDesign GetInstance
        {
            get
            {
             // this part ensures thread safety , only works if _singleton == null at first try
                if (_singleton == null)
                {
                    lock (ThreadSafe)
                    {
                        //if(_singleton == null){ _singleton = new SingletonDesign();}
                        _singleton ??= new SingletonDesign();
                      
                    }
                }

                return _singleton;

            }

        }

        public int TestCount { get; set; } = 0;
    }
