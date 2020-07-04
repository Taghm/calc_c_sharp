using System;

namespace inter_es_02
{
    class Program
    //a simple calculator
    {
      static void Main(string [] args){
        //Console.WriteLine("Hello World!");
  //run our methods and Command line requests
  Console.WriteLine("||-------------CALCULATOR SIMPLEX-------------||");
  Console.WriteLine("||                                            ||");
  Console.WriteLine("||____________________________________________||");
Console.WriteLine("Press any key and ENTER to start the program.");
string key = Console.ReadLine();
Console.WriteLine("Key entered : {0}", key);
//if any key is pressed, launch program

while(key != " "){

   DateTime now = DateTime.Now;
  //call the function PrintToConsole()
  PrintToConsole();
  //repeat
  Console.WriteLine("Quit(Q) or Continue(C)");
  string question = Console.ReadLine();
  if(question == "Q" ||  question == "q"){
    Console.WriteLine("Program Terminated at {0}.", now);
    break;
  }
  else if(question  == "C" || question == "c"){
    PrintToConsole();
    Console.WriteLine("Quit(Q) or Continue(C)");
    string question2 = Console.ReadLine();
    if(question2 == "Q" ||  question2 == "q"){
      Console.WriteLine("Program Terminated at {0}.", now);
      break;
    }
  }
  else{
    Console.WriteLine("Wrong input!");
    break;
  }
}
//if no key is pressed
if(key == " "){
  Console.WriteLine("no key entered. Machine idle!");
}

    }
static void PrintToConsole(){
Console.WriteLine("Enter first integer: ");
string int_s = Console.ReadLine();
double s = double.Parse(int_s);
Console.WriteLine("Enter second integer : ");
string int_l = Console.ReadLine();
double l = double.Parse(int_l);
          if((s != 0)  && (l != 0)){
      Console.WriteLine("first number: " + s  + " , second number : " + l);
      Console.WriteLine("What operations  do you  want the program to make?\nType x, - , + , /, sqrt, (or) pow");
        string operation = Console.ReadLine();
      if (operation == "-"){
        double subt = (s - l);
              Console.WriteLine("result: " + subt);
      }
      else if (operation == "+"){
        double adds_ = (s + l);
              Console.WriteLine("result: " + adds_);
      }
      else if (operation == "/"){
        double divds = ((double)s / (double)l);
              Console.WriteLine("result: " + divds);
      }
      else if (operation == "x"){
        double multp = ((double)s * (double)l);
              Console.WriteLine("result: " + multp);
            }
      else if (operation == "sqrt"){
        Console.WriteLine("sqrt of first or second number? Type: 1st (or) 2nd. or 1 and 2");
        string sqrt_number = Console.ReadLine();
        if((sqrt_number == "1st") || (sqrt_number == "1") && (s > 1)){
              double sqrt_ans = (double)((Math.Sqrt(s)));
                    Console.WriteLine("result: " + sqrt_ans);
                  }
                  else{
                    double multp = (double)((Math.Sqrt(l)));
                          Console.WriteLine("result: " + multp);
                  }
                  }
     else if (operation == "pow"){
                      double multp = (double)((Math.Pow(s, l)));
                       Console.WriteLine("result: " + multp);
                              }

            else{
              Console.WriteLine("Operation not Found.");
        }


    }
    else{
    Console.WriteLine("No values entered.");
    }

}
}
}
