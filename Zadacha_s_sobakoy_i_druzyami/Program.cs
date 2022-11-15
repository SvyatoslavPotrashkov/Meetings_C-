// Задача с собакой и друзьями

int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogspeed = 5;
int friend = 2;

while (distance > 10)
{
    if (friend == 1)
    {
        int time = distance / (firstFriendSpeed + dogspeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        friend = 2;

    }
    else if (friend == 2)
    {
        int time = distance / (secondFriendSpeed + dogspeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        friend = 1;
    }
    count++;

}
Console.WriteLine($"Собака пробежит {count} раз");

