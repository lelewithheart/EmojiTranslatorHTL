namespace EmojiTranslatorSimple;

public interface IEmojiTranslator {
    public void CreateEmojis();
    public string TranslateEmoji(string input);
    public void OutputEmojis();
}