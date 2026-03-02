string[] roles = new string[3];
roles[0] = "Admin";
roles[1] = "User";
roles[2] = "Guest";
Console.WriteLine(roles[10]);

List logs =new List();
logs.Add("User logged in");
logs.Add("User viewed dashboard");
logs.Add("User logged out");    
logs.Add("User logged in");

logs.Remove("User logged in");
logs.RemoveAt(0);
logs.Add("User logged in");

if(!int.TryParse)