class UserGoal
{
    private User _user;
    private Goal _goal;

    public UserGoal(User user, Goal goal)
    {
        _user = user;
        _goal = goal;
    }

    public User GetUser()
    {
        return _user;
    }

    public Goal GetGoal()
    {
        return _goal;
    }
}
