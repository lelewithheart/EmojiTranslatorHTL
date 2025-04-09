namespace EmojiTranslatorSimple;

public class Utils : IEmojiTranslator{
    private static Dictionary<string, string> _emojiDictionary = new();

    public void CreateEmojis()
    {
        _emojiDictionary["happy"] = "😄";
        _emojiDictionary["sad"] = "😢";
        _emojiDictionary["heart"] = "❤️";
        _emojiDictionary["fire"] = "🔥";
        _emojiDictionary["thumbs up"] = "👍";
        _emojiDictionary["laugh"] = "😂";
        _emojiDictionary["angry"] = "😡";
        _emojiDictionary["cry"] = "😭";
        _emojiDictionary["smile"] = "😊";
        _emojiDictionary["wink"] = "😉";
        _emojiDictionary["love"] = "😍";
        _emojiDictionary["cool"] = "😎";
        _emojiDictionary["surprised"] = "😲";
        _emojiDictionary["sleepy"] = "😴";
        _emojiDictionary["sick"] = "🤢";
        _emojiDictionary["party"] = "🥳";
        _emojiDictionary["clap"] = "👏";
        _emojiDictionary["ok"] = "👌";
        _emojiDictionary["pray"] = "🙏";
        _emojiDictionary["star"] = "⭐";
        _emojiDictionary["poop"] = "💩";
        _emojiDictionary["robot"] = "🤖";
        _emojiDictionary["cat"] = "🐱";
        _emojiDictionary["dog"] = "🐶";
        _emojiDictionary["sun"] = "☀️";
        _emojiDictionary["moon"] = "🌙";
        _emojiDictionary["rain"] = "🌧️";
        _emojiDictionary["snow"] = "❄️";
        _emojiDictionary["tree"] = "🌳";
        _emojiDictionary["car"] = "🚗";
        _emojiDictionary["bike"] = "🚲";
        _emojiDictionary["rocket"] = "🚀";
        _emojiDictionary["pizza"] = "🍕";
        _emojiDictionary["burger"] = "🍔";
        _emojiDictionary["cake"] = "🍰";
        _emojiDictionary["coffee"] = "☕";
        _emojiDictionary["ice cream"] = "🍦";
        _emojiDictionary["chicken jockey"] = "👶🐔🧟";
    }

    public string TranslateEmoji(string input) {
        input = input.ToLower();

        foreach (var a in _emojiDictionary) {
            if (a.Key == input) {
                return a.Value;
            }
        }
        
        return null;
    }

    public void OutputEmojis() {
        foreach (var a in _emojiDictionary) {
            Console.WriteLine($"{a.Key} => {a.Value}");
        }
    }
}