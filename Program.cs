#region ""



using System;

namespace LS_10_Classes
{
    class Program
    {
        #endregion
        /*
            Extra 1 - Casting datatypes 

        To cast a variable to another datatype you have your variable name myvariable and 
           we give it a cast of a new datatye like so:

            (newclass)myclassvariable;

        to assign the variable it must be of that datatype :

        newclass example= (newclass)myclassvariable
        
        When would we use this?

        When we have a array of a class that has child classes we can assign the child class
        to a datatype of the parent class like so:

        childclass yourchild;

        parentclass yourparent= yourchild;  -- valid no error

        however you cant access the childs members unless you cast it back to a 
        child again in another variable
            
            
         */

        static void Main(string[] args)
        {
            Character[] Characters = new Character[5];              

            Player player1 = new Player();

            Character Character1 = new Character();

            Characters[1] = Character1;

            Characters[0] = player1;

            Console.WriteLine(Characters[0].my_int);

            if (Characters[0] is Player)
            {
                var test = (Player)Characters[0];
                Console.WriteLine(test.my_float);
            }
            if (Characters[1] is Player)
            {
                var test = (Player)Characters[1];
                Console.WriteLine(test.my_float);
            }
        }
        class Character
        {
            public int my_int;

            public virtual void myFunc()
            {
                Console.WriteLine("Call Function");
            }

            public Character()
            {
                my_int = 1;
            }
        }
        class Player : Character
        {
            public float my_float;

            public Player()
            {
                my_float = 6.3f;
            }

            public override void myFunc()
            {
                Console.WriteLine("myfunc overrided Function");
            }
        }
        class Enemy : Character
        {
            public float my_float;

            public override void myFunc()
            {
                Console.WriteLine("Enemy has function");
            }

            public bool use = false;
        }
        #region ""
    }
}
#endregion