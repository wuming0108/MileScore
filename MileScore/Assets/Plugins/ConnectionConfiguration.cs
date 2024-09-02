using UnityEngine;

namespace Hmxs.Scripts.MySQL
{
    [CreateAssetMenu(fileName = "ConnectionConfiguration", menuName = "Mysql/ConnectionConfiguration")]
    public class ConnectionConfiguration : ScriptableObject
    {
        public string server = "mysql.sqlpub.com";
        public string database = "gning_score";
        public string uid = "wuming0108";
        public string password = "BQw0Q8PelLYwUd4v";
        public uint port = 3306;
    }
}