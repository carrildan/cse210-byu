using System.Collections.Generic;
using System.IO;
public class Journal
{
    //member variables. list for questions creation and user entries prompt
    public List<string>_questions = new List<string>(); 
    public List<string>_entry = new List<string>();

    
    //method to create the questions
    public void Prompt()
    {   //FEEDBACK - TAKE OFF THE VARIABLES AND PUT THEM DIRECTLY INTO THE LIST
        //adding a list of questions for the journal
        string question1 = "Describe a spiritual experience you had today: ";
        string question2 = "Did you meet a different or special person today? ";
        string question3 = "Did you meet a different or special place today? ";
        _questions.Add(question1);
        _questions.Add(question2);
        _questions.Add(question3);
    }


    // FEEDBACK - IT MUST HAVE A RANDOM FOR QUESTIONS
    //method to get and add user entries along the questions
    public void Entries()
    {
        string question1 = (_questions[0]);
        Console.WriteLine(question1);
        string userEntry1 = Console.ReadLine();


        string question2 = (_questions[1]);
        Console.WriteLine(question2);
        string userEntry2 = Console.ReadLine();


        string question3 = (_questions[2]);
        Console.WriteLine(question3);
        string userEntry3 = Console.ReadLine();


        //stores questions and user´s entries into the _entry list
        _entry.Add(question1 + userEntry1);
        _entry.Add(question2 + userEntry2);
        _entry.Add(question3 + userEntry3);
    }


    //method for menu option 3(display) display the questions to the user
    public void Display()
    {
        //iterate the entries and displays the content
        foreach(string line in _entry)
        {
            Console.WriteLine(line);
        }
        
    }
} 