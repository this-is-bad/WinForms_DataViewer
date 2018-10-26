using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DataViewer
{
    public interface IDataService
    {
        List<Character> ReadAll();
        void WriteAll(List<Character> characters);
    }
}
