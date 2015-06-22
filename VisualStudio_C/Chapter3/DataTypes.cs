﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Chapter3 {
    class DataTypes {
        static void MainDataTypes(string[] args) {
            //highest int  = 2147482648;
            //smaller int = -2147482648;
           int myNewInt = new int();
            // create a variable to hold a .NET value type
            // this type is the .NET version of the alias form int
            // note the use of the keyword new, we are creating an object from
            // the System.Int32 class
            System.Int32 myInt32 = new System.Int32();
            // print out the default value assigned to an int variable
            // that had no value assigned previously
            Console.WriteLine(String.Format("Defaul value of int() = {0}",myNewInt));
            // this statement will work fine and will print out the default value for
            // this type, which in this case is 0
            Console.WriteLine(String.Format("Defaul value of new System.Int32() = {0}", myInt32));
            // declare some numeric data types

            int myInt;
            double myDouble;
            byte myByte;
            char myChar;
            decimal myDecimal;
            float myFloat;
            long myLong;
            short myShort;
            bool myBool;
            // assign values to these types and then
            // print them out to the console window
            // also use the sizeOf operator to determine
            // the number of bytes taken up be each type

            myInt = 5000;
            Console.WriteLine("Integer");
            Console.WriteLine(myInt);
            Console.WriteLine(myInt.GetType());
            Console.WriteLine(sizeof(int));
            Console.WriteLine();
            
            myDouble = 5000.0;
            Console.WriteLine("Double");
            Console.WriteLine(myDouble);
            Console.WriteLine(myDouble.GetType());
            Console.WriteLine(sizeof(double));
            Console.WriteLine();
            
            myByte = 254;
            Console.WriteLine("Byte");
            Console.WriteLine(myByte);
            Console.WriteLine(myByte.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
            
            myChar = 'r';
            Console.WriteLine("Char");
            Console.WriteLine(myChar);
            Console.WriteLine(myChar.GetType());
            Console.WriteLine(sizeof(char));
            Console.WriteLine();
            
            myDecimal = 20987.89756M;
            Console.WriteLine("Decimal");
            Console.WriteLine(myDecimal);
            Console.WriteLine(myDecimal.GetType());
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine();
            
            myFloat = 254.09F;
            Console.WriteLine("Float");
            Console.WriteLine(myFloat);
            Console.WriteLine(myFloat.GetType());
            Console.WriteLine(sizeof(float));
            Console.WriteLine();
            
            myLong = 2544567538754;
            Console.WriteLine("Long");
            Console.WriteLine(myLong);
            Console.WriteLine(myLong.GetType());
            Console.WriteLine(sizeof(long));
            Console.WriteLine();
            
            myShort = 3276;
            Console.WriteLine("Short");
            Console.WriteLine(myShort);
            Console.WriteLine(myShort.GetType());
            Console.WriteLine(sizeof(short));
            Console.WriteLine();
            
            myBool = true;
            Console.WriteLine("Boolean");
            Console.WriteLine(myBool);
            Console.WriteLine(myBool.GetType());
            Console.WriteLine(sizeof(bool));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
