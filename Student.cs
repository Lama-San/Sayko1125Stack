Код для решения данной задачи:

using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Mark { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<Student> studentsStack = new Stack<Student>();
        Stack<Student> gradedStudentsStack = new Stack<Student>();

        // Создание 5 студентов
        Student student1 = new Student { FirstName = "Иван", LastName = "Иванов" };
        Student student2 = new Student { FirstName = "Петр", LastName = "Петров" };
        Student student3 = new Student { FirstName = "Алексей", LastName = "Сидоров" };
        Student student4 = new Student { FirstName = "Елена", LastName = "Петрова" };
        Student student5 = new Student { FirstName = "Ольга", LastName = "Смирнова" };

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


В данной программе мы создаем два стека: `studentsStack` для хранения всех студентов и `gradedStudentsStack` для хранения студентов с оценками.
Затем мы создаем 5 студентов и добавляем их в первый стек.
В цикле извлекаем студента из первого стека, запрашиваем с консоли его оценку и добавляем студента с оценкой во второй стек.
