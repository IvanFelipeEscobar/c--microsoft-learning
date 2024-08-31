Random damagePoints = new();
int heroHealth = 10;
int monsterHealth = 10;
int attackPoints;
Console.WriteLine("----------BATTLE BEGINS--------------\n\nHero Health: 10\t\tMontser Health: 10\n\n");
int counter = 0;
do
{
    counter++;
    Console.WriteLine($"\n---------------------ROUND {counter}--------------------------\n");
    if (counter % 2 != 0)
    {
        attackPoints = damagePoints.Next(1, 11);
        monsterHealth -= attackPoints;
        Console.WriteLine($"Hero Attacks!\tcausing {attackPoints} pts of damage...\nHero Health: {heroHealth}\t\tMonster Health: {monsterHealth}\n");
    }
    else
    {

        attackPoints = damagePoints.Next(1, 11);
        heroHealth -= attackPoints;
        Console.WriteLine($"Monster Attacks!\tcausing {attackPoints} pts of damage...\nHero Health: {heroHealth}\t\tMonster Health: {monsterHealth}\n");

    }

} while (monsterHealth > 0 && heroHealth > 0);
Console.WriteLine(heroHealth <= 0 ? "MONSTER WINS!!! TRY AGAIN" : "Congrats!!! You killed the monster");