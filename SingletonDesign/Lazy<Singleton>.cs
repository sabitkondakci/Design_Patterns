 //sealed , to prevent a nested class inheriting this class
    sealed class SingletonDesign
    {
        private static readonly Lazy<SingletonDesign> _singleton = new Lazy<SingletonDesign>(()=>new SingletonDesign());

        //private constructor to prevent other classes creating an instance from this class
        private SingletonDesign() { }

        public static SingletonDesign GetInstance => _singleton.Value;

        public int TestCount { get; set; } = 0;
    }
