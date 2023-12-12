using LearningCsharp.Models;

namespace LearningCsharp.LINQs
{
    internal class Queries
    {
        public static void WhereFilter(List<Student> students)
        {
            var result = students
                .Where(x => x.Gender.Equals("Male"))
                .Select(x => new
                {
                    x.Gender,
                    x.Name
                })
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Gender: {item.Gender}, Name: {item.Name}");
            }


            // PrintToScreen(result);
        }
        public static void GroupByFilter(List<Customer> customers)
        {
            var queryResults = customers
            .GroupBy(c => c.Region)
            .Select(cg => new
            {
                TotalSales = cg.Sum(c => c.Sales),
                Region = cg.Key
            });

        }
        private static void PrintToScreen(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID : {student.ID} Name : {student.Name} Gender : {student.Gender} Phone : {student.Phone}");
            }
        }
    }
}
