using System;
using System.Collections.Generic;
using System.Text;

namespace FYP.Services
{
    public interface IFileService
    {
        //Create the file and populate it
        void CreateFile(string userInput);
        //Clears the file
        void ClearFile();
    }
}
