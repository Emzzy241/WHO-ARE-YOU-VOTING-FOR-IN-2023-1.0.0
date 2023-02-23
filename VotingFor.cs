using System;
using System.Collections.Generic;

class VotingFor
{
    static void Main()
    {
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

        Console.WriteLine("Having Said all of That, If you would love to continue with Me Application, Enter 'Y' for Yes and 'N' No to exit the Application");

        string usersAns = Console.ReadLine();

        // a boolean to determine if truly my user enterred in a string containing Y or N

        // don't forget: .GetType() method will get me the name of the class and also the namespace that class exists in... A format like(System.String or System.Int32) where String is the class name and lives within the System namespace
        // THer eis another method though that will return to me just the exact type of any datatype and that is the GetTypeCode() method.... So instead of returning to me the classname and the namespace that class exists in, it just returns me the classname only(e.g String).... As yu can see here, it basically returns me only String unlike the 
        // GetType() method that will both the classname and the namespace that classname exists in


        // string userAnsString = usersAns.GetTypeCode()

        if (usersAns == "Y")
        {
            Console.WriteLine("Thanks for Continuing to use Dynasty's Small but scalable Voting App");
            Console.WriteLine("As we both Know, the Constitution of the Federal Republic of Nigeria says to exercise your Right to vote and be voted for, you must be 18 years of age and above");

            Console.WriteLine("We as an Organization will now be fperforming our Background Check to confirm you are 18 years of Age and Above");

            Console.WriteLine("To conntinue with this, Enter 'Y' for Yeah and 'N' No to exit the Application");

            string appContinue = Console.ReadLine();

            if (appContinue == "Y")
            {
                Console.WriteLine("Please answer the FOllowing Qustions");
                Console.WriteLine("How Old Are you?");

                string usersAge = Console.ReadLine();
                // don't forget, the .ReadLine() method works with only strings and thats why we stored it in a string variable
                // the Console.ReadLine() variable value needs to be converted into an Integer because we both know: Age is a number(or an Integer and not a string)


                // if (intUsersAge >= 18)
                // {

                // }
                // else if (intUsersAge == 17)
                // {
                //     Console.WriteLine("You only have one more year to go, Come back next Year to cast your Vote");
                // }
                // else if (intUsersAge < 17)
                // {
                //     Console.WriteLine("We are deeply Sorry my User, our Organization has its Policies on only allowing People Older than 18 to cast their Votes.... YOu can Learn more on Voting rights by running a Google Search");
                // }

                // MAKING USE OF SWITCH CASE STATEMENTS IN PLACE OF MY BRANCH
                // in switch case statements; we do not need to keep writing and rewriting the name of our variable over and over again 
                // our switch statement moves through each case to see if it matches the specified expression... in our case the value of  intUsersAge
                // if there is a match between the case and the expression, then the code within the case will run
                // and Yes we can use both the built-in "return" keyword or we can stick with our amazing Console.WriteLine()way... I used both of them to prove how true it was



                int intUsersAge = int.Parse(usersAge);

                switch (intUsersAge)
                {
                    case >= 18:
                        Console.WriteLine("You are eligible to cast your Vote");
                        break;

                    case 17:
                        Console.WriteLine("You only have one more year to go, Come back next Year to cast your Vote") ;
                        break;

                    default:
                        Console.WriteLine("We are deeply Sorry my User, our Organization has its Policies on only allowing People Older than 18 to cast their Votes.... YOu can Learn more on Voting rights by running a Google Search");
                        break;
                }


            }
            // exiting the Application for my user anytime they choose to
            else if (usersAns == "N")
            {
                Console.WriteLine("Goodbye Me Dear User :)");
            }

        }
        else if (usersAns == "N")
        {
            Console.WriteLine("Goodbye Me Dear User :)");
        }




    }
}