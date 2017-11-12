using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Hacker : MonoBehaviour
{
    // Game State
    int level;

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
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "grow up")
        {
            Terminal.WriteLine("Congratulations, you just grew up.");
        }
        else
        {
            Terminal.WriteLine("Please choose 1, 2 or 3.");
        }
    }

    void StartGame ()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
