using System;
using System.Collections.Generic;

class VotingFor{
    static void Main(){
        // after the Main entry-point, let us write the code for our Voting App

        Console.WriteLine("Welcome to the Voting App 101 b Dynasty");
        
        
        
        Console.WriteLine("With this Application being a small and scalable app, for now we would be focusing on users that want to vote only in 4 Parties which will be detailed below");

        Console.WriteLine("Party 1: APC(All Progressive Congress)");
        Console.WriteLine("Party 2: PDP(People's Democratic Party)");
        Console.WriteLine("Party 3: LP(Labour Party)");
        Console.WriteLine("Party 4: NNPP(Nigeria National People's Party)");

        // Now describing the Political Aspirants for all of the listed Parties above

        Console.WriteLine("The Flag Bearer of the APC is Bolaji Ahmed TInubu");
        Console.WriteLine("The Flag Bearer of the PDP is Atiku Abubakar");
        Console.WriteLine("The Presidential Aspirant of the LP is Peter Obi");
        Console.WriteLine("The Flag Bearer of the NNPP is Kwankwaso");

        // FInally the Logic to determine Eligible Voting
        // using the C# comparison operator(==)

        Console.WriteLine("Having Said all of That, If you would love to continue with Me Application, Press 'Y' for Yeah and 'N' No to exit the Applicatio");

        string usersAns = Console.ReadLine();

        // a boolean to determine if truly my user enterred in a string containing Y or N

        // don't forget: .GetType() method will get me the name of the class and also the namespace that class exists in... A format like(System.String or System.Int32) where String is the class name and lives within the System namespace
        // THer eis another method though that will return to me just the exact type of any datatype and that is the GetTypeCode() method.... So instead of returning to me the classname and the namespace that class exists in, it just returns me the classname only(e.g String).... As yu can see here, it basically returns me only String unlike the 
        // GetType() method that will both the classname and the namespace that classname exists in


        string userAnsString = usersAns.GetTypeCode()

        if (usersAns == "Y")
        {
            Console.WriteLine("Thanks for Continuing to use Dynasty's Small but scalable Voting App");
            Console.WriteLine("Thanks for Continuing to use Dynasty's Small but scalable Voting App");
        }



    }
}