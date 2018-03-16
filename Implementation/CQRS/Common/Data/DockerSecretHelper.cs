using System.IO;

namespace FP.Spartakiade2018.CQRS.Data
{
    public static class DockerSecretHelper
    {
        private const string defaultPath = "/run/secrets/";

        public static string GetSecretValue(string name)
        {
            var filePath = Path.Combine(defaultPath, name);
#if DEBUG
            filePath = Path.Combine(Directory.GetCurrentDirectory(), name);
#endif

            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            return string.Empty;
        }
    }
}
