using MathGame;

var date = DateTime.UtcNow; //ok

var games = new List<string>(); //ok

string name = Helpers.GetName(); //ok

var menu = new Menu();

menu.ShowMenu(name, date);

