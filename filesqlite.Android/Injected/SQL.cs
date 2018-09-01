using PreferencesSQLite.Droid;
using System.IO;
using SQLite.Net.Interop;
using System;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(SQLUtils))]
namespace PreferencesSQLite.Droid
{
    public class SQLUtils : Java.Lang.Object, ISQLite
    {
        public SQLUtils()
        {
        }

        public string GetConnectionString()
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var pConnectionString = Path.Combine(documents, "preferences.db");
            var connectionString = string.Format("{0}; New=true; Version=3;PRAGMA locking_mode=EXCLUSIVE; PRAGMA journal_mode=WAL; PRAGMA cache_size=20000; PRAGMA page_size=32768; PRAGMA synchronous=off", pConnectionString);
            return connectionString;
        }

        public ISQLitePlatform GetPlatform()
        {
            return new SQLitePlatformAndroid();
        }

        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}