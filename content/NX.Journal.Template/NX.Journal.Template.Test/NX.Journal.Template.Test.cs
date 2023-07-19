using System;
using Xunit;
using NXOpen;
using NX.Journal.Template;

namespace NX.Journal.Template.Test
{
    public class NXJournalTest
    {
        [Fact]
        public void FirstTest()
        {
            int exitCode = NXJournal.GetUnloadOption("");
            Assert.Equal(1, exitCode);
        }
    }
}
