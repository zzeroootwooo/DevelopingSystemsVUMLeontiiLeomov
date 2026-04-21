double damagePerTurn = double.Parse(Console.ReadLine()!);
double heiganHp = 3_000_000;
double playerHp = 18_500;
int playerRow = 7, playerCol = 7;
bool playerDead = false;
string killedBy = "";
double cloudDamage = 0;

string? line;
while ((line = Console.ReadLine()) != null)
{
    if (heiganHp <= 0) break;

    var p = line.Split();
    string spell = p[0];
    int spellRow = int.Parse(p[1]), spellCol = int.Parse(p[2]);

    bool inBlast = playerRow >= spellRow - 1 && playerRow <= spellRow + 1 &&
                   playerCol >= spellCol - 1 && playerCol <= spellCol + 1;

    if (inBlast)
    {
        int[] drs = { -1, 1, 0, 0 };
        int[] dcs = { 0, 0, -1, 1 };
        bool moved = false;
        foreach (var (dr, dc) in drs.Zip(dcs))
        {
            int nr = playerRow + dr, nc = playerCol + dc;
            if (nr >= 0 && nr < 15 && nc >= 0 && nc < 15)
            {
                bool newInBlast = nr >= spellRow - 1 && nr <= spellRow + 1 &&
                                  nc >= spellCol - 1 && nc <= spellCol + 1;
                if (!newInBlast) { playerRow = nr; playerCol = nc; moved = true; break; }
            }
        }
        if (!moved)
        {
            if (cloudDamage > 0) { playerHp -= cloudDamage; cloudDamage = 0; }
            double dmg = spell == "Cloud" ? 3500 : 6000;
            playerHp -= dmg;
            if (spell == "Cloud") cloudDamage = 3500;
            else cloudDamage = 0;
            if (playerHp <= 0) { playerDead = true; killedBy = spell == "Cloud" ? "Plague Cloud" : "Eruption"; }
        }
        else
        {
            if (cloudDamage > 0) { playerHp -= cloudDamage; cloudDamage = 0; }
            if (playerHp <= 0) { playerDead = true; killedBy = "Plague Cloud"; }
        }
    }
    else
    {
        if (cloudDamage > 0) { playerHp -= cloudDamage; cloudDamage = 0; }
        if (playerHp <= 0) { playerDead = true; killedBy = "Plague Cloud"; }
    }

    heiganHp -= damagePerTurn;
}

if (heiganHp <= 0) Console.WriteLine("Heigan: Defeated!");
else Console.WriteLine($"Heigan: {heiganHp:F2}");
if (playerDead) Console.WriteLine($"Player: Killed by {killedBy}");
else Console.WriteLine($"Player: {(int)playerHp}");
Console.WriteLine($"Final position: {playerRow}, {playerCol}");
