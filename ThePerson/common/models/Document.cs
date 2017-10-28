using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePerson {
    class Document {
        public DocumentType Type { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }

        public Document() { }

        public Document(DocumentType docType, string series, string number, string date) {
            Type = docType;
            Series = series;
            Number = number;
            Date = date;
        }

        public override string ToString() {
            return string.Format("Document type: {0}\nDocument series: {1}\nDocument number: {2}\nDocument date: {3}",
                Type, Series, Number, Date);
        }
    }
}
