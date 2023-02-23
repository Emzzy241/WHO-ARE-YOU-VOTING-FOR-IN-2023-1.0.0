using System;
using System.Collections.Generic; // don't forget this was added so we can make use of the C# Dictionary easily.... I love adding it because yo never know, you may need to add a Dictionary in your code

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

                // Where I planned to use only return statements and for some reasons Which I do not know, It didn't work(I got the error: Since 'VotingFor.Main()' returns void, a return keyword must not be followed by an object expression [VotingFor]csharp(CS0127))



                /* switch (intUsersAge)
                {
                     case >= 18:
                        return "You are eligible to cast your Vote";

                        // Now After this, I still need to
                        // break;

                    case 17:
                        return "You only have one more year to go, Come back next Year to cast your Vote";
                        // break;

                    // the default case runs when they are no more matches with the specified expression(here the default case runs when users Age is less than  17)
                    default:
                        return "We are deeply Sorry my User, our Organization has its Policies on only allowing People Older than 18 to cast their Votes.... YOu can Learn more on Voting rights by running a Google Search";
                        // break;

                        // It is worthy to note that even if we match with a case before default case, all of the cases thereafter will be run unless we include a return or break; statement in each case
                        // but for some reason which I do not know for now, a return statement ain't working in Vscode... THe Above was what I tried 
                        // So, in the below code I used Console.WriteLine() with a break; and voila no errors
                        // NOTE: you cannot use return and break statements at a time, the break statement becomes an unreachable code Detected if you do so

                }

                */

                // Where I used both COnsole.WriteLine() and a break; statement and it worked perfectly

                switch (intUsersAge)
                {
                     case >= 18:
                        Console.WriteLine("You are eligible to cast your Vote");

                        
                        // Now After this, I now Know my user is of the right age to cast his/her vote
                        
                        break;

                    case 17:
                        Console.WriteLine("You only have one more year to go, Come back next Year to cast your Vote");
                        break;

                    // the default case runs when they are no more matches with the specified expression(here the default case runs when users Age is less than  17)
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