# Exercise-4-interfaces-delegations-events-and-menus
 (*) Object-oriented programming and polymorphism (*) Implementation of work with interfaces - interfaces (*) Implementation of work with function pointers and delegates


Characterization
As mentioned, you must implement a software component that provides display and management of hierarchical menus for Console applications.
Activating the function (Show.MainMenu_m) will cause the main menu (the first level) to be displayed and in practice
Hold the loop that will actually be the main loop that every console application needs to run.
At each stage:
1. The current level of the menu will be displayed to the user
2. A request will be displayed for the user to choose one of the items.
3. Record the choice from the user
4. An input correctness check will be carried out + an appropriate message will be displayed in case of incorrect input
5. Navigation to the sub-menu / activating the selected operation:

a. Selecting an item that contains sub-items will clear the screen and display the sub-items
the relevant ones (that is, the next level in the menu, that is, back to section 1.)
b. Choosing an item that does not contain sub-items, that is, it is a choice that needs to happen
Any action in the system (for example - the possibility to put a new car in the garage) will clear the
screen and activate the function in the system that provides the user interface that it supports
in this functionality of the system. After the operation is completed in the system, you will be shown again
The level of the menu where we were before and God forbid repeats until the moment the user is selected
with the option of exiting the program (via a special item in the menu)
Please note: the menu always displays in this order (at any level):
- Title (at the first level - main title, at any other level - the title of the item selected at the previous level)
- List of items that belong to the current level (numbered from 1)
- An item that says 'Back' or 'Exit' if it is the main menu (numbered 0)
- A message asking the user to choose from among the items or choose the 'Back' / 'Exit' item

The solution to the exercise will contain a solution with 3 projects:
1.Interfaces. Menus.Ex04 - will contain an implementation according to the first technique.
This is not a project that produces a runtime file but only a class library (Assembly NET).
2.Delegates.Menus.Ex04 - will contain an implementation according to the second technique.
This is not a project that produces a runtime file but only a class library (Assembly NET).
3.Test.Menus.Ex04 – an (EXE) application that demonstrates the use of each of the two projects from the sections
The previous ones:
In the Main method, two menus with 2 levels each must be built (one for each of the two methods).
First the first menu will be displayed and the user will be able to navigate it. When the user chooses to exit the menu (Exit)
He will be presented with the second menu.
Below are the specifications of the menus:
The first level will have 2 items.

a. Item 1 will display a sub-menu with the title - "Spaces and Version" in which there will be 2 items:
"Count Spaces" - item action. i
Runs a method in the system, which asks the user to write a sentence and the system
She tells him how many spaces there are in the sentence.
"Show Version" - item action. ii
(will run a method in the system that displays the following text: 8933.4.3.21: Version)
b. Item 2 will display a sub-menu with the title "Time/Date Show" in which there will be 2 items:
i. The second item will be an action item - "Time Show"
(Activates a method in the system that displays the current time).
ii. The first item will be an action item - "Date Show"
(Activates a method in the system that displays today's date).
Note, there is no need to avoid code duplication between the first two projects.
Please treat them as two different exercises, which may contain similar pieces of code.
