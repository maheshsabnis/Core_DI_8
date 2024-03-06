namespace Core_DI_8.Repositories
{
    public interface IFileOperation
    {
        string WriteFile(string fileName, string data);
        string ReadFile(string fileName);
    }
}
