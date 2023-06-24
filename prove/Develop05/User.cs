class User
{
    private string _username;
    private int _score;

    public User(string username)
    {
        _username = username;
        _score = 0;
    }

    public string GetUsername()
    {
        return _username;
    }

    public int GetScore()
    {
        return _score;
    }

    public void UpdateScore(int points)
    {
        _score += points;
    }
}
