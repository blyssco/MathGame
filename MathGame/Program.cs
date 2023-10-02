using MathGame;

var date = DateTime.UtcNow; //ok

string name = Helpers.GetName(); //ok

var menu = new Menu();

menu.ShowMenu(name, date);

