using MySql.Data.MySqlClient;
using UnityEngine;

 
    public class DatabaseManager : MonoBehaviour
    {
        #region VARIABLES

        [Header("Database Properties")]
        public string Host = "mysql.sqlpub.com";
        public string User = "wuming0108";
        public string Password = "BQw0Q8PelLYwUd4v";
        public string Database = "gning_score";
        public uint Port = 3306;

        #endregion

        #region UNITY METHODS

        private void Start()
        {
            Connect();
        }

        #endregion

        #region METHODS

        private void Connect()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Host;
            builder.UserID = User;
            builder.Password = Password;
            builder.Database = Database;
            builder.Port = Port;
            try
            {
                string connectionString = string.Format("server={0};user={1};database={2};port={3};password={4}",Host,User,Database,Port,Password) ;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    print("MySQL - Opened Connection");
                }
            }
            catch (MySqlException exception)
            {
                print(exception.Message);
            }
        }

        #endregion
    } 