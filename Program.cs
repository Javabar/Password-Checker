// See https://aka.ms/new-console-template for more information


int minLength = 7;
string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowercase = "abcdefghijklmnopqrstuvwxyz";
string digits = "1234567890";
string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";

Console.WriteLine("Please enter a password");
string password = Console.ReadLine();

int score = 0;

if (password.Length >= minLength)
{
  score ++;
}
if (Tools.Contains(password, uppercase))
{
  score++;
}
if (Tools.Contains(password, lowercase))
{
  score++;
}
if(Tools.Contains(password, digits))
{
  score++;
}
if(Tools.Contains(password, specialChars))
{
  score++;
}
Console.WriteLine(score);
