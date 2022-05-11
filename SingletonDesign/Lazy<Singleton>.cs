 //sealed , to prevent a nested class from inheriting this class
    sealed class SingletonDesign
    {
        // Lazy<> class ensures thread safety , .Net 4.0+
        private static readonly Lazy<SingletonDesign> _singleton = new Lazy<SingletonDesign>(()=>new SingletonDesign(), LazyThreadSafetyMode.ExecutionAndPublication);

        //private constructor to prevent other classes from creating an instance of this class
        private SingletonDesign() { }

        public static SingletonDesign GetInstance => _singleton.Value;

        public int TestCount { get; set; } = 0;
    }
