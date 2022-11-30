using System;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;

/*using driveCheckerDLL;*/
/*using static driveCheckerDLL.DriverChecker;*/

class Test
{
    public static void Main()
    {
        //Указывай полный путь к файлу, хз как по другому работает
        var dll = Assembly.LoadFile(@"E:\randomwindow_cs\ConsoleApplication2\ConsoleApplication2\driveCheckerDLL.dll");
        //Достаем из нашей дллки класс
        var type = dll.GetType("driveCheckerDLL.DriverChecker");
        //Достаем методы из класса
        var method = type.GetMethod("DriversInfo");
        //Просто надо
        var instance = Activator.CreateInstance(type);
        //У меня метод без параметров, по этому передаю инстанс и null в качестве параметров
        var result = method.Invoke(instance, null);
        //Выводим результат
        Console.WriteLine(result);
    }
}