using ApiDogs.Data;
using ApiDogs.Models;
using ApiDogs.Models.DTO;
using Dapper;

namespace ApiDogs.Repositories
{
    public class DogsRepository
    {
        private readonly ConnectionDB _connectionDB;
        public DogsRepository(ConnectionDB connectionDB)
        {
            _connectionDB = connectionDB;
        }

        public async Task<Dado> GetByIDAsync(Guid id)
        {
            var sql = @"SELECT Id, DogType FROM Dog
                        WHERE Id = @Id";

            using(var con = _connectionDB.GetConnection())
            {
                return await con.QueryFirstOrDefault(sql, new {Id = id});
            }
        }

        public async Task CreateDog(DataApi dogDataResponse)
        {
            var sql = @"INSERT INTO Dog (Id, DogType) 
                        VALUES (@Id, @DogType)";

            using (var con = _connectionDB.GetConnection())
            {
                con.Open();
                await con.ExecuteAsync(sql, new {Id = dogDataResponse.dog.Id, DogType = dogDataResponse.dog.DogType });
            }
        }
    }

}
