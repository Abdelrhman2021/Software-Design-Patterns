public class GameLobby 
{
    private static GameLobby instance;
    private List <string> players;
    private GameLobby()
    {
        players = new List<string>();

    }
    public void AddPlayer(string playerName)
    {
        players.Add(playerName);
        Console.WriteLine($"{playerName} has joined the lobby");
    }
    public void RemovePlayer(string playerName)
    {
        players.Remove(playerName);
        Console.WriteLine($"{playerName} has Left the lobby");
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
