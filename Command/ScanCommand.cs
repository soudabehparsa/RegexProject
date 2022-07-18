using ConsoleAppFramework;
using RegexProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProject.Command
{
    public class ScanCommand : ConsoleAppBase
    {
        private readonly IReadWebpage _readWebpae;
        public ScanCommand(IReadWebpage readWebpage)
        {
            _readWebpae = readWebpage;
        }

        [RootCommand]
        public async Task Read()
        {
            await _readWebpae.ReadWebPage("http://1337.tech/");
        }
    }
}
