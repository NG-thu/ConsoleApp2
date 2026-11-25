using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp2;

namespace QuanLyHocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var students = new List<Student>()
            {
                new Student { Id = 1, Name = "Trúc", Age = 16 },
                new Student { Id = 2, Name = "Thư", Age = 20 },
                new Student { Id = 3, Name = "Thảo", Age = 18 },
                new Student { Id = 4, Name = "Tuyết", Age = 19 },
                new Student { Id = 5, Name = "An", Age = 15 }
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("a. Toàn bộ danh sách học sinh:");
            students.ForEach(s => Console.WriteLine(s));

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\nb. Học sinh có tuổi từ 15 đến 18:");
            var age = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in age) Console.WriteLine(s);

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nc. Học sinh có tên bắt đầu bằng chữ 'A':");
            var HsA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var s in HsA) Console.WriteLine(s);

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            int sumHs = students.Sum(s => s.Age);
            Console.WriteLine($"\nd. Tổng tuổi của tất cả học sinh: {sumHs}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            Console.WriteLine("\ne. Học sinh có tuổi lớn nhất:");
            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge);
            foreach (var s in oldestStudents) Console.WriteLine(s);

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra
            Console.WriteLine("\nf. Danh sách học sinh sắp xếp theo tuổi tăng dần:");
            var sapxeptang = students.OrderBy(s => s.Age);
            foreach (var s in sapxeptang) Console.WriteLine(s);
        }
    }
}