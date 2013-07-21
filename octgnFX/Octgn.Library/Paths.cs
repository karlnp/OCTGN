﻿namespace Octgn.Library
{
    using System;
    using System.IO.Abstractions;
    using System.Reflection;

    using log4net;

    public interface IPaths
    {
        /// <summary>
        /// The working directory of the executable
        /// </summary>
        string WorkingDirectory { get; set; }
        /// <summary>
        /// The base path of the executable. Currently the same as WorkingDirectory
        /// </summary>
        string BasePath { get; }
        /// <summary>
        /// The folder just above the OCTGN Install folder
        /// </summary>
        string UserDirectory { get; }
        string PluginPath { get; }
        string DataDirectory { get; }
        string DatabasePath { get; }
        string ImageDatabasePath { get; }
        string ConfigDirectory { get; }
        string FeedListPath { get; }
        string LocalFeedPath { get; }
        string MainOctgnFeed { get; }
        string DeckPath { get; }
        string GraveyardPath { get; }
    }

    public class Paths : IPaths
    {
        internal static ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        #region Singleton

        internal static IPaths SingletonContext { get; set; }

        private static readonly object PathsSingletonLocker = new object();

        public static IPaths Get()
        {
            lock (PathsSingletonLocker) return SingletonContext ?? (SingletonContext = new Paths());
        }

        internal Paths()
        {
            Log.Info("Creating paths");
            if (FS == null)
                FS = new FileSystem();
            try
            {
                if (WorkingDirectory == null)
                    WorkingDirectory = Assembly.GetEntryAssembly().Location;
            }
            catch
            {
            }
            UserDirectory = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Octgn");
            BasePath = FS.Path.GetDirectoryName(WorkingDirectory) + "\\";
            DataDirectory = SimpleConfig.Get().DataDirectory;
            PluginPath = FS.Path.Combine(UserDirectory, "Plugins");
            //DatabasePath = FS.Path.Combine(SimpleConfig.Get().DataDirectory, "Database");
            DatabasePath = FS.Path.Combine(DataDirectory, "GameDatabase");
            ImageDatabasePath = FS.Path.Combine(DataDirectory, "ImageDatabase");

            ConfigDirectory = System.IO.Path.Combine(UserDirectory, "Config");
            FeedListPath = FS.Path.Combine(ConfigDirectory, "feeds.txt");
            LocalFeedPath = FS.Path.Combine(UserDirectory, "LocalFeed");
            FS.Directory.CreateDirectory(LocalFeedPath);
            DeckPath = FS.Path.Combine(DataDirectory, "Decks");
            MainOctgnFeed = "https://www.myget.org/F/octgngames/";

            foreach (var prop in this.GetType().GetProperties())
            {
                Log.InfoFormat("Path {0} = {1}", prop.Name, prop.GetValue(this, null));
            }
        }

        #endregion Singleton

        internal IFileSystem FS { get; set; }
        public string WorkingDirectory { get; set; }
        public string BasePath { get; private set; }
        public string UserDirectory { get; private set; }
        public string PluginPath { get; private set; }
        public string DataDirectory { get; private set; }
        public string DatabasePath { get; set; }
        public string ImageDatabasePath { get; set; }
        public string ConfigDirectory { get; set; }
        public string FeedListPath { get; set; }
        public string LocalFeedPath { get; set; }
        public string MainOctgnFeed { get; set; }
        public string DeckPath { get; set; }
        public string GraveyardPath
        {
            get
            {
                var ret = FS.Path.Combine(DataDirectory, "Garbage");
                if (!FS.Directory.Exists(ret)) FS.Directory.CreateDirectory(ret);
                ret = FS.Path.Combine(ret, Guid.NewGuid().ToString());
                return ret;
            }
        }
    }
}
