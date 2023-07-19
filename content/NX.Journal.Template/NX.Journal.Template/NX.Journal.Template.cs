using NXOpen;

namespace NX.Journal.Template
{
    public class NXJournal
    {
        public static void Main(string[] args)
        {
            NXOpen.Session theSession = NXOpen.Session.GetSession();
            Guide.InfoWriteLine("Hello World!");
        }

        public static int GetUnloadOption(string dummy) { return (int)NXOpen.Session.LibraryUnloadOption.Immediately; }
    }
}
