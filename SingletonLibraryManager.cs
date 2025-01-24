
public sealed class SingletonLibraryManager
{
    private static SingletonLibraryManager? _instance = null;
    private static readonly object lockObject = new object();
    private Library library = new Library();

    private SingletonLibraryManager() { }

    public static SingletonLibraryManager Instance
    {
        get
        {
            lock (lockObject)
            {
                if (_instance == null)
                {
                    _instance = new SingletonLibraryManager();
                }
                return _instance;
            }
        }
    }

    public Library GetLibrary()
    {
        return library;
    }
}
