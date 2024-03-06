namespace Core_DI_8.Repositories
{
    public class CSVFileOperations : IFileOperation
    {
        string IFileOperation.ReadFile(string fileName)
        {
            return $"Read from CSV File Successfull {fileName}";
        }

        string IFileOperation.WriteFile(string fileName, string data)
        {
            return $"{data} is written CSV File Successfull {fileName}";
        }
    }
}
