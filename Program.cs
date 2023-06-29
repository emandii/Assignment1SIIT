//OBFUSCATE EMAIL

string email = "awesome@dotnet.com";
string obfuscatedEmail = ObfuscateEmail(email);
Console.WriteLine(obfuscatedEmail);

static string ObfuscateEmail(string email)
{
    int atIndex = email.IndexOf('@');
    string username = email.Substring(0, atIndex);
    string domain = email.Substring(atIndex);

    string obfuscatedUsername = new string('*', username.Length);
    string obfuscatedEmail = obfuscatedUsername + domain;

    return obfuscatedEmail;
}

Console.ReadKey();
