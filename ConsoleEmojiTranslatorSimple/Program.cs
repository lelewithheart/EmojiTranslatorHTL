// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using EmojiTranslatorSimple;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Willkommen zum Emoji Translator!");

Utils logik = new Utils();
logik.CreateEmojis();
bool doYouWantToTranslate = true;

while (doYouWantToTranslate) {
    Console.WriteLine("Willst du sehen welche Wörter du übersetzen kannst?");
    string eingabe3 = Console.ReadLine();
    if (eingabe3.ToLower() == "ja") {
        logik.OutputEmojis();
        
        Console.WriteLine("Willst du ein Wort übersetzen?");
        string eingabe = Console.ReadLine();

        if (eingabe.ToLower() == "ja") {
            Console.WriteLine("Gib ein Wort ein: ");
            string eingabe2 = Console.ReadLine();
            string result = logik.TranslateEmoji(eingabe2);
            if (result != null) {
                Console.WriteLine($"Emoji: {result}");
            }
            else {
                Console.WriteLine("Kein Emoji gefunden.");
            }
        }
        else if (eingabe.ToLower() == "nein")
        {
            doYouWantToTranslate = false;
        }
        else
        {
            Console.WriteLine($"Falscher Input Error");
        }
    }
    else if (eingabe3.ToLower() == "nein") {
        Console.WriteLine("Willst du ein Wort übersetzen?");
        string eingabe5 = Console.ReadLine();

        if (eingabe5.ToLower() == "ja") {
            Console.WriteLine("Gib ein Wort ein: ");
            string eingabe2 = Console.ReadLine();
            string result = logik.TranslateEmoji(eingabe2);
            if (result != null)
                Console.WriteLine($"Emoji: {result}");
            else
                Console.WriteLine("Kein Emoji gefunden.");
        }
        else if (eingabe5.ToLower() == "nein")
        {
            doYouWantToTranslate = false;
        }
        else
        {
            Console.WriteLine($"Falscher Input Error");
        }
    }
    else {
        Console.WriteLine($"Falscher Input Error");
    }
}