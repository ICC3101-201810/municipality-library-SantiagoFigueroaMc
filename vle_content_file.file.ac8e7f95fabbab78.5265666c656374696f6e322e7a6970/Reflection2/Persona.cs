using System;
namespace Reflection2
{
    public class Persona
    {
       
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public int Weight
        {
            get;
            set;
        }


        public string SayHello()
        {
            return "Hello!";
        }

        public string Speak(string wordsToSpeak)
        {
            return wordsToSpeak;
        }
    }
}
