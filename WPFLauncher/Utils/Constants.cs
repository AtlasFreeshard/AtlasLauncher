﻿namespace WPFLauncher
{
    internal class Constants
    {
        public const string LauncherVersion = "1.0.1";

        #region Patcher

        public const string LauncherUpdaterName = "AtlasLauncher_Update.exe";
        public const string AppData = @"%AppData%\";
        public const string UserPath = "\\Electronic Arts\\Dark Age of Camelot\\Atlas\\user.dat";
        public const string RegisterUrl = "https://atlasl.ink/register";
        public const string PatchNotesUrl = "https://atlasl.ink/patch-notes";

        public const string
            RemoteVersionUrl = "https://patch.atlasfreeshard.com/version-new.txt"; //TODO change to production url

        public const string
            RemoteFileList = "https://patch.atlasfreeshard.com/patchlist-new.txt"; //TODO change to production url

        public static string RemoteFilePath;

        #endregion

        #region gameserver

        public const string LiveIP = "play.atlasfreeshard.com";
        public const string PtrIP = "144.76.41.4:10325";

        #endregion

        #region Messages

        public const string MessageDownloadError = "Error downloading files. Please try again later.";
        public const string MessageNoCredentials = "Please enter your account and password.";

        public const string MessageReviewInstallation =
            "There was an error launching the game, please review your installation.";

        #endregion
    }
}