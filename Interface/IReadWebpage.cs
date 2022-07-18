using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProject.Interface
{
    public interface IReadWebpage
    {
        Task ReadWebPage(string url);
    }
}
