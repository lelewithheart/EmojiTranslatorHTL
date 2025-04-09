using EmojiTranslatorSimple;

namespace BlazorAppEmoji;

public class EmojiTranslatorService
{
    private readonly Utils _utils = new();

    public EmojiTranslatorService()
    {
        _utils.CreateEmojis();
    }

    public string? Translate(string input)
    {
        return _utils.TranslateEmoji(input);
    }

    public Dictionary<string, string> GetAll()
    {
        var field = typeof(Utils).GetField("_emojiDictionary", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
        return field?.GetValue(null) as Dictionary<string, string> ?? new();
    }
}