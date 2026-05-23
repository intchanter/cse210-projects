class ColorText
{
    public static string Bold(string text)
    {
        return $"\e[1m{text}\e[0m";
    }

    public static string Black(string text)
    {
        return $"\e[30m{text}\e[0m";
    }

    public static string Red(string text)
    {
        return $"\e[31m{text}\e[0m";
    }

    public static string Green(string text)
    {
        return $"\e[32m{text}\e[0m";
    }

    public static string Yellow(string text)
    {
        return $"\e[33m{text}\e[0m";
    }

    public static string Blue(string text)
    {
        return $"\e[34m{text}\e[0m";
    }

    public static string Magenta(string text)
    {
        return $"\e[35m{text}\e[0m";
    }

    public static string Cyan(string text)
    {
        return $"\e[36m{text}\e[0m";
    }

    public static string White(string text)
    {
        return $"\e[37m{text}\e[0m";
    }
}