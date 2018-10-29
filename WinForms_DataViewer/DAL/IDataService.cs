using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DataViewer.DAL
{
    public interface IDataService
    {
        IEnumerable<Character> ReadAll();
        void WriteAll(IEnumerable<Character> characters);
    }
}
