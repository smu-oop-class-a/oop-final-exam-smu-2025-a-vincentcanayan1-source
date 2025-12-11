using System.IO;
using OOP.FinalTerm.Exam.Model;
using OOP.FinalTerm.Exam.Utils;
using SQLite;

namespace OOP.FinalTerm.Exam.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ISQLiteConnection _dbConnection;


        public DirectorRepository()
        {
            _dbConnection = new SQLiteConnection(DatabaseHelper.GetDatabasePath());
            _dbConnection.CreateTable<DirectorModel>();
            
            _dbConnection = new SQLiteConnection(DatabaseHelper.GetDatabasePath());            
            _dbConnection.CreateTable<DirectorModel>();

           
        }

       
        public void AddDirector(DirectorModel director)
        {
            
             _dbConnection.Insert(director);
        }

        
        public List<DirectorModel> GetAllDirectors()
        {
           
             _dbConnection.Table<DirectorModel>().ToList();
            return _dbConnection.Table<DirectorModel>().ToList();
        }

       
        public DirectorModel GetDirectorById(int id)
        {
           
             _dbConnection.Find<DirectorModel>(id);
            return _dbConnection.Find<DirectorModel>(id);
        }
    }
}