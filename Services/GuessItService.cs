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
                    return "Honestly I'm impressed you got here.";
                }

            }
        }

        public string GuessItMedium(string mediumUserGuess){
            bool validNum = false;
            int convertedNum = 0;
            validNum = int.TryParse(mediumUserGuess, out convertedNum);
        
            if(validNum == false)
            {
                return "Please enter a valid number between one and fifty.";
            } else
            {
                Random rng = new Random();
                int medium = rng.Next(1,51);

                if(convertedNum > 50 || convertedNum < 1){
                    return "Whoa! That number is not between one and fifty!";
                }

                if(convertedNum == medium)
                {
                    return "Thats correct! You guessed it!";
                }else if(convertedNum > medium)
                { 
                    return "Woops! Looks like you guessed higher then you should have!.";
                }else if(convertedNum < medium)
                {  
                    return "Oh dear! Looks like you guessed lower then you should have!";
                }else
                {
                    return "Honestly I'm impressed you got here.";
                }

            }
        }

        public string GuessItHard(string hardUserGuess){
            bool validNum = false;
            int convertedNum = 0;
            validNum = int.TryParse(hardUserGuess, out convertedNum);
        
            if(validNum == false)
            {
                return "Please enter a valid number between one and one-hundred.";
            } else
            {
                Random rng = new Random();
                int hard = rng.Next(1,101);

                if(convertedNum > 100 || convertedNum < 1){
                    return "Whoa! That number is not between one and one-hundred!";
                }

                if(convertedNum == hard)
                {
                    return "Thats correct! You guessed it!";
                }else if(convertedNum > hard)
                { 
                    return "Woops! Looks like you guessed higher then you should have!.";
                }else if(convertedNum < hard)
                {  
                    return "Oh dear! Looks like you guessed lower then you should have!";
                }else
                {
                    return "Honestly I'm impressed you got here.";
                }

            }
        }
    }
}