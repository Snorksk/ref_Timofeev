using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type exType = typeof(MissingMemberException);
        Console.WriteLine("Класс: {0}\n", exType.FullName);

        // выводим информацию о методах
        Console.WriteLine("Методы:");
        foreach (MethodInfo method in exType.GetMethods())
        {
            Console.WriteLine("  Методы название: {0}\n    IsAbstract: {1}\n    IsFamily: {2}\n    IsFamilyAndAssembly: {3}\n    IsFamilyOrAssembly: {4}\n    IsAssembly: {5}\n    IsPrivate: {6}\n    IsPublic: {7}\n    IsConstructor: {8}\n    IsStatic: {9}\n    IsVirtual: {10}\n    ReturnType: {11}\n",
                method.Name, method.IsAbstract, method.IsFamily, method.IsFamilyAndAssembly, method.IsFamilyOrAssembly, method.IsAssembly, method.IsPrivate, method.IsPublic, method.IsConstructor, method.IsStatic, method.IsVirtual, method.ReturnType);
        }

        // выводим информацию о конструкторах
        Console.WriteLine("Конструкторы:");
        foreach (ConstructorInfo constructor in exType.GetConstructors())
        {
            Console.WriteLine("  Конструкторы название: {0}\n    IsFamily: {1}\n    IsFamilyAndAssembly: {2}\n    IsFamilyOrAssembly: {3}\n    IsAssembly: {4}\n    IsPrivate: {5}\n    IsPublic: {6}\n",
                constructor.Name, constructor.IsFamily, constructor.IsFamilyAndAssembly, constructor.IsFamilyOrAssembly, constructor.IsAssembly, constructor.IsPrivate, constructor.IsPublic);
        }

        // выводим информацию о полях
        Console.WriteLine("Поля:");
        foreach (FieldInfo field in exType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
        {
            Console.WriteLine("  Поля название: {0}\n    IsFamily: {1}\n    IsFamilyAndAssembly: {2}\n    IsFamilyOrAssembly: {3}\n    IsAssembly: {4}\n    IsPrivate: {5}\n    IsPublic: {6}\n    IsStatic: {7}\n",
                field.Name, field.IsFamily, field.IsFamilyAndAssembly, field.IsFamilyOrAssembly, field.IsAssembly, field.IsPrivate, field.IsPublic, field.IsStatic);
        }

        // выводим информацию о свойствах
        Console.WriteLine("Свойства:");
        foreach (PropertyInfo prop in exType.GetProperties())
        {
            Console.WriteLine("  Свойства название: {0}\n    Attributes: {1}\n    CanRead: {2}\n    CanWrite: {3}\n    GetMethod: {4}\n    SetMethod: {5}\n    PropertyType: {6}\n",
                prop.Name, prop.Attributes, prop.CanRead, prop.CanWrite, prop.GetMethod, prop.SetMethod, prop.PropertyType);
        }
    }
}
