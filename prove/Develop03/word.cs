using System;

//this class is responsible for hidden words and display the scripture
class Word
{
    private Scriptures _scripture;
    //private string _hiddenWords;
    private List<string> _hiddenWords;


    //constructor
    public Word()
    {
        _scripture = new Scriptures();
        _hiddenWords = new List<string>();
        
    }


    //method to hidden the words 
    public void ToHidden()
    {
        //call random method
        Random rnd = new Random();
        string words = _scripture.GetMultipleVerses();
        string getWords  = words.Replace(" the ", "---");
        foreach(char a in getWords)
        {
            _hiddenWords.Add(a.ToString());
        }
        foreach(string i in _hiddenWords)
        {
            Console.Write(i);

        }
        //string[] splitWords = words.Split(" ");
        

        

        
        //int index = rnd.Next(splitWords.Length);
        //string getWords  = splitWords[index].Replace("the", "---");
       

      

        

        //int index = rnd.Next(splitWords.Length);
        //string getWords  = splitWords[index];
        //Console.WriteLine(splitWords);
        //string replacer = splitWords[index].Replace(getWords,"---");
        //_hiddenWords = replacer;

    }


    //method to display a single verse scripture
    public void Display()
    {
        
        Console.Write(_hiddenWords);
    }


    //method to display a multiple verse scripture
    public void DisplayMultipleVerse()
    {
        
    }





}