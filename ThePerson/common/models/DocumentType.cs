using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePerson.common.debug;

namespace ThePerson {
    class DocumentType {

        public string Type { get; private set; }

        public DocumentType(string id) {
            switch(id) {
                case "0":
                    Type = PASSPORT;
                    break;
                case "1":
                    Type = BIRTH_CERTIFICATE;
                    break;
                case "2":
                    Type = INTERNATIONAL_PASSPORT;
                    break;
                default:
                    Log.d("Не найден ид");
                    break;
            }
        }
        // 0; 1; 2 id_s
        public static string PASSPORT = "Паспорт";
        public static string BIRTH_CERTIFICATE = "Свидетельство о рождении";
        public static string INTERNATIONAL_PASSPORT = "Загран паспорт";
    }
}
