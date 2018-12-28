using GenTree.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenTree.Service
{
    public interface IExportDataService
    {
        void ExportData(List<Person> personList);
    }
}
