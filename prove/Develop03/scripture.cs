using System;
using System.Collections.Generic;

class Scripture
{
   //attribute that stores a scripture
   string _scripture;
   //attribute that stores and tracks the words of the scripture
   string[] _words;
   List<string> _newListofWords = new List<string>();


   //constructor for a single verse scripture
   public Scripture(string scripture)
   {
        _scripture = scripture;
   }


    //constructor for multiple verses scripture
   public Scripture(string verse, string multipleVerses )
   {
    _scripture = verse + multipleVerses;
   }


   public string getScripture()
   {
     return _scripture;
   }


   public void setScripture(string words)
   {
     _scripture = words;
   }


   public void addingWords()
   {
      //split the letters into words
      _words = _scripture.Split(" ");

      //adding each word of the scripture into to the list so it can hide it. I WASN´T ABLE TO HANDLE HIDDING PROCESS WITHOUT ADDING IT TO A LIST.
      foreach(string item in _words)
      {
        _newListofWords.Add(item);
      }
   }


   //method to hide the word
   public void HideWords()
   {
        //generates a random word inside the list so it hides randomly
        Random rnd = new Random();
        string rndWord = _words[rnd.Next(0,_words.Count())];


        //hides the targeted word 
        for(int i=0;i<_newListofWords.ToList().Count;i++)
        {
            if(_newListofWords[i].Contains(rndWord) && _newListofWords[i] != "---")
            {
                _newListofWords[i] = "---";
            }    
            
   
        }    
     }
        
        public void Display()
        {
          foreach(string item in _newListofWords)
          {
               Console.Write(item);
          }
        }
   


}

