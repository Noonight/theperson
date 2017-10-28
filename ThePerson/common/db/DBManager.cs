using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ThePerson.common.debug;
using ThePerson.common.db.tables;

namespace ThePerson.db {
    class DBManager {
        public static string connectionString
            = "datasource=127.0.0.1;port=3306;username=root;password=;database=theperson;";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public DBManager() {
            try {
                connection = new MySqlConnection(connectionString);
            } catch (Exception e) {
                Log.d(e.ToString());
            }
        }

        public List<Person> getPersons() {
            List<Person> persons = new List<Person>();
            script(PersonTable.GET_PERSONS_SCRIPT);
            try {
                reader = command.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        persons.Add(new ThePerson.Person(
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            getAddress(reader.GetString(5)),
                            getAddress(reader.GetString(6)),
                            getDocument(reader.GetString(7))
                            ));
                    }
                }
            } catch (Exception e) {
                Log.d(e.ToString());
            }

            return persons;
        }

        public Document getDocument(string id) {
            Document document = new Document();
            script(AddressTable.GET_ADDRESS_SCRIPT(id));
            try {
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        document.Type = getDocumentType(reader.GetString(1));
                        document.Series = reader.GetString(2);
                        document.Number = reader.GetString(3);
                        document.Date = reader.GetString(4);
                    }
                }
                else {
                    Log.d("Rows not found");
                }
                closeConnection();
            }
            catch (Exception e) {
                Log.d(e.ToString());
            }
            return document;
        }

        public DocumentType getDocumentType(string id) {
            return new DocumentType(id);
        }

        public Address getAddress(string id) {
            Address address = new Address();
            script(AddressTable.GET_ADDRESS_SCRIPT(id));
            try {
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        address.City = reader.GetString(1);
                        address.Street = reader.GetString(2);
                        address.Housing = reader.GetString(3);
                        address.Home = reader.GetString(4);
                    }
                } else {
                    Log.d("Rows not found");
                }
                closeConnection();
            } catch (Exception e) {
                Log.d(e.ToString());
            }
            return address;
        }

        private void script(string script) {
            openConnection();
            try {
                command = new MySqlCommand(script, connection);
                command.CommandTimeout = 60;
            } catch (Exception e) {
                Log.d(e.ToString());
            }
        }

        private void openConnection() {
            try {
                connection.Open();
            } catch (Exception e) {
                Log.d(e.ToString());
            }
        }

        private void closeConnection() {
            try {
                connection.Close();
            } catch (Exception e) {
                Log.d(e.ToString());
            }
        }
    }
}
