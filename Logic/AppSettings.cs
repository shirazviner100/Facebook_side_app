using System.Xml.Serialization;
using System.IO;

namespace Logic
{
    public class AppSettings
    {
        private static readonly string r_FileLocation = @"D:\UserData.xml";

        public bool RememberUser
        {
            get;
            set;
        }

        public string LastAccessToken
        {
            get;
            set;
        }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings userSetting = new AppSettings();

            if (File.Exists(r_FileLocation))
            {
                using (Stream stream = new FileStream(r_FileLocation, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    userSetting = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return userSetting;
        }

        public void SaveToFile()
        {
            if (!File.Exists(r_FileLocation))
            {
                Stream stream = new FileStream(r_FileLocation, FileMode.Create);
                stream.Dispose();
            }

            using (Stream stream = new FileStream(r_FileLocation, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
