using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using nanoFramework.Json;

#nullable enable

namespace CuteIoT.Services
{
    internal class ConfigurationService
    {
        private readonly string _internalPath;

        public ConfigurationService(string internalPath = "I:\\configuration.json")
        {
            _internalPath = internalPath;
        }

        public void Save(Configuration configuration)
        {
            if (File.Exists(_internalPath))
            {
                File.Delete(_internalPath);
            }

            var json = JsonConvert.SerializeObject(configuration);
            using var file = File.OpenWrite(_internalPath);
            var bytes = Encoding.UTF8.GetBytes(json);
            file.Write(bytes, 0, bytes.Length);
            file.Flush();
        }

        public Configuration Read()
        {
            if (!File.Exists(_internalPath))
            {
                Debug.WriteLine("Config not found");
                Thread.Sleep(Timeout.Infinite);
            }

            using var file = File.OpenText(_internalPath);
            var text = file.ReadToEnd();
            Debug.WriteLine(text);
            return (Configuration)JsonConvert.DeserializeObject(text, typeof(Configuration));
        }
    }
}
