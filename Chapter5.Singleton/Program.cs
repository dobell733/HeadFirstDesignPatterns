using System.Diagnostics;

namespace Chapter5.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Singleton Implementations with Threads and Measuring Time...\n");

            MeasureTime("Basic Singleton (NOT Thread-Safe):", () => TestSingleton(() => BasicSingleton.GetInstance()));
            MeasureTime("Eager Singleton (Thread-Safe):", () => TestSingleton(() => EagerSingleton.GetInstance()));
            MeasureTime("Double-Checked Lock Singleton (Thread-Safe):", () => TestSingleton(() => DoubleCheckedSingleton.GetInstance()));
            MeasureTime("Lazy Singleton (Thread-Safe):", () => TestSingleton(() => LazySingleton.GetInstance));

            Console.WriteLine("\nDemonstration complete.");
        }

        private static void MeasureTime(string label, Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            Console.WriteLine($"{label} Completed in {stopwatch.ElapsedMilliseconds} ms\n");
        }

        private static void TestSingleton(Func<object> getInstance)
        {
            var instances = new object[10];

            Parallel.For(0, 10, i =>
            {
                instances[i] = getInstance();
            });

            // Check if all instances are the same
            bool allEqual = true;
            for (int i = 1; i < instances.Length; i++)
            {
                if (!ReferenceEquals(instances[0], instances[i]))
                {
                    allEqual = false;
                    break;
                }
            }

            Console.WriteLine($"All instances are the same: {allEqual}");
        }

        // Can run into problems with multiple threads
        public class BasicSingleton
        {
            private static BasicSingleton? uniqueInstance;
            private BasicSingleton() { }

            // constructor is private so to be able to call this, it needs to be static
            public static BasicSingleton GetInstance()  
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new BasicSingleton();
                }
                return uniqueInstance;
            }
        }

        // thread safe, always creates an instance even if not needed
        public class EagerSingleton
        {
            // create an instance when the class is loaded, this is thread safe since it's a static initializer
            private static EagerSingleton uniqueInstance = new EagerSingleton();

            private EagerSingleton() { }

            public static EagerSingleton GetInstance()
            {
                return uniqueInstance;
            }
        }

        // thread safe
        public class DoubleCheckedSingleton
        {
            private static DoubleCheckedSingleton instance = null;
            private static readonly object lockObject = new();

            // Private constructor to prevent instantiation
            private DoubleCheckedSingleton() { }

            public static DoubleCheckedSingleton GetInstance()
            {
                // Double-checked locking
                if (instance == null)
                {
                    lock (lockObject) // lock is only used when there's not already an instance
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckedSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        // thread safe
        public class LazySingleton
        {
            private static readonly Lazy<LazySingleton> lazyInstance =
                new Lazy<LazySingleton>(() => new LazySingleton());

            private LazySingleton() { }

            public static LazySingleton GetInstance => lazyInstance.Value;
        }


    }
}
