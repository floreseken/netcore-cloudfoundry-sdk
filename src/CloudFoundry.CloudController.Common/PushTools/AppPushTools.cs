namespace CloudFoundry.CloudController.Common.PushTools
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO.Compression;
    using System;
    using System.Linq;

    /// <summary>
    /// Helper tools for application push
    /// </summary>
    public class AppPushTools : IAppPushTools
    {
        private readonly string appPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPushTools"/> class.
        /// </summary>
        /// <param name="appPath">The application path.</param>
        public AppPushTools(string appPath)
        {
            this.appPath = appPath.TrimEnd('/').TrimEnd('\\');
        }

        /// <summary>
        /// Gets the file fingerprints from the application folder
        /// As the sha1 is calculated based on the content of the file, 
        /// there is a possibility that one key can have multiple fingerprints (duplicate files)
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Return a dictionary of file fingerprints, with sha1 as key and a list of file fingerprints as value.</returns>
        public Task<Dictionary<string, List<FileFingerprint>>> GetFileFingerprints(CancellationToken cancellationToken)
        {
            //throw new System.NotImplementedException();
            return null;
        }

        /// <summary>
        /// Creates a zip archive containing specific files from the application folder
        /// </summary>
        /// <param name="files">The files that will be added to the archive.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An open stream of the zip file</returns>
        public Task<Stream> GetZippedPayload(IEnumerable<string> files, CancellationToken cancellationToken)
        {
            var memoryStream = new MemoryStream();

            var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true);

            memoryStream.Seek(0, SeekOrigin.Begin);

            return Task.FromResult((Stream)memoryStream);
        }

        /// <summary>
        /// Creates a zip archive containing the all files from the application folder <see cref="AppPushTools"/>
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An open stream of the zip file</returns>
        public Stream GetZippedPayload(CancellationToken cancellationToken)
        {

            var memoryStream = new MemoryStream();

            using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
            {
                archive.CreateEntryFromDirectory(this.appPath);
            }

            // memoryStream.Seek(0, SeekOrigin.Begin);
            // return (Stream)memoryStream;


            using (var fileStream = new FileStream(@"C:\test\test.zip", FileMode.Create))
            {
                memoryStream.Seek(0, SeekOrigin.Begin);
                memoryStream.CopyTo(fileStream);
            }


            memoryStream.Seek(0, SeekOrigin.Begin);
            return ((Stream)memoryStream);

        }
    }


    // using (var memoryStream = new MemoryStream()) {
    //     using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true)) {
    //         archive.CreateEntryFromAny(sourcePath);
    //     }
    // }
    public static class ZipArchiveExtension
    {

        private static void createEntryFromAny(this ZipArchive archive, string sourceName, string entryName = "")
        {
            var fileName = Path.GetFileName(sourceName);
            if (File.GetAttributes(sourceName).HasFlag(FileAttributes.Directory))
            {
                archive.CreateEntryFromDirectory(sourceName, Path.Combine(entryName, fileName));
            }
            else
            {
                archive.CreateEntryFromFile(sourceName, Path.Combine(entryName, fileName));
            }
        }

        public static void CreateEntryFromDirectory(this ZipArchive archive, string sourceDirName, string entryName = "")
        {
            string[] files = Directory.GetFiles(sourceDirName).Concat(Directory.GetDirectories(sourceDirName)).ToArray();

            foreach (var file in files)
            {
                archive.createEntryFromAny(file, entryName);
            }
        }
    }
}
