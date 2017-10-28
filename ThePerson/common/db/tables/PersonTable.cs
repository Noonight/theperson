using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePerson.common.db.tables {
    class PersonTable {
        public static string TABLE = "person";
        public static string CREATE_TABLE_SCRIPT = "CREATE TABLE";
        public static string GET_PERSONS_SCRIPT = "SELECT * FROM " + TABLE;

        public static string GET_PERSON_SCRIPT(string id) {
            return string.Format("SELECT * FROM {0} WHERE {1} = {2}", TABLE, COLUMNS.ID, id);
        }

        public static string INSERT_PERSON_SCRIPT(string firstName, string lastName, string fatherName, string dateBirthday
            , string idLifePlace, string idBirthdayPlace, string idDocument) {
            return string.Format("INSERT INTO person(`"+ COLUMNS.FIRST_NAME + "`, `" + COLUMNS.LAST_NAME + "`,"+
                "`" + COLUMNS.FATHER_NAME + "`, `" + COLUMNS.DATE_BIRTHDAY + "`, `" + COLUMNS.ID_LIFE_PLACE + "`"+
                ", `" + COLUMNS.ID_BIRTHDAY_PLACE + "`, `"+COLUMNS.ID_DOCUMENT+"`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}'" +
                ", '{5}')", firstName, lastName, fatherName, dateBirthday, idLifePlace, idBirthdayPlace, idDocument);
        }

        static class COLUMNS {
            public static string ID = "person_id";
            public static string FIRST_NAME = "first_name";
            public static string LAST_NAME = "last_name";
            public static string FATHER_NAME = "father_name";
            public static string DATE_BIRTHDAY = "date_birthday";
            public static string ID_LIFE_PLACE = "id_life_place";
            public static string ID_BIRTHDAY_PLACE = "id_birthday_place";
            public static string ID_DOCUMENT = "id_document";
        }
    }
}
