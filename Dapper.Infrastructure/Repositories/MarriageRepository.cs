using System;
using System.Linq;
using Dapper.Core.Entities;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Dapper.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlTypes;

namespace Dapper.Infrastructure.Repositories
{
    public class MarriageRepository : IMarriageRepository
    {
        private readonly string _connectionString;

        public MarriageRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<int> AddAsync(Marriage marriage)
        {
           
            const string sql = @"
         INSERT INTO Marriages 
             (statistic_yyy, according, site_id, marry_count, marriage_type, sex, nation, edu, age)
              VALUES 
             (@statistic_yyy, @according, @site_id, @marry_count, @marriage_type, @sex, @nation, @edu, @age)";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, marriage);
                return result;
            }
        }
        public async Task<int> DeleteAsync(int id)
        {
            const string sql = "DELETE FROM Marriages WHERE Id = @Id";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }
        public async Task<IReadOnlyList<Marriage>> GetAllAsync()
        {
            const string sql = "SELECT * FROM Marriages";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<Marriage>(sql);
                return result.ToList();
            }
        }
        public async Task<Marriage> GetByIdAsync(int id)
        {
            const string sql = "SELECT * FROM Marriages WHERE Id = @Id";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Marriage>(sql, new { Id = id });
                return result;
            }
        }
        public async Task<int> UpdateAsync(Marriage marriage)
        {
            
            const string sql = @"
        UPDATE Marriages 
        SET 
            statistic_yyy = @statistic_yyy, 
            according = @according, 
            site_id = @site_id, 
            marry_count = @marry_count, 
            marriage_type = @marriage_type, 
            sex = @sex, 
            nation = @nation, 
            edu = @edu, 
            age = @age
        WHERE 
            Id = @Id";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, marriage);
                return result;
            }
        }
    }
}
