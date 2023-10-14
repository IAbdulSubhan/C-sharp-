using System;

// Namespace consider as Container
class Program {
  static void funtion1(string fun){
    Console.WriteLine($"This is my function 1 calling in {fun} function");
  }

  static Double average(float a, float b, float c){
    Double d = a+b+c;
    return d/3;
  }
  static Double average(float a, float b){
    Double d = a+b;
    return d/2;
  }

  public static void Main (string[] args) {
    //=========================1===================
    /*// write line basic function used to write a line on a   console 
    Console.WriteLine ("Differnce between writeline and write\n\n This is write line content");
    Console.WriteLine ("Hello World C#1");
    Console.WriteLine ("Hello World C#2");
    Console.WriteLine ("Hello World C#3");
    // Console.ReadLine ();
    // Write only function do not make new line 
    Console.WriteLine ("\nBelow Content of Write");
    Console.Write ("Hello World C#1"); 
    Console.Write ("Hello World C#2");
    */
    //=========================end 1===================

    
  /*//=========================2===================
    // varibales
  string my_name = "Subhan";
    Console.WriteLine ("My name is: "+ my_name);

    // end varibales
  */
  //=========================2 end===================


    
    //=========================3===================
    /*DataTypes in C#
    -int
    -string
    -float
    -char
    -bool
    -long
    -double
    */
    // DataTypes Examples
    /*
    int myvar1 = 8;
    Console.WriteLine ("myvar1 interger value is: " +myvar1);
    int myvar2 = 9;
    Console.WriteLine ("myvar2 interger value is: " +myvar2);

    Console.WriteLine ("Sum of 2 integers : " + (myvar1 + myvar2));

    // for writing float variable initilizing that we need to write the "F" with the value it by defult used as double

    float myfloat= 4.5F;
    Console.WriteLine ("This is the  float value" + myfloat);

    // Double also work for the float but with more space put "D" make code clean
    
    Double myvalue3 = 44.5D;
    Console.WriteLine ("This is the  Double value" + myvalue3);*/

    // ==============End 3=================================

    
    
    // ====================4==========================
    //   Type Casting
    // int x = 3.5 Actually in c# it is not allowed to assign float/double value to an integer so the solution is typecast Let do that
    /*
    There are two types of type casting
    1: Implicit type casting

    char to int to long to float to double
    - Char can be changed with, int,long,float,double not vice versa
    - int can be changed with long,float,double not vice versa
    - long can be changed with float,double not vice versa
    - float can be changed with ,double not vice versa
    Example
    */
    /*
    int y = 3;
    Double Z = y;
    Console.WriteLine (Z);
    char yy = 'M';   //here when type casting char to int it will print its ascii value
    int zz = yy;
    Console.WriteLine (zz);
    */
    
    
    /*
    2: Explicit type casting
    Example
    */
    /*
    int x = (int) 3.5;
    double Myvar = (double) 4;
    Console.WriteLine ("This is a typed cast integer value: "+ Myvar);

    Console.WriteLine ("This is a typed cast integer value: "+ x);
    */

    // =========================end of 4=============================

    //=======================5===========================
    // Taking input from the user
    
    // Console.WriteLine("Enter Your Name: ");
    // string UserInput = Console.ReadLine();
    // Console.WriteLine("Hey Hello: " + UserInput); 
    
    // example 2 with different data types need of type casting
    
    // Console.WriteLine("Enter a number: ");
    // string UserInput2 =  Console.ReadLine();
    // Console.WriteLine("Hey Hello sum of 4 + input =  " + (Convert.ToInt64(UserInput2) + 4));

    // ======================end of 5=====================

    // ==========================6========================
    // Arhemtic Operators
    /*
    1. Arithmetic operators
    2. Assignment Operators
    3. Logical Operators
    4. Comparison Operators
    */
    // int a = 4;
    // int b = 2;
    // Console.WriteLine("The value of a + b is: " + (a + b));
    // Console.WriteLine("The value of a - b is:" + (a - b));
    // Console.WriteLine("The value of a * b is:" + (a * b));
    // Console.WriteLine ("The value of a / b is:" + (a / b));

    // Assignment Operators

    // int a = 3;
    // int b = a;
    // Console.WriteLine(b);

    // Arithmetic operators
  
    // int a = 4;
    // int b = a;
    // //b += 4;
    // //b -= 4;
    // // b *= 4;
    // b /= 4;
    // Console.WriteLine (b);

    // Logical Operators

    // Console.WriteLine (true && false);
    // Console.WriteLine (true && true);
    // Console.WriteLine (false && false);
    // Console.WriteLine (false && true);

    // Console.WriteLine (true || false);
    // Console.WriteLine (true || true);
    // Console.WriteLine (false || false);
    // Console.WriteLine (false || true);

    // Console.WriteLine (!true);
    
    // Comparison operators
    // Console.WriteLine (325 > 5);
    // Console.WriteLine (325 >= 555);
// ===================================================================
    // Use of Math Class
    
    
    // int vaar1 = Math.Max (45,46);
    // int vaar2 = Math.Min (45,46);
    // double vaar3 = Math.Sqrt (46);    //it does not support int value it use double
    // int vaar4 = Math.Abs(-39);

    // Console.WriteLine(vaar4);

    // =====================================================================

    // Working with strings
    
//     String stringvar1 = "Hello this is Abdul Subhan ,";

//     Console.WriteLine (stringvar1.Length);
//     Console.WriteLine (stringvar1.ToLower());
//     Console.WriteLine (stringvar1.ToUpper());

//     // concatenation of string with 2 different methods

//     String stringvar2 = "and I am fastian";
// // methode with simple + operator
//     Console.WriteLine (stringvar1+stringvar2);
// // methode with concate funtion
//     Console.WriteLine (string.Concat(stringvar1, stringvar2));  

//     // string interpolation

//     String name = Console.ReadLine();
//     string score = Console.ReadLine();

//     Console.WriteLine ($"My name is {name} and i have got {score} score");


    // // Working with string Array
    // String stringvar11 = "Hello this is Abdul Subhan ,";
    // // print first cracter of array in c# indexing start with 0

    // Console.WriteLine (stringvar11[0]);
    // // i print the last index value using length of string
    // Console.WriteLine (stringvar11[stringvar11.Length-1]);

    // // Substring take a value as parameter and it start from that index and goes till end

    // Console.WriteLine (stringvar11.Substring(5));

    // // escape sequence character

    // // if we want to add special characterin the string specially "" sign it will not allow it will consider that string is ended here but finishing is on other end so we will use \

    // String stringvar12 = "Hello \"this is Abdul Subhan ,\"";

    // Console.WriteLine (stringvar12);
    

// ==================================================================
    // Conditional/decision Statement 
    
    // int age = 20;
    // if (age < 2)
    // {
    // Console.WriteLine("You are just born");
    // }
    // else if (age < 18)
    // {
    // Console.WriteLine ("Please finish your high school");
    // }
    // else if(age>=18 || age<60)
    // {
    //   Console.WriteLine ("You can drive");
    
    // }
    // else
    // {
    //   Console.WriteLine ("You cannot drive");
    // }

// =============================================================

    // switch case

    int Age = 20  ;

    switch (Age)
    {
      case 10:
        Console.WriteLine ("You are not allowed");
        break;

    case 18:
      Console.WriteLine ("you will drive soon");
      break;
      
    case 22:
      Console.WriteLine ("you can drive");
      break;

    default:
      Console.WriteLine("you need to check your age");
      break;
    }


    // ===================================================

    // Loops
    /*
    -while
    -for
    
    */
// ===============
    while Loop

    int i=0;
    while(i<5)
    {
      Console.WriteLine($"While Loop iteration no is {i}");
      i++;
    }

    // Do while
    int i=0;
    do
    {
      Console.WriteLine(i);
      i++;

    }while(i<5);
// ============================
    // For Loop

    // for(int i=0; i<5 ; i++)
    // {
    //   Console.WriteLine($"For Loop iteration no is {i}");
    // }

// =================

    // use of break and continue
    // for(int i=0; i<5 ; i++)
    // {
    //   if (i==0){
    //     continue;
    //   }
    //   else if(i==4){
    //     break;
    //     }
    //   else{
    //     Console.WriteLine($"For Loop iteration no is {i}");
    //   }
    // }

    // ==================================================================

    // Methodes/Funtions
    funtion1("Main");
    // Average calculate function
    // Console.WriteLine("Average =  "+average(1,3,3));
    
    
    //Methode overloading(overloading funtion with differnet parameters but in same class)
    Console.WriteLine("Average with 3 parameters =  "+average(1,3,3));
    Console.WriteLine("Average with 2 parameters =  "+average(1,3));

    
  }
  
}


/*
float: It is a 32-bit floating-point type, which means it can represent numbers with a precision of about 7 decimal digits. It occupies 4 bytes of memory.
double: It is a 64-bit floating-point type, offering higher precision than float with approximately 15 decimal digits. It occupies 8 bytes of memory.*/