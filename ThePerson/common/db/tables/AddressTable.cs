using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePerson.common.db.tables {
    class AddressTable {
        public static string TABLE = "address";
        public static string CREATE_TABLE_SCRIPT = "CREATE TABLE";
        public static string GET_ADRESSS_SCRIPT = "SELECT * FROM " + TABLE;

        public static string GET_ADDRESS_SCRIPT(string id) {
            return string.Format("SELECT * FROM {0} WHERE {1} = {2}", TABLE, COLUMNS.ID, id);
        }

        public static string INSERT_ADDRESS_SCRIPT(string city, string street, string housing, string home) {
            return string.Format("INSERT INTO {4}(`" + COLUMNS.CITY + "`, `" + COLUMNS.STREET + "`," +
                "`" + COLUMNS.HOUSING + "`, `" + COLUMNS.HOME + "`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}')", city, street, housing, home, TABLE);
        }

        static class COLUMNS {
            public static string ID = "address_id";
            public static string CITY = "city";
            public static string STREET = "street";
            public static string HOUSING = "housing";
            public static string HOME = "home";
        }
    }
}
