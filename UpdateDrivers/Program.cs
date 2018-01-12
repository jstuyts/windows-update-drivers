using System;
using WUApiLib;

namespace UpdateDrivers
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdateSession updateSession = new UpdateSession();

            Console.WriteLine("1/3 searching");
            IUpdateSearcher updateSearcher = updateSession.CreateUpdateSearcher();
            ISearchResult searchResult = updateSearcher.Search("Type='Driver' And IsInstalled=0 And IsHidden=0");
            foreach (IUpdate update in searchResult.Updates)
            {
                Console.WriteLine(update.Title);
            }

            Console.WriteLine("2/3 downloading");
            IUpdateDownloader updateDownloader = updateSession.CreateUpdateDownloader();
            updateDownloader.Updates = searchResult.Updates;
            updateDownloader.Download();

            Console.WriteLine("3/3 installing");
            IUpdateInstaller updateInstaller = updateSession.CreateUpdateInstaller();
            updateInstaller.Updates = searchResult.Updates;
            updateInstaller.Install();
        }
    }
}
