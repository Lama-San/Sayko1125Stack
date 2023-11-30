using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Mark { get; set; }
}

class Programm
{
    static void Main(string[] args)
    {
        Stack<Student> studentsStack = new Stack<Student>();
        Stack<Student> gradedStudentsStack = new Stack<Student>();

        // Создание 5 студентов
        Console.WriteLine("Ведите Имя и Фамилию первого студента...");
        Student student1 = new Student { FirstName = Console.ReadLine(), LastName = Console.ReadLine()};
        Console.WriteLine("Ведите Имя и Фамилию второго студента...");
        Student student2 = new Student { FirstName = Console.ReadLine(), LastName = Console.ReadLine() };
        Console.WriteLine("Ведите Имя и Фамилию третьего студента...");
        Student student3 = new Student { FirstName = Console.ReadLine(), LastName = Console.ReadLine() };
        Console.WriteLine("Ведите Имя и Фамилию четвертого студента...");
        Student student4 = new Student { FirstName = Console.ReadLine(), LastName = Console.ReadLine() };
        Console.WriteLine("Ведите Имя и Фамилию пятого студента...");
        Student student5 = new Student { FirstName = Console.ReadLine(), LastName = Console.ReadLine() };

        // Добавление студентов в первый стек
        studentsStack.Push(student1);
        studentsStack.Push(student2);
        studentsStack.Push(student3);
        studentsStack.Push(student4);
        studentsStack.Push(student5);

        // Цикл для запроса оценок
        while (studentsStack.Count > 0)
        {
            // Извлечение студента из первого стека
            Student student = studentsStack.Pop();

            Console.WriteLine($"Введите оценку для студента {student.LastName}:");
            int mark = int.Parse(Console.ReadLine());

            // Добавление студента с оценкой во второй стек
            student.Mark = mark;
            gradedStudentsStack.Push(student);
        }
    }
}

