using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Web;

namespace S3.WebUI.cBlazor.Utility
{
    public class InMemoryFileProvider : IFileProvider
    {
        private class InMemoryFile : IFileInfo
        {
            private readonly byte[] _data;
            //public InMemoryFile(string json) => _data = Encoding.UTF8.GetBytes(json);
            public InMemoryFile(Stream stream)
            {
                using var ms = new MemoryStream();
                stream.CopyTo(ms);
                _data = ms.ToArray();
            }

            public Stream CreateReadStream() => new MemoryStream(_data);
            public bool Exists { get; } = true;
            public long Length => _data.Length;
            public string PhysicalPath { get; } = string.Empty;
            public string Name { get; } = string.Empty;
            public DateTimeOffset LastModified { get; } = DateTimeOffset.UtcNow;
            public bool IsDirectory { get; } = false;
        }

        private readonly IFileInfo _fileInfo;
        public InMemoryFileProvider(Stream stream) => _fileInfo = new InMemoryFile(stream);
        public IFileInfo GetFileInfo(string _) => _fileInfo;
        public IDirectoryContents GetDirectoryContents(string _) => null;
        public IChangeToken Watch(string _) => NullChangeToken.Singleton;
    }
}
