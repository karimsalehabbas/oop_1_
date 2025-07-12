using System;

namespace ConsoleApp16
{
    #region Enums , Classes of Qustions
    #region Enum Q1
    enum WeekDays
    {
        //Monday,
        //Tuesday, 
        //Wednesday,
        //Thursday,
        //Friday,
        //Saturday,
        //Sunday
    }
    #endregion

    #region Enum Q2
    enum Season
    {
        //Spring,
        //Summer,
        //Autumn,
        //Winter
    }
    #endregion

    #region Enum , Class Q3
    #region Enum Q3
    //[Flags]
    //enum Permissions : byte
    //{
    //    Delete = 1,
    //    Execute = 2,
    //    Read = 4,
    //    Write = 8,
    //}
    #endregion
    #region Class Q3
    //class User
    //{
    //    public int Id { get; set; }
    //
    //    public Permissions Permissions { get; set; }
    #endregion
    #endregion

    #region Enum Q4
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Days Of Week : ");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter Your Season (Spring , Summer , Autumn , Winter) : ");
            //String Input = Console.ReadLine();
            //if (Enum.TryParse(typeof(Season), Input , true  , out object result))
            //{
            //    Season season = (Season)result;
            //
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring : March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer : June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autmn : September to Novamber");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter : December to February");
            //            break;
            //
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered. Please enter Spring, Summer, Autumn, or Winter.");
            //}
            #endregion

            #region Q3
            //User user01 = new User();
            //user01.Id = 1;
            //user01.Permissions = (Permissions)4;
            //Console.WriteLine(user01.Permissions); // print Read
            //// Add Permission to this variable
            //user01.Permissions |= Permissions.Delete;  
            //Console.WriteLine(user01.Permissions); // Add Delete Permission
            //// Remove Permission from This Variable 
            //user01.Permissions ^= Permissions.Read;
            //Console.WriteLine(user01.Permissions); // Remove Read Permission
            //// check if specific Permission existed inside variable
            //if ((user01.Permissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("This Permission Is Exist Into This Variable");
            //}
            //else
            //{
            //    Console.WriteLine("This Permission Is not Exist Into This Variable");
            //}

            #endregion

            #region Q4
            //Console.WriteLine("Enter The Color Name : ");
            //string Input = Console.ReadLine();
            //
            //if (Enum.TryParse(typeof(Colors) , Input , true , out object result))
            //{
            //    Colors color = (Colors)result;
            //
            //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{color} is a primary color");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{Input} is not a primary color");
            //}
            #endregion

        }
    }
}


