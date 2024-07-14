using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    public class SqlQuery
    {
        public SqlQuery() 
        {
            sqlConnection = "";
        }

        public SqlQuery(string sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        public async Task CreateTable(string sqlCommand)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = sqlCommand;
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task FieldTableStatsPlayerDef()
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $@"INSERT INTO StatsPlayer(idPlayer, balancePlayer, speedClick, speedVideoCard, speedProcessor, currentEnergy, maxEnergy, lastVisitDate) 
                    VALUES(1, 0, 1, 0, 0, 1000, 1000, '2024-01-01 00:00:00');";
                await command.ExecuteScalarAsync();
            }
        }

        public async Task FieldTableStatisticsDef()
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $@"INSERT INTO Statistics(idStats, quantityClick, totalSumClickMoney, totalSumAutoMoney, level, quantityAchives,
                    quantityMouse, quantityVideocard, quantityProcessor, dateBegin) VALUES(1, 0, 0, 0, 0, 0, 0, 0, 0, '2024-01-01 00:00:00')";
                await command.ExecuteScalarAsync();
            }
        }

        private readonly string sqlConnection;
    }
}
