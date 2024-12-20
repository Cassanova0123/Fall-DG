using System;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string plummie_tag;
    public int collisions;
    public int steps;
    public string Game { get; set; }
    public int Score { get; set; }
    public string Timestamp { get; set; }
    public string Stringify()
    {
        return JsonUtility.ToJson(this);
    }

    public static PlayerData Parse(string json)
    {
        return JsonUtility.FromJson<PlayerData>(json);
    }

    public void FetchPlayerData()
    {

    }

    public void SavePlayerData()
    {

    }
    public PlayerData(string game, int score)
    {
        Game = game;
        Score = score;
        Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

}
