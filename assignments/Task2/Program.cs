using System;
using System.Collections.Generic;

public class GameLobby
{
    private static GameLobby instance;
    private List<string> players;

    private GameLobby()
    {
        players = new List<string>();
    }

    public static GameLobby GetInstance()
    {
        if (instance == null)
        {
            instance = new GameLobby();
        }
        return instance;
    }

    public void AddPlayer(string playerName)
    {
        players.Add(playerName);
        Console.WriteLine($"{playerName} has joined the lobby");
    }

    public void RemovePlayer(string playerName)
    {
        players.Remove(playerName);
        Console.WriteLine($"{playerName} has left the lobby");
    }

    public void ListPlayers()
    {
        Console.WriteLine("Players in the game lobby");
        foreach (string player in players)
        {
            Console.WriteLine(player);
        }
    }
}
