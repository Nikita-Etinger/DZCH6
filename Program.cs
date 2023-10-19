using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Store
    {
        private string storeName;
        private string address;
        private string profileDescription;
        private string contactPhone;
        private string contactEmail;
        private float area;

        public Store() { }
        public Store(string name, string addr, string description, string phone, string email,float area)
        {
            storeName = name;
            address = addr;
            profileDescription = description;
            contactPhone = phone;
            contactEmail = email;
            this.area = area;
        }
        public static bool operator >(Store other1,Store other2)
        {
            return other1.area > other2.area;
        }
        public static bool operator <(Store other1, Store other2)
        {
            return !(other1 > other2);
        }
        public static bool operator!=(Store other1, Store other2)
        {
            return other1.area != other2.area;
        }
        public static bool operator ==(Store other1, Store other2)
        {
            return !(other1.area != other2.area);
        }
        public static Store operator +(Store other1, float value)
        {
            other1.area += value;
            return other1;
        }
        public static Store operator -(Store other1, float value)
        {
            if (other1.area > 0)
            {
                other1.area -= value;
            }
            else other1.area = 0;
            return other1;
        }
        public override bool Equals(object obj)
        {
            if (obj == null|| obj.GetType() != GetType())
            {
                return false;
            }
            Store other = (Store)obj;   
            return other.area == area;
        }
        public override int GetHashCode()
        {
            return area.GetHashCode();
        }
        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ProfileDescription
        {
            get { return profileDescription; }
            set { profileDescription = value; }
        }

        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }

        public void DisplayStoreInfo()
        {
            Console.WriteLine("Название магазина: " + StoreName);
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Описание профиля магазина: " + ProfileDescription);
            Console.WriteLine("Контактный телефон: " + ContactPhone);
            Console.WriteLine("Контактный e-mail: " + ContactEmail);
        }
    }
    class Journal
    {
        private string journalName;
        private int foundationYear;
        private string description;
        private string contactPhone;
        private string contactEmail;
        private int employeeCount;

        public int EmployeeCount
        {
            get { return employeeCount; }
            set { employeeCount = value; }
        }
        public string JournalName
        {
            get { return journalName; }
            set { journalName = value; }
        }
        public int FoundationYear
        {
            get { return foundationYear; }
            set { foundationYear = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }
        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }
        public Journal(string name, int year, string desc, string phone, string email, int employees)
        {
            JournalName = name;
            FoundationYear = year;
            Description = desc;
            ContactPhone = phone;
            ContactEmail = email;
            EmployeeCount = employees;
        }
        public void DisplayJournalInfo()
        {
            Console.WriteLine("Название журнала: " + JournalName);
            Console.WriteLine("Год основания: " + FoundationYear);
            Console.WriteLine("Описание журнала: " + Description);
            Console.WriteLine("Контактный телефон: " + ContactPhone);
            Console.WriteLine("Контактный e-mail: " + ContactEmail);
        }
        public static Journal operator +(Journal journal, int value)
        {
            journal.EmployeeCount += value;
            return journal;
        }
        public static Journal operator -(Journal journal, int value)
        {
            journal.EmployeeCount -= value;
            if (journal.EmployeeCount < 0)
                journal.EmployeeCount = 0;
            return journal;
        }
        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount == journal2.EmployeeCount;
        }
        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount != journal2.EmployeeCount;
        }
        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount < journal2.EmployeeCount;
        }
        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount > journal2.EmployeeCount;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())//проверка что типы не отличаются
                return false;

            Journal other = (Journal)obj;
            return this.EmployeeCount == other.EmployeeCount;//можно проверить все поля в целом
        }
        public override int GetHashCode()
        {
            return EmployeeCount.GetHashCode();
        }
    }
    class ReadingList
    {
        private List<string> books = new List<string>();

        public void AddBook(string bookTitle)
        {
            books.Add(bookTitle);
        }
        public void RemoveBook(string bookTitle)
        {
            books.Remove(bookTitle);
        }
        public bool ContainsBook(string bookTitle)
        {
            return books.Contains(bookTitle);
        }
        public static ReadingList operator +(ReadingList readingList, string bookTitle)
        {
            readingList.AddBook(bookTitle);
            return readingList;
        }
        public static ReadingList operator -(ReadingList readingList, string bookTitle)
        {
            readingList.RemoveBook(bookTitle);
            return readingList;
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                    return books[index];
                else
                    return null;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
