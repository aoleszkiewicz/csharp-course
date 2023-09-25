namespace HRAdministrationAPI;

public static class FactoryPattern<K, T> where T : class, K, new()
{
    public static K CreateInstance()
    {
        K objK = new T();
        return objK;
    }
}