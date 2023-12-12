using LearningCsharp.Models;

namespace LearningCsharp.LINQs
{
    internal static class DataList
    {
        public static List<Student> studentList = new List<Student>
        {
            new Student { ID = 1, Name = "John", Gender = "Male", Phone = "123-456-7890", City = "New York" },
            new Student { ID = 2, Name = "Jane", Gender = "Female", Phone = "987-654-3210", City = "Los Angeles" },
            new Student { ID = 3, Name = "Bob", Gender = "Male", Phone = "555-555-5555", City = "Chicago" },
            new Student { ID = 4, Name = "Alice", Gender = "Female", Phone = "111-222-3333", City = "Houston" },
            new Student { ID = 5, Name = "Mike", Gender = "Male", Phone = "444-777-8888", City = "Phoenix" },
            new Student { ID = 6, Name = "Emily", Gender = "Female", Phone = "666-999-0000", City = "Philadelphia" },
            new Student { ID = 7, Name = "Tom", Gender = "Male", Phone = "777-888-9999", City = "San Antonio" },
            new Student { ID = 8, Name = "Sara", Gender = "Female", Phone = "333-111-4444", City = "San Diego" },
            new Student { ID = 9, Name = "Chris", Gender = "Male", Phone = "222-555-6666", City = "Dallas" },
            new Student { ID = 10, Name = "Linda", Gender = "Female", Phone = "999-000-1111", City = "San Jose" },
            new Student { ID = 11, Name = "Alex", Gender = "Male", Phone = "777-333-5555", City = "Austin" },
            new Student { ID = 12, Name = "Megan", Gender = "Female", Phone = "888-444-6666", City = "Jacksonville" },
            new Student { ID = 13, Name = "David", Gender = "Male", Phone = "555-777-8888", City = "Indianapolis" },
            new Student { ID = 14, Name = "Sophia", Gender = "Female", Phone = "111-333-5555", City = "Columbus" },
            new Student { ID = 15, Name = "Ryan", Gender = "Male", Phone = "999-111-3333", City = "Charlotte" },
        };
        public static List<Customer> customers = new List<Customer>
        {
            new Customer { ID="A", City="New York", Country="USA", Region="North America", Sales=9999 },
            new Customer { ID="B", City="Mumbai", Country="India", Region="Asia", Sales=8888 },
            new Customer { ID="C", City="Karachi", Country="Pakistan", Region="Asia", Sales=7777 },
            new Customer { ID="D", City="Delhi", Country="India", Region="Asia", Sales=6666 },
            new Customer { ID="E", City="São Paulo", Country="Brazil", Region="South America", Sales=5555 },
            new Customer { ID="F", City="Moscow", Country="Russia", Region="Europe", Sales=4444 },
            new Customer { ID="G", City="Seoul", Country="Korea", Region="Asia", Sales=3333 },
            new Customer { ID="H", City="Istanbul", Country="Turkey", Region="Asia", Sales=2222 },
            new Customer { ID="I", City="Shanghai", Country="China", Region="Asia", Sales=1111 },
            new Customer { ID="J", City="Lagos", Country="Nigeria", Region="Africa", Sales=1000 },
            new Customer { ID="K", City="Mexico City", Country="Mexico", Region="North America", Sales=2000 },
            new Customer { ID="L", City="Jakarta", Country="Indonesia", Region="Asia", Sales=3000 },
            new Customer { ID="M", City="Tokyo", Country="Japan", Region="Asia", Sales=4000 },
            new Customer { ID="N", City="Los Angeles", Country="USA", Region="North America", Sales=5000 },
            new Customer { ID="O", City="Cairo", Country="Egypt", Region="Africa", Sales=6000 },
            new Customer { ID="P", City="Tehran", Country="Iran", Region="Asia", Sales=7000 },
            new Customer { ID="Q", City="London", Country="UK", Region="Europe", Sales=8000 },
            new Customer { ID="R", City="Beijing", Country="China", Region="Asia", Sales=9000 },
            new Customer { ID="S", City="Bogotá", Country="Colombia", Region="South America", Sales=1001 },
            new Customer { ID="T", City="Lima", Country="Peru", Region="South America", Sales=2002 },
            new Customer { ID="U", City="Islamabad", Country="Pakistan", Region="Asia", Sales=3003 },
            new Customer { ID="V", City="Lahore", Country="Pakistan", Region="Asia", Sales=4004 },
            new Customer { ID="W", City="Karachi", Country="Pakistan", Region="Asia", Sales=5005 },
            new Customer { ID="X", City="Rawalpindi", Country="Pakistan", Region="Asia", Sales=6006 },
            new Customer { ID="Y", City="Faisalabad", Country="Pakistan", Region="Asia", Sales=7007 }
        };

    }
}
