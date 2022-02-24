using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Daily_Tasks_8
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public byte Age;

        public Student(string fullname, string groupno, byte age)
        {
            GroupNo = groupno;
            Fullname = fullname;
            Age = age;
        }

        #region Loop ile Fullname
        public static bool CheckFullname(string fullname)
        {
            bool notAllLower1 = false;
            bool notAllLower2 = false;
            
            string[] splitFullname = fullname.Split(" ");
            if (splitFullname.Length == 2) //2 cunki(name and surname)
            {
                if (char.IsUpper(splitFullname[0][0]) && char.IsUpper(splitFullname[1][0]))
                {
                    for (int i = 1; i < splitFullname[0].Length; i++)
                    {
                        if (!char.IsLower(splitFullname[0][i]))
                        {           
                            notAllLower1 = true;         
                        }      
                    }
                    for (int i = 1; i < splitFullname[1].Length; i++)
                    {
                        if (!char.IsLower(splitFullname[1][i]))
                        {
                            notAllLower2 = true;
                        }
                    }
                    if (!notAllLower1 && !notAllLower2)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("After an Uppercase(in name and surname) all characters should be lowercase"); 
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Name and Surname has to start with an Uppercase ");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Fullname must include 3 parts: Name + Space + Surname. Example(Fakhri Afandiyev)");
                return false;
            }       
        }
        #endregion

        #region Regex ile Fullname
        //public static bool CheckFullname(string fullname)
        //{
        //    if (Regex.IsMatch(fullname, "^[A-Z]{1}[a-z]+( )+[A-Z]{1}[a-z]+$"))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fullname must include 3 parts: Name + Space + Surname. Example(Fakhri Afandiyev)");
        //        return false;
        //    }            
        //}
        #endregion

        #region Loop ile GroupNo
        public static bool CheckGroupNo(string groupno)
        {
            bool NotDigit = false;
            if (groupno.Length == 4 && char.IsUpper(groupno[0]))
            {
                for (int i = 1; i < groupno.Length; i++)
                {
                    if (!char.IsDigit(groupno[i]))
                    {
                        NotDigit = true;                       
                    }
                }
                if (!NotDigit)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("After the first uppercase all 3 characters must be a digit");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("GroupNo needs to be 4 characters long. First character must be an uppercase letter and last 3 characters should be all digits");
                return false;
            }
        }
        #endregion

        #region Sade yolla GroupNo

        //public static bool CheckGroupNo(string groupno)
        //{
        //    if (groupno.Length <= 4 && char.IsUpper(groupno[0]) && char.IsDigit(groupno[1]) && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("GroupNo needs to be 4 character long. First character must be an uppercase letter and last 3 characters should be all digits");
        //        return false;
        //    }
        //}
        #endregion

        #region Regex ile GroupNo
        //public static bool CheckGroupNo(string groupno)
        //{
        //    if (Regex.IsMatch(groupno, "^[A-Z]{1}[0-9]{3}$"))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("GroupNo needs to be 4 character long. First character must be an uppercase letter and last 3 characters should be all digits");
        //        return false;
        //    }
        //}
        #endregion

    }
}
