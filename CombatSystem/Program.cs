// Character stats
// Hero
string heroName = "Hero";
int heroHp = 100;
int heroDamage = 15;

// Goblin
string enemy = "Goblin";
int enemyHp = 100;
int enemyDamage = 8;

// Combat loop
do
{   
    // Hero attacks Enemy
    enemyHp -= heroDamage;
    Console.WriteLine($"{heroName} attacks {enemy} for {heroDamage}! {enemy} has {Math.Max(0, enemyHp)}HP left.");

    // check if enemy is still alive?
    if (enemyHp <= 0)
    {
        Console.WriteLine($"{heroName} wins!");
        break;
    }

    // Enemy attacks Hero
    heroHp -= enemyDamage;
    Console.WriteLine($"{enemy} attacks {heroName} for {enemyDamage}! {heroName} has {Math.Max(0, heroHp)}HP left.");

    // check if Hero is still alive?
    if (heroHp <= 0)
    {
        Console.WriteLine($"{enemy} wins!");
        break;
    }


} while (heroHp > 0 && enemyHp > 0);