using System;

namespace MyBookLibrary01
{
    public class Book
    {
        public string id;
        public string name;
        public string publisher;
        public float price;

        public Book()
        {
        }

        public Book(string id, string name, string publisher, float price)
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
            this.price = price;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
