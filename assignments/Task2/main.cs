using System;

class Program
{
    static void Main()
    {
        GameLobby lobby = GameLobby.GetInstance();

        lobby.AddPlayer("Player1");
        lobby.AddPlayer("Player2");

        lobby.ListPlayers();

        lobby.RemovePlayer("Player2");

        lobby.ListPlayers();
    }
}
