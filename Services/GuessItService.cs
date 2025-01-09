using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekKMCEightToTen.Services
{
    public class GuessItService
    {
        public string GuessItEasy(string easyUserGuess){
            bool validNum = false;
            int convertedNum = 0;
            validNum = int.TryParse(easyUserGuess, out convertedNum);
        
            if(validNum == false)
            {
                return "Please enter a valid number between one and ten.";
            } else
            {
                Random rng = new Random();
                int easy = rng.Next(1,11);

                if(convertedNum > 10 || convertedNum < 1){
                    return "Whoa! That number is not between one and ten!";
                }

                if(convertedNum == easy)
                {
                    return "Thats correct! You guessed it!";
                }else if(convertedNum > easy)
                { 
                    return "Woops! Looks like you guessed higher then you should have!.";
                }else if(convertedNum < easy)
                {  
                    return "Oh dear! Looks like you guessed lower then you should have!";
                }else
                {
                    return "Honestly Im impressed you got here.";
                }

            }
        }
    }
}