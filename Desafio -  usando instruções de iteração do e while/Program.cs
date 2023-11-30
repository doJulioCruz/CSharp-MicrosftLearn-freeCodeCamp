/*

Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo.

O herói e o monstro começarão com dez pontos de integridade.

Todos os ataques serão um valor entre 1 e 10.
O herói atacará primeiro.

Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.

Se a integridade do monstro for maior que zero, ele poderá atacar o herói.

Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.

Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.

Imprima quem foi o vencedor.


//=========== Minha Solução ============
using System.Drawing;

Random random = new Random();

int heroLife = 10;
int monsterLife = 10;

while ((heroLife >= 0) && (monsterLife >= 0))
{
    if (heroLife > 0)
    {
        int heroAtt = random.Next(1, 11);
        monsterLife = monsterLife - heroAtt;
        Console.WriteLine($"O monstro foi danificado e perdeu {heroAtt} ponto de vida e agora tem {monsterLife} pontos de vida.");
    }
    if (monsterLife > 0)
    {    
        int monsterAtt = random.Next(1, 11);
        heroLife = heroLife - monsterAtt;
        Console.WriteLine($"O herói foi danificado e perdeu {monsterAtt} ponto de vida e agora tem {heroLife} pontos de vida.");
    }        
}
if (heroLife > monsterLife)
    Console.WriteLine("Heroi ganhou");
else 
    Console.WriteLine("Monstro ganhou");


//========== Solução Microsoft ==============

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/