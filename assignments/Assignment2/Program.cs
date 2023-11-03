using System;
using System.Collections.Generic;

public class ConfigurationManager
{
    private static ConfigurationManager instance;
    private Dictionary<string, string> settings;

    private ConfigurationManager()
    {
        settings = new Dictionary<string, string>();
    }

    public static ConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            instance = new ConfigurationManager();
        }
        return instance;
    }

    public string GetSetting(string key)
    {
        if (settings.ContainsKey(key))
        {
            return settings[key];
        }
        return "Setting Couldn't be retrieved we ethd b2a";
    }

    public void SetSetting(string key, string value)
    {
        settings[key] = value;
    }
}

class Program
{
    static void Main()
    {
        ConfigurationManager configManager = ConfigurationManager.GetInstance();

        // Setting configuration values
        configManager.SetSetting("AppName", "MyApp");
        configManager.SetSetting("LogLevel", "Info");

        // Retrieving configuration values
        string appName = configManager.GetSetting("AppName");
        string logLevel = configManager.GetSetting("LogLevel");

        Console.WriteLine("Application Name: " + appName);
        Console.WriteLine("Log Level: " + logLevel);
    }
}
