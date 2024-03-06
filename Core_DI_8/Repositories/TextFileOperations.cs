namespace Core_DI_8.Repositories
{
    public class TextFileOperations : IFileOperation
    {
        string IFileOperation.ReadFile(string fileName)
        {
            return $"Read from Text File Successfull {fileName}";
        }

        string IFileOperation.WriteFile(string fileName, string data)
        {
            return $"{data} is written Text File Successfull {fileName}";
        }
    }
}
