using SQLite;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;


namespace FYP.Services
{
    public class MySQLDatabase
    {
        private static SQLiteAsyncConnection db;

        public void MyDatabase()
        {
            //Makes sure that our database isn't null
            if (db != null)
            {
                return;
            }
            //if it is we create it
            string databasepath = Path.Combine(FileSystem.AppDataDirectory, "mydatbase.db");
            //Set flags to be able to write and read from our database
            db = new SQLiteAsyncConnection(databasepath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
            //Create the amount of rows based on the properties of MyTable class
            db.CreateTableAsync<MyTable>();
        }

        public void InsertData(int gameid, string preorder,string rating,string standards,string overpriced,string agerating,string gameplay,string recommend,string impact)
        {
            //Adds all the user input into the database
            MyTable myNewTable = new MyTable
            {
                GameId = gameid,
                PreOrder = preorder,
                Rating = rating,
                Standards = standards,
                OverPriced = overpriced,
                AgeRating = agerating,
                Gameplay = gameplay,
                Recommend = recommend,
                Impact = impact
            };
            db.InsertAsync(myNewTable);
        }
    }

}


