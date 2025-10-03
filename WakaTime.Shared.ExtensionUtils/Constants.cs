namespace WakaTime.Shared.ExtensionUtils
{
    public static class Constants
    {
        internal const string GithubDownloadPrefix = "https://github.com/adrianteixeira-srs/wakatime-cli/releases/download";
        internal const string GithubReleasesAlphaUrl = "https://api.github.com/repos/adrianteixeira-srs/wakatime-cli/releases?per_page=1";
        internal const string GithubReleasesStableUrl = "https://api.github.com/repos/adrianteixeira-srs/wakatime-cli/releases/latest";

        internal const int HeartbeatFrequency = 2; // minutes
    }
}
