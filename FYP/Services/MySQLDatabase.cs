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
            if (db != null)
            {
                return;
            }
            string databasepath = Path.Combine(FileSystem.AppDataDirectory, "mydatbase.db3");
            db = new SQLiteAsyncConnection(databasepath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
            db.CreateTableAsync<MyTable>();
        }

        public void InsertData(int gameid, string preorder,string rating,string standards,string overpriced,string agerating,string gameplay,string recommend,string impact)
        {
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


