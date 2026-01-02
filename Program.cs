using consol_practise_app;
using System.Threading;
using static Program;

//public abstract class Animal { 

//    public void Eat()
//    {
//        Console.WriteLine("The animel Eatting");
//    }

//    public void Sleep()
//    {
//        Console.WriteLine("The Animal Are eting");

//    }

//    public abstract void Sound();
//    public abstract void Runing();



//}


//public class Dog:Animal
//{
//    public override void Sound()
//    {
//         Console.WriteLine("the Dog Sound Gew Gew");
//    }

//    public override void Runing()
//    {
//        Console.WriteLine("The dog is runing");
//    }




//}


//public class Cow:Animal
//{
//    public override void Sound()
//    {
//        Console.WriteLine("The Cow Sound Hamba Hamba");
//    }

//    public override void Runing()
//    {
//        Console.WriteLine("Cow is runing");
//    }


//}


public class TesterClass
{
    public static int testervalue;

    public TesterClass()
    {
        Console.WriteLine("Tester class");
    }

    static TesterClass()
    {
        if (testervalue==0) 
        {
            Console.WriteLine("Tester class result :",10);
        }
    }


    static void fun1(ref int a)
    {
        a = a * a;
    }

}


class Program
{
    int[] mystack = new int[5];
    int top = -1;

    int push(int[] mystack, int val)
    {

        if (top > 5)
        {
            Console.WriteLine("Stack Is overflow");
        }
        else
        {
            top++;
            mystack[top] = val;


        }

        return 0;

    }


    public void Dispaly()
    {
        if (top < 0)
        {
            Console.WriteLine("The Stack Is empty");
        }
        else
        {
            for (int i = top; i < 5; i++)
            {
                Console.WriteLine(mystack[i]);
            }

        }

    }


    public void GuessLetter()
    {
        string word = "computer"; // Secret word
        int wordLength = word.Length;

        char[] guessed = new char[wordLength]; // To store correct guesses
        int attempts = 7;                      // Wrong attempts allowed
        int correct = 0;                       // Count correct letters

        // Initialize guessed array with '_'
        for (int i = 0; i < wordLength; i++)
        {
            guessed[i] = '_';
        }

        Console.WriteLine("===== WORD GUESSING GAME =====");
        Console.WriteLine($"Guess the word (Total letters: {wordLength})");
        Console.WriteLine($"You have {attempts} attempts.\n");

        while (attempts > 0 && correct < wordLength)
        {
            Console.WriteLine("Word: " + new string(guessed));
            Console.Write("Enter a letter: ");
            char guess = Console.ReadKey().KeyChar;
            Console.WriteLine();

            bool found = false;

            // Check if guessed letter exists in the word
            for (int i = 0; i < wordLength; i++)
            {
                if (word[i] == guess && guessed[i] == '_')
                {
                    guessed[i] = guess;
                    correct++;
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                attempts--;
                Console.WriteLine($"Wrong guess! Attempts left: {attempts}\n");
            }
        }

        // Final result
        if (correct == wordLength)
        {
            Console.WriteLine($"🎉 Congratulations! You guessed the word: {word}");
        }
        else
        {
            Console.WriteLine($"❌ Game Over! The correct word was: {word}");
        }
    }



    public class Student
    {
        public string name="Just a Student";
        public string department = "nothing";

        public void UpdateDepartment( string dpt)
        {
            department =dpt;
        }

        public  void updateName(string n)
        {
            name = n;
        }

        public void Detailes()
        {
            Console.WriteLine($"Name: {name} Department:{ department}");
        }
    }
    public class BBAStudent:Student
    {

       public BBAStudent()
       {
            UpdateDepartment("BBA");
       }
       public BBAStudent (string name)
       {
            updateName(name);
            UpdateDepartment("BBA");
       }

   
    }


    public class Animal
    {
        public string name;
        public int age;
        public string color;
      


        public Animal(string name, int age, string color)
        {
           this.name = name;
           this.age = age;
           this.color = color;
        }


        public virtual void makeSound()
        {
            Console.WriteLine("Animal makes a sound");

        }

        public virtual string info()  
        {
            return ($"Name: {name}\n  Age:{age}\n Color: {color}\n");
        }
    }

    public class Dog:Animal
    {
        public string Bread;
        public Dog(string name, int age, string color, string Bread) : base(name, age, color)
        {
            this.Bread = Bread;
        }


        public override string info()
        {
            return ($"Name: {name}\n  Age:{age}\n Color: {color}\n Breed: {this.Bread}");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{color} Color {name} is Braking");


            
        }
    }

    public class Cat : Animal
    {
        public string Bread;
        public Cat(string name, int age, string color, string Bread) : base(name, age, color)
        {
            this.Bread = Bread;
        }

        public override string info()
        {
            return ($"Name: {name}\n  Age:{age}\n Color: {color}\n Breed: {this.Bread}");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{color} Color {name} is meowing");

        }


    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
            next = null;

        }
    }

    public class SingleLinkdList
    {
        public Node head;

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;

            }
            current.next = newNode;
        
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data + "-> ");
                current = current.next;

            }
            Console.WriteLine("null");

        }

    }

    static void Main(string[] args)
    {
        LinkedListProgram list = new LinkedListProgram();
        list.linklistmain();

        //SingleLinkdList list = new SingleLinkdList();

        //list.Add(10);
        //list.Add(20);
        //list.Add(30);

        //list.Print();



        //Program program = new Program();


        //Dog dog = new Dog("Buddy",5,"Brown", "Bulldog");
        //Cat cat = new Cat("Kitty",3,"White", "Persian");
        //Console.WriteLine(dog.info());
        //Console.WriteLine("1---------------");
        //Console.WriteLine(cat.info());
        //Console.WriteLine("2---------------");
        //dog.makeSound();
        //Console.WriteLine("3---------------");
        //cat.makeSound();




        //BBAStudent b1 = new BBAStudent();

        //BBAStudent b2 = new BBAStudent("Humpty Dumpty");

        //BBAStudent b3 = new BBAStudent("Little Bo Peep");


        //b1.Detailes();
        //Console.WriteLine("1---------------");
        //b2.Detailes();
        //Console.WriteLine("2---------------");
        //b3.Detailes();
        //program.GuessLetter();



        //TicTackGames ticTackGames = new TicTackGames();

        //ticTackGames.InitializeBoard();

        //while (true)
        //{
        //    ticTackGames.PrintBoard();
        //    ticTackGames.PlayerMove();

        //    if (ticTackGames.CheckWinner())
        //    {
        //        ticTackGames.PrintBoard();
        //        Console.WriteLine($"Player {ticTackGames.currentPlayer} wins!");
        //        break;
        //    }

        //    if (ticTackGames.IsBoardFull())
        //    {
        //        ticTackGames.PrintBoard();
        //        Console.WriteLine("The game is a draw!");
        //        break;
        //    }

        //    ticTackGames.SwitchPlayer();
        //}

        //Console.ReadLine();



        //    int a = 5;

        //    Program program = new Program();

        //    //fun1(ref a);

        //    //Console.WriteLine(a);

        //    //Cow cow = new Cow();
        //    //cow.Sound();
        //    //cow.Runing();

        //    //Dog dog =new Dog();

        //    //dog.Sound();
        //    //dog.Eat();

        //    //cow.Eat();
        //    program.Dispaly();
        //    program.push(program.mystack, 5);
        //    program.push(program.mystack, 10);
        //    program.push(program.mystack, 20);
        //    program.push(program.mystack, 50);
        //    program.Dispaly();


        //}
        //static void fun1(ref int a)
        //{
        //    a = a * a;
        //}


    }
}

