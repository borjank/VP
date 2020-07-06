# VP Project // ToDo App

ToDo App is an application that allows the user to add events/tasks and sort them on a daily basis.


## Problem solution

The problem solution consists of:
  - Todo class has two constructors (an empty constructor and a constructor with all parameters) and has these attributes:
    - string Title
    - string Text
    - int Day, Month, Year, Hour, Minute
    - string Color
    - bool completed
  - List of Todo objects (complete and incomplete (for future implementation))
  - List of Panels (list of the ToDos, but dynamically generated based on the user's input)
  

## Functions

### private void validate()
is a function that validates the input into the password box on the first panel that the user sees. It checks if the password is correct (password == test) and acts accordingly, meaning if the password is correct the user will be granted passage onto the next panel or they will receive MessageBox alert that signals wrong input.


### private void generatePanel(Todo todo)
is a function that takes in one argument, an object of the Todo class mentioned above. In this function I initialize the Windows Form Elements needed to create one "card" for one ToDo item. This is the part where I generate a panels, give them their own background color, two buttons and four labels to suit my needs. Then I set up their appearance (size, location, font, etc.) and add the panels to the panel list for later displaying.


### private void showPanelsByDate(int dd, int mm, int yy)
is a function that takes in three arguments, the day, the month and the year. The arguments help the program filter the list of uncomplete todos and return only those who were made for that specific day. After that, we invoke the generatePanel function for each and every one of the returned Todo objects. With this we have panels ready to be displayed to the user and that's what we do in the end of the function. 



## Usage
  - First step: we run the application and we are prompted with a textbox and two buttons. In the textbox we enter the default password, which is 'test' and press 'Enter' on the keyboard, or on the 'Login' button. If one wishes to exit the application, they will press the 'Close' button, or the 'X' in the top right corner.
  - Second step: in the bottom right corner we are prompted with form named "Add a ToDo". we enter the needed details and press the 'ADD TODO' button. With this a To-Do item is created.
  - Third step: if we want to see the added To-Do, we select the date which we entered before in the creation of the To-Do and press show. The To-Do item will be presented on the screen.
  - Screenshots of the application will be in the 'Screenshots' folder in this project.
  
