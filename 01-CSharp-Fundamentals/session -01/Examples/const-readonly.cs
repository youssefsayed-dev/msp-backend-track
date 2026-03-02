// const (compile time)
public class AppSettings
{
    public const double Pi = 3.14;
}

// readonly (runtime)
public class User
{
    public readonly DateTime CreatedAt;

    public User()
    {
        CreatedAt = DateTime.Now;
    }
}

// example for both
public class Test
{
    public const int A = 5;
    public readonly int B;

    public Test()
    {
        B = new Random().Next(1, 10);
    }
}