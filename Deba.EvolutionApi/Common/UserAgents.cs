namespace Deba.EvolutionApi.Common;

public static class UserAgents
{
    private static readonly List<string> Agents = new List<string>
    {
        "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36",
        "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36",
        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36",
    };
    private static readonly Random Random = new Random();

    public static string Get()
    {
        var index = Random.Next(Agents.Count);
        return Agents[index];
    }
}