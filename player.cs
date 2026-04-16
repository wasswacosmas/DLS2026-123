using System;

[Serializable]
public class Player
{
    public string playerName;
    public string position;
    public int rating;
    public int speed;
    public int shooting;
    public int passing;
    public int dribbling;
    public int defense;
    public int stamina;
    public int value;
    public bool isStarPlayer;

    public Player(string name, string pos, int rate, int spd, int sht,
                  int pas, int dri, int def, int sta, int val, bool star)
    {
        playerName = name;
        position = pos;
        rating = rate;
        speed = spd;
        shooting = sht;
        passing = pas;
        dribbling = dri;
        defense = def;
        stamina = sta;
        value = val;
        isStarPlayer = star;
    }
}