 //sealed , to prevent a nested class inheriting this class
    sealed class SingletonDesign
    {
        private static SingletonDesign _singleton;

        //private constructor to prevent other classes creating an instance from this class
        private SingletonDesign() { }

        public static SingletonDesign GetInstance
        {
            get
            {
                //if(_singleton == null){ _singleton = new SingletonDesign();}
                _singleton ??= new SingletonDesign(); 
                return _singleton;
            }

        }

        public int TestCount { get; set; } = 0;
    }
