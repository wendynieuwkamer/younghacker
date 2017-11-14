using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Hacker : MonoBehaviour
{
    // Game Configuration Data
    string[] level1Passwords = { "dolls", "mommy", "green", "flower", "candy" };
    string[] level2Passwords = { "teacher", "biology", "student", "private", "learned" };
    string[] level3Passwords = { "lollipop", "confection", "chocolate", "caramelize", "marshmallow" };

    // Game State
    int level;
    string password;

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;



    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // We can always go directly to the main menu.
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    

    void ShowMainMenu ()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?\n");
        Terminal.WriteLine("1. Little Sister's Laptop\n     Read her *secret* digital diary.");
        Terminal.WriteLine("2. School Grade System\n     Get yourself the perfect grades.");
        Terminal.WriteLine("3. Candy Distribution Center\n     Send some candy your way.\n");
        Terminal.WriteLine("Press 1, 2 or 3 and hit return:");
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "grow up") // Easter egg, Add bonus level later
        {
            Terminal.WriteLine("Congratulations, you just grew up.");
        }
        else
        {
            Terminal.WriteLine("Please choose 1, 2 or 3.");
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            if (level == 1)
            {
                Terminal.WriteLine("Congratulations, you now have access to your sister's diary.");
            }
            else if (level == 2)
            {
                Terminal.WriteLine("Congratulations, you can now change your grades.");
            }
            else if (level == 3)
            {
                Terminal.WriteLine("Congratulations, pick you candy");
            }
        }
        else
        {
            Terminal.WriteLine("Please try again");
        }
    }

    void StartGame ()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch(level)
        {
            case 1:
                password = level1Passwords[0];
                break;
            case 2:
                password = level2Passwords[2];
                break;
            case 3:
                password = level3Passwords[1];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password");
    }
   

    // Update is called once per frame
    void Update()
    {

    }
}
