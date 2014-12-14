using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Octokit;

namespace Wampi
{
    internal static class UpdateChecker
    {
        private const string QuestionNewVersionCaption = "Update Check";
        private const string QuestionNewVersion = "There is a new version ({0}) available, do you want to download this new version?";
        private const string QuestionNoNewVersion = "You have the latest version.";

        private const string RepositoryOwner = "dogancelik";
        private const string RepositoryName = "Wampi";

        private const string UrlDownloadAsset = "https://github.com/{0}/{1}/releases/download/{2}/{3}";

        private static async Task GithubCheck(bool informNoNewVersion)
        {
            var client = new GitHubClient(new ProductHeaderValue("WampiUpdater"));
            var releases = await client.Release.GetAll(RepositoryOwner, RepositoryName);

            if (releases.Count == 0) return;

            var latestRelease = releases[0];
            Version parseVersion;
            Version currentVersion;

            if (Version.TryParse(latestRelease.TagName.Substring(1), out parseVersion) &&
                Version.TryParse(System.Windows.Forms.Application.ProductVersion, out currentVersion))
            {
                if (parseVersion.CompareTo(currentVersion) > 0)
                {
                    if (
                        MessageBox.Show(String.Format(QuestionNewVersion, parseVersion), QuestionNewVersionCaption, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*var assets = await client.Release.GetAssets(RepositoryOwner, RepositoryName, latestRelease.Id);
                        var latestAsset = assets[0];
                        Process.Start(String.Format(UrlDownloadAsset, RepositoryOwner, RepositoryName, latestRelease.TagName, latestAsset.Name));*/
                        Process.Start(latestRelease.HtmlUrl);
                    }
                }
                else
                {
                    if (informNoNewVersion)
                        MessageBox.Show(QuestionNoNewVersion, QuestionNewVersionCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static Task Check(bool informNoNewVersion = false)
        {
            return GithubCheck(informNoNewVersion);
        }
    }
}