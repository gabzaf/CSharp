
string[] gameHours = Console.ReadLine().Split();
int startHour = int.Parse(gameHours[0]);
int startMinute = int.Parse(gameHours[1]);
int endHour = int.Parse(gameHours[2]);
int endMinute = int.Parse(gameHours[3]);

int duration = ((endHour*60) + endMinute) - ((startHour*60) + startMinute);
if (duration <= 0) duration += 24 * 60;

Console.WriteLine($"O JOGO DUROU {duration / 60} HORA(S) E {duration % 60} MINUTO(S)");
Console.ReadLine();