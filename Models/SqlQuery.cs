﻿using Microsoft.Data.Sqlite;
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
            sqlConnection = string.Empty;
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

        internal async Task FieldTableStatsPlayerDef()
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

        internal async Task ReadTableStatsPlayer(StatsPlayer myBalance)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM StatsPlayer WHERE idPlayer = 1;";
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        myBalance.changeData(reader.GetInt32(2), reader.GetInt64(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetDateTime(7));
                    }
                }
            }
        }

        internal async Task FieldTableStatisticsDef()
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

        internal async Task ReadTableStatistics(Statistics stats)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Statistics WHERE idStats = 1;";
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            stats.ChangeData(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetDateTime(9));
                        }
                    }
                }
            }
        }

        internal async Task FieldTableMousesDef(Dictionary<string, Mouse> mouses, List<string> namesMouse)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $@"INSERT INTO Mouses(idMouse, price, speed, quantity) VALUES (@id, @price, @speed, @quantity);";
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter priceParam = new SqliteParameter();
                SqliteParameter speedParam = new SqliteParameter();
                SqliteParameter quantityParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                priceParam.ParameterName = "@price";
                speedParam.ParameterName = "@speed";
                quantityParam.ParameterName = "@quantity";
                command.Parameters.Add(idParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(speedParam);
                command.Parameters.Add(quantityParam);
                for (int i = 0; i < mouses.Count; i++)
                {
                    idParam.Value = i + 1;
                    priceParam.Value = mouses[namesMouse[i]].Price;
                    speedParam.Value = mouses[namesMouse[i]].SpeedClick;
                    quantityParam.Value = mouses[namesMouse[i]].Quantity;
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task ReadTableMouses(Dictionary<string, Mouse> mouses, List<string> namesMouse)
        {
            using(var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                int countComponent = 0;
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Mouses;";
                using (SqliteDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            mouses[namesMouse[countComponent]].ChangeData(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                            countComponent++;
                        }
                    }
                }
            }
        }

        internal async Task FieldTableVideoCardDef(Dictionary<string, VideoCard> videocards, List<string> nameVideocard)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $@"INSERT INTO Videocards(idVideocard, price, speed, quantity) VALUES (@id, @price, @speed, @quantity);";
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter priceParam = new SqliteParameter();
                SqliteParameter speedParam = new SqliteParameter();
                SqliteParameter quantityParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                priceParam.ParameterName = "@price";
                speedParam.ParameterName = "@speed";
                quantityParam.ParameterName = "@quantity";
                command.Parameters.Add(idParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(speedParam);
                command.Parameters.Add(quantityParam);
                for (int i = 0; i < videocards.Count; i++)
                {
                    idParam.Value = i + 1;
                    priceParam.Value = videocards[nameVideocard[i]].Price;
                    speedParam.Value = videocards[nameVideocard[i]].Speed;
                    quantityParam.Value = videocards[nameVideocard[i]].Quantity;
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task ReadTableVideoCard(Dictionary<string, VideoCard> videocards, List<string> namesVideocard)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                int countComponent = 0;
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Videocards;";
                using (SqliteDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            videocards[namesVideocard[countComponent]].ChangeData(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                            countComponent++;
                        }
                    }
                }
            }
        }

        internal async Task FieldTableProcessorDef(Dictionary<string, Processor> processors, List<string> nameProcessor)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $@"INSERT INTO Processors(idProcessor, price, speed, quantity) VALUES (@id, @price, @speed, @quantity);";
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter priceParam = new SqliteParameter();
                SqliteParameter speedParam = new SqliteParameter();
                SqliteParameter quantityParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                priceParam.ParameterName = "@price";
                speedParam.ParameterName = "@speed";
                quantityParam.ParameterName = "@quantity";
                command.Parameters.Add(idParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(speedParam);
                command.Parameters.Add(quantityParam);
                for (int i = 0; i < processors.Count; i++)
                {
                    idParam.Value = i + 1;
                    priceParam.Value = processors[nameProcessor[i]].Price;
                    speedParam.Value = processors[nameProcessor[i]].Speed;
                    quantityParam.Value = processors[nameProcessor[i]].Quantity;
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task ReadTableProcessor(Dictionary<string, Processor> processors, List<string> namesProcessor)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                int countComponent = 0;
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Processors;";
                using (SqliteDataReader reader =await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            processors[namesProcessor[countComponent]].ChangeData(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                            countComponent++;
                        }
                    }
                }
            }
        }

        internal async Task FieldTableLevelDef(Dictionary<string, Level> levels, List<string> nameLevels)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $@"INSERT INTO Levels(idLevel, isDone) VALUES (@id, @isdone);";
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter isDoneParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                isDoneParam.ParameterName = "@isdone";
                command.Parameters.Add(idParam);
                command.Parameters.Add(isDoneParam);
                for (int i = 0; i < levels.Count; i++)
                {
                    idParam.Value = i + 1;
                    isDoneParam.Value = levels[nameLevels[i]].IsDone;
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task ReadTableLevel(Dictionary<string, Level> levels, List<string> namesLevels)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                int countComponent = 0;
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Levels;";
                using (SqliteDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            levels[namesLevels[countComponent]].IsDone = Convert.ToBoolean(reader.GetInt32(1));
                            countComponent++;
                        }
                    }
                }
            }
        }

        internal async Task FieldTableAchiveDef(Dictionary<string, Achives> achives, List<string> nameAchives)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = $@"INSERT INTO Achives(idAchives, isDone) VALUES (@id, @isdone);";
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter isDoneParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                isDoneParam.ParameterName = "@isdone";
                command.Parameters.Add(idParam);
                command.Parameters.Add(isDoneParam);
                for(int i = 0; i < achives.Count; i++)
                {
                    idParam.Value = i + 1;
                    isDoneParam.Value = achives[nameAchives[i]].IsDone;
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task ReadTableAchive(Dictionary<string, Achives> achives, List<string> nameAchives)
        {
            using(var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                int countComponent = 0;
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Achives;";
                using (SqliteDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            achives[nameAchives[countComponent]].IsDone = Convert.ToBoolean(reader.GetInt32(1));
                            countComponent++;
                        }
                    }
                }
            }
        }

        private readonly string sqlConnection;
    }
}
