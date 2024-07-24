using Microsoft.Data.Sqlite;

namespace SergxloveCoin.resourse
{
    public class SqlUpdateQuery
    {
        public SqlUpdateQuery()
        {
            sqlConnection = string.Empty;
        }

        public SqlUpdateQuery(string sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        internal async Task UpdateTableMouse(Dictionary<string, Mouse> mouses, List<string> namesMouse)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
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
                command.Connection = connection;
                command.CommandText = "UPDATE Mouses SET price = @price, speed = @speed, quantity = @quantity WHERE idMouse = @id;";
                for (int i = 0; i < namesMouse.Count; i++)
                {
                    idParam.Value = i + 1;
                    priceParam.Value = mouses[namesMouse[i]].Price;
                    speedParam.Value = mouses[namesMouse[i]].SpeedClick;
                    quantityParam.Value = mouses[namesMouse[i]].Quantity;
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task UpdateTableVideoCard(Dictionary<string, VideoCard> videoCards, List<string> namesVideoCard)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
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
                command.Connection = connection;
                command.CommandText = "UPDATE Videocards SET price = @price, speed = @speed, quantity = @quantity WHERE idVideocard = @id;";
                for (int i = 0; i < namesVideoCard.Count; i++)
                {
                    idParam.Value = i + 1;
                    priceParam.Value = videoCards[namesVideoCard[i]].Price;
                    speedParam.Value = videoCards[namesVideoCard[i]].Speed;
                    quantityParam.Value = videoCards[namesVideoCard[i]].Quantity;
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task UpdateTableProcessor(Dictionary<string, Processor> processors, List<string> namesProcessor)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
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
                command.Connection = connection;
                command.CommandText = "UPDATE Processors SET price = @price, speed = @speed, quantity = @quantity WHERE idProcessor = @id;";
                for (int i = 0; i < namesProcessor.Count; i++)
                {
                    idParam.Value = i + 1;
                    priceParam.Value = processors[namesProcessor[i]].Price;
                    speedParam.Value = processors[namesProcessor[i]].Speed;
                    quantityParam.Value = processors[namesProcessor[i]].Quantity;
                    command.ExecuteNonQuery();
                }

            }
        }

        internal async Task UpdateTableLevel(Dictionary<string, Level> levels, List<string> namesLevel)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter isDoneParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                isDoneParam.ParameterName = "@isDone";
                command.Parameters.Add(idParam);
                command.Parameters.Add(isDoneParam);
                command.Connection = connection;
                command.CommandText = "UPDATE Levels SET isDone = @isDone WHERE idLevel = @id;";
                for (int i = 0; i < namesLevel.Count; i++)
                {
                    idParam.Value = i + 1;
                    if (levels[namesLevel[i]].IsDone)
                    {
                        isDoneParam.Value = 1;
                    }
                    else
                    {
                        isDoneParam.Value = 0;
                    }
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task UpdateTableAchive(Dictionary<string, Achives> achives, List<string> namesAchive)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter isDoneParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                isDoneParam.ParameterName = "@isDone";
                command.Parameters.Add(idParam);
                command.Parameters.Add(isDoneParam);
                command.Connection = connection;
                command.CommandText = "UPDATE Achives SET isDone = @isDone WHERE idAchives = @id;";
                for (int i = 0; i < achives.Count; i++)
                {
                    idParam.Value = i + 1;
                    if (achives[namesAchive[i]].IsDone)
                    {
                        isDoneParam.Value = 1;
                    }
                    else
                    {
                        isDoneParam.Value = 0;
                    }
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal async Task UpdateTableStatistics(Statistics stats)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                SqliteParameter quantityClickParam = new SqliteParameter();
                SqliteParameter totalSumClickMoneyParam = new SqliteParameter();
                SqliteParameter totalSumAutoMoneyParam = new SqliteParameter();
                SqliteParameter levelParam = new SqliteParameter();
                SqliteParameter quantityAchivesParam = new SqliteParameter();
                SqliteParameter quantityMouseParam = new SqliteParameter();
                SqliteParameter quantityVideoCardParam = new SqliteParameter();
                SqliteParameter quantityProcessorParam = new SqliteParameter();
                quantityClickParam.ParameterName = "@quantityClick";
                totalSumClickMoneyParam.ParameterName = "@totalSumClickMoney";
                totalSumAutoMoneyParam.ParameterName = "@totalSumAutoMoney";
                levelParam.ParameterName = "@level";
                quantityAchivesParam.ParameterName = "@quantityAchive";
                quantityMouseParam.ParameterName = "@quantityMouse";
                quantityVideoCardParam.ParameterName = "@quantityVideocard";
                quantityProcessorParam.ParameterName = "@quantityProcessor";
                command.Parameters.Add(quantityClickParam);
                command.Parameters.Add(totalSumClickMoneyParam);
                command.Parameters.Add(totalSumAutoMoneyParam);
                command.Parameters.Add(levelParam);
                command.Parameters.Add(quantityAchivesParam);
                command.Parameters.Add(quantityMouseParam);
                command.Parameters.Add(quantityVideoCardParam);
                command.Parameters.Add(quantityProcessorParam);
                command.Connection = connection;
                command.CommandText = @"UPDATE Statistics SET quantityClick = @quantityClick, totalSumClickMoney = @totalSumClickMoney, totalSumAutoMoney = @totalSumAutoMoney, 
                                      level = @level, quantityAchives = @quantityAchive, quantityMouse = @quantityMouse, quantityVideocard = @quantityVideocard, 
                                      quantityProcessor = @quantityProcessor WHERE idStats = 1;";
                quantityClickParam.Value = stats.QuantityClick;
                totalSumClickMoneyParam.Value = stats.TotalSumClickMoney;
                totalSumAutoMoneyParam.Value = stats.TotalSumAutoMoney;
                levelParam.Value = stats.Level;
                quantityAchivesParam.Value = stats.QuantityAchives;
                quantityMouseParam.Value = stats.QuantityMouse;
                quantityVideoCardParam.Value = stats.QuantityVideocard;
                quantityProcessorParam.Value = stats.QuantityProcessor;
                await command.ExecuteNonQueryAsync();
            }
        }

        internal async Task UpdateTableStatsPlayer(StatsPlayer stats)
        {
            using (var connection = new SqliteConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqliteCommand command = connection.CreateCommand();
                SqliteParameter idParam = new SqliteParameter();
                SqliteParameter priceParam = new SqliteParameter();
                SqliteParameter speedParam = new SqliteParameter();
                SqliteParameter speedClickParam = new SqliteParameter();
                SqliteParameter quantityParam = new SqliteParameter();
                SqliteParameter currentEnergyParam = new SqliteParameter();
                SqliteParameter maxEnergyParam = new SqliteParameter();
                SqliteParameter lastVisitDateParam = new SqliteParameter();
                idParam.ParameterName = "@id";
                priceParam.ParameterName = "@price";
                speedParam.ParameterName = "@speed";
                speedClickParam.ParameterName = "@speedClick";
                quantityParam.ParameterName = "@quantity";
                currentEnergyParam.ParameterName = "@currentEnergy";
                maxEnergyParam.ParameterName = "@maxEnergy";
                lastVisitDateParam.ParameterName = "@lastVisitDate";
                command.Parameters.Add(idParam);
                command.Parameters.Add(priceParam);
                command.Parameters.Add(speedParam);
                command.Parameters.Add(speedClickParam);
                command.Parameters.Add(quantityParam);
                command.Parameters.Add(currentEnergyParam);
                command.Parameters.Add(maxEnergyParam);
                command.Parameters.Add(lastVisitDateParam);
                command.Connection = connection;
                command.CommandText = @"UPDATE StatsPlayer SET balancePlayer = @price, speedClick = @speedClick, speedVideoCard = @speed, speedProcessor = @quantity , 
                                      currentEnergy = @currentEnergy, maxEnergy = @maxEnergy, lastVisitDate = @lastVisitDate WHERE idPlayer = 1;";
                priceParam.Value = stats.BalansePlayer;
                speedClickParam.Value = stats.SpeedClick;
                speedParam.Value = stats.SpeedVideoCard;
                quantityParam.Value = stats.SpeedProcessor;
                currentEnergyParam.Value = stats.CurrentEnergy;
                maxEnergyParam.Value = stats.MaxEnergy;
                lastVisitDateParam.Value = stats.LastVisitDate;
                await command.ExecuteNonQueryAsync();
            }
        }

        private readonly string sqlConnection;
    }
}
