using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FYP.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FYP.Services;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(FileService))]

namespace FYP.Droid
{
    public class FileService : IFileService
    {
        //File name
        private readonly string _filename = "UserInfo.txt";
        //Destination Path
        private string _destination;

        public string GetRootPath() 
        {
            //Gets the root path of the file
            return Application.Context.GetExternalFilesDir(null).ToString();

        }
        public void CreateFile(string userInput) 
        {
            //Creates the destination path of the file
            _destination = Path.Combine(GetRootPath(), _filename);
            //Makes sure that the file isn't overwritten after every input
            using (var writer = new StreamWriter(_destination, append: true))
            {
                writer.WriteLine(userInput);
            }
        }
        public void ClearFile()
        {
            //clears the file
            File.WriteAllText(_destination, _filename);
        }
    }

}