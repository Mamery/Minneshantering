using System;
using System.Collections.Generic;
using System.Text;

namespace Minneshantering
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Fibonaccisekvensen"
                    + "\n6. IterativeEven"
                    + "\n7. Fibonacciberäknaren"
                    + "\n8. IterativeOdd" 
                    + "\n9. IterativeEvenFibo"
                    + "\n0. Exit the application");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        Console.WriteLine(" Enter your input");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("The value is: " + Fibonaccisekvensen(n));
                        break;
                    case '6':
                        Console.Write("Input the range to print starting from 1 : ");
                        int m = int.Parse(Console.ReadLine());

                        Console.Write("Input the starting value: ");
                        int s = Convert.ToInt32(Console.ReadLine());

                        Console.Write("All even numbers from " + s + " to " + m + " are: ");
                        IterativeEven(s, m);
                        break;
                    case '7':
                        int r = Convert.ToInt32(Console.ReadLine());
                        Fibonacciberäknaren(r);
                        break;
                    case '8':
                        Console.WriteLine("Write your input value");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The value is: " + IterativeOdd(i)); ;
                        break;
                    case '9':
                        Console.WriteLine("Write your input value");
                        int fi = Convert.ToInt32(Console.ReadLine());
                        IterativeEvenFibo(fi); ;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4,5,6,7)");
                        break;
                }
            }
        }


        /// <summary>
        /// Examines the datastructure List
        /// 2. 
        /// 
        /// </summary>
        static bool ExamineList()

        {
            Console.WriteLine("Add to the list with + as firstchracter for example +Adam \nRemove from the list for example -Adam \n0 to exit");
            /*
           * Loop this method untill the user inputs something to exit to main menue.
           * Create a switch statement with cases '+' and '-'
           * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
           * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
           * In both cases, look at the count and capacity of the list
           * As a default case, tell them to use only + or -
           * Below you can see some inspirational code to begin working.
          */

            List<string> mylist = new List<string>();

            do
            {

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        mylist.Add(value);
                        int currentCapacity = mylist.Capacity;
                        Console.WriteLine("The current capacity is " + currentCapacity);
                        Console.WriteLine("Number of elements in the array is:" + mylist.Count);
                        Console.WriteLine("The current capacity after populating the array is " + currentCapacity);

                        /**
                         * 2. , 3.
                   Storleken ökar med ett nytt element varje gång ett element läggs till. 
                   Kapaciteten förblir dock oförändrad tills List är full. 
                   När ett element läggs till i en fullständig lista kommer 
                   Java-runtime-systemet att öka listans kapacitet som i våra lista. 
                   Med en ekstra element, kapacity fördoubbled to 8. 
                   kapacitet ökar så att många fler element kan läggas till.
                  
                         *
                         */
                        /*
                     4. Kapaciteten är alltid större än eller 
                     lika med Count. 
                     Om längden (Count) överskrider kapacitet när element läggs 
                     till ökar kapaciteten. De gamla elementen kopieras över 
                     det nya arrayet och de nya elementen läggs till.
                         * 
                         */


                        /*
                         * 5. Du kan inte minska kapaciteten av listan 
                         * men du kan använda TrimExcess() method
                         * till att göra det i mindre grad.
                     
                         */

                        /*
                         * 
                         * 6.
                         * 
                         * Använd en lista när du vill lägga till / 
                         * ta bort data, eftersom storleks ändring 
                         * av array är dyrt. 
                         * Om du vet att längden på array är fast så 
                         * kan en array vara användbar.
                         */


                        foreach (string s in mylist)
                        {
                            Console.WriteLine(s);
                        }

                        break;

                    case '-':

                        mylist.Remove(value);
                        Console.WriteLine("Number of elements in the array is:" + mylist.Count);
                        Console.WriteLine("The current capacity is " + mylist.Capacity);
                        mylist.TrimExcess();
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please use only + or -");
                        break;
                }

            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {

            Console.WriteLine("Enter a for the enque operartion \nEnter b for the dequeue operation");
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
                        Queue<string> persons = new Queue<string>();
            do

            {

                string que = Console.ReadLine();
                char ch = que[0];
                switch (ch)
                {
                    case 'a':

                        Console.WriteLine("Press a anytime you want to enter person name to the queue");
                        string p = Console.ReadLine();
                        persons.Enqueue(p);
                        Console.WriteLine("Length of the queue " + persons.Count);
                        break;
                    case 'b':
                        Console.WriteLine("Press b anytime you want to take a person name from the queue");
                        Console.WriteLine(persons.Dequeue());
                        Console.WriteLine("Length of the queue " + persons.Count);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                }


            } while (true);

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * FIFO
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> persons = new Stack<string>();

            Console.WriteLine("Create a switch with cases to push or pop items"
                    + "\n1. Press a for push operation "
                    + "\n2. Press b for pop operation"
                    + "\n3. Press c for att implementera en reverse-text "
                    + "\n3. Press 0 to exit ");

            do
            {

                string que = Console.ReadLine();
                char ch = que[0];
                switch (ch)
                {
                    case 'a':

                        Console.WriteLine("Enter a person name");
                        string p = Console.ReadLine();
                        persons.Push(p);
                        Console.WriteLine("Number of persons on the stack " + persons.Count);
                        break;

                    case 'b':
                        //Console.WriteLine("Enter a person name");
                        Console.WriteLine("Person removed from the stack " + persons.Pop());
                        Console.WriteLine(persons.Count);
                        break;

                    case 'c':
                        Reverse();
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;
                }


            } while (true);

        }

        private static void Reverse()
        {
            Console.WriteLine("Angive sentences");
            Stack<string> words = new Stack<string>();
            string s = Console.ReadLine();
            string[] arr = s.Split(" ");
            StringBuilder sb = new StringBuilder("");
            StringBuilder temp = null;
            //Loop through the entire string
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    //Check if there is room for inserting a data
                    words.Push(arr[i]);
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = words.Pop();

            }

            foreach (var w in arr)
            {
                temp = sb.Append(w + " ");
            }

            Console.WriteLine(temp);

        }

        static bool CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            {
                Stack<char> stack = new Stack<char>();
                Console.WriteLine("String with parentheses");
                bool isKorreckExpression = false;

                string p = Console.ReadLine();
                for (int i = 0; i < p.Length; i++)
                {
                    char character = p[i];
                    if (character == '[' || character == '{' || character == '(')
                    {
                        stack.Push(character);
                    }

                    else if (character == ']' || character == '}' || character == ')')
                    {
                        if (stack.Count == 0) // if stack is empty and you have a closing character this means that it is unbalanced 
                            return isKorreckExpression;
                        switch (character)
                        {
                            case ']':
                                if (stack.Pop() != '[')
                                {
                                    //the stack pop should be equal to [ then it can match case ]
                                    Console.WriteLine("Incorrect Expression");
                                    return isKorreckExpression;
                                }
                                break;
                            case '}':
                                if (stack.Pop() != '{')
                                {
                                    Console.WriteLine("Incorrect Expression");
                                    return isKorreckExpression;
                                }

                                break;
                            case ')':
                                if (stack.Pop() != '(')
                                {
                                    Console.WriteLine("Incorrect expression");
                                    return isKorreckExpression;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Neither curley braces nor curley brackets or \n parenthesis are present");
                    }
                }
                //What happens when we have been through our sentences to find our parenthesis
                if (stack.Count == 0)
                {
                    Console.WriteLine("correct expression");
                    return !isKorreckExpression;
                }

                return isKorreckExpression;
            }

        }

        private static int Fibonacciberäknaren(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        private static void IterativeEven(int stVal, int n)
        {

            if (stVal > n)
                return;
            Console.Write(" {0}  ", stVal);
            IterativeEven(stVal + 2, n);
            Console.WriteLine(" ");


        }

        private static int Fibonaccisekvensen(int n)
        {
            if (n == 0) return 0;

            if (n == 1) return 1;

            return Fibonaccisekvensen(n - 1) + Fibonaccisekvensen(n - 2);

        }


        private static int IterativeOdd(int n)
        {
            if (n == 0) return 1;
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }

            return result;
        }


        private static void IterativeEvenFibo(int fi)
        {
            Console.WriteLine("Even Numbers :");

            for (int i = 1; i <= fi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(" ");
        }


        //Sista frågan

        /*
         * Rekursion kan minska tidskomplexiteten.
Rekursion ger tydlighet och kan minska den tid som krävs för 
att skriva och felsöka kod. Rekursion använder mer minne jämfört 
med iteration eftersom varje gång den rekursiva funktionen 
anropas lagras funktionsanropet i stack.
Rekursion kan vara långsam. Faktum är att rekursion sällan är 
det mest effektiva sättet att lösa ett problem, och iteration
är nästan alltid mer effektiv. 
         * 
         * 
         */

    }
}
