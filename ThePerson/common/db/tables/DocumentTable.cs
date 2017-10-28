using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePerson.common.db.tables {
    class DocumentTable {
        public static string TABLE = "document";
        public static string CREATE_TABLE_SCRIPT = "CREATE TABLE";
        public static string GET_DOCUMENTS_SCRIPT = "SELECT * FROM " + TABLE;

        public static string GET_DOCUMENT_SCRIPT(string id) {
            return string.Format("SELECT * FROM {0} WHERE {1} = {2}", TABLE, COLUMNS.ID, id);
        }

        public static string INSERT_DOCUMENTS_SCRIPT(string typeId, string series, string number, string date) {
            return string.Format("INSERT INTO {4}(`" + COLUMNS.TYPE_ID + "`, `" + COLUMNS.SERIES + "`," +
                "`" + COLUMNS.NUMBER + "`, `" + COLUMNS.DATE + "`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}')", typeId, series, number, date, TABLE);
        }

        static class COLUMNS {
            public static string ID = "address_id";
            public static string TYPE_ID = "type_id";
            public static string SERIES = "series";
            public static string NUMBER = "number";
            public static string DATE = "date";
        }
    }
}
