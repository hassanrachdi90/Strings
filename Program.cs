using System.Text;
Console.WriteLine("Hello Strings!");
Console.WriteLine("Exemples de séquences d'échappement :\n");
Console.WriteLine("1. Guillemets simples : \'" + '\'');
Console.WriteLine("2. Guillemets doubles : \"" + "Texte" + "\"");
Console.WriteLine("3. Backslash : " + "C:\\Program Files\\dotnet");
Console.WriteLine("4. Null : " + '\0');
Console.WriteLine("5. Alerte sonore : \a"); // Beep si supporté
Console.WriteLine("6. Backspace : ABC\bD"); // Efface C, affiche "ABD"
Console.WriteLine("7. Form Feed : Bonjour\fMonde");
Console.WriteLine("8. Nouvelle ligne : Bonjour\nMonde");
Console.WriteLine("9. Retour chariot : Bonjour\rMonde"); // Affiche "Mondeur"
Console.WriteLine("10. Tabulation horizontale : Nom\tAge");
Console.WriteLine("11. Tabulation verticale : Bonjour\vMonde");
Console.WriteLine("====================================");
string chemin = @"C:\Users\Hassa\Documents\Projet";
Console.WriteLine(chemin);
string message = @"Bonjour,
Bienvenue dans l'application.
Veuillez entrer votre choix.";
Console.WriteLine(message);
string json = """
{
  "nom": "Hassa",
  "age": 25,
  "ville": "Paris"
}
""";
Console.WriteLine(json);
Console.WriteLine("====================================");
string result = string.Format("Bonjour {0}, vous avez {1} ans.", "Hassan", 25);
Console.WriteLine(result);
Console.WriteLine("====================================");
string[] noms = { "Alice", "Bob", "Charlie" };
string result1 = string.Join(" , ", noms);
Console.WriteLine(result1);
Console.WriteLine("====================================");
string texte = "Bonjour, je suis Hassan.";
var phrase=texte.ToArray();
for(int i = 0; i < phrase.Length; i++)
{
    if(phrase[i] == ' ' ){phrase[i]='-';}
           
}
texte=new string(phrase);
Console.WriteLine(texte);
int index=texte.IndexOf('a');
Console.WriteLine(index);
index=texte.LastIndexOf('a');
Console.WriteLine(index);
Console.WriteLine(texte.Contains("Hassan"));
Console.WriteLine(texte.StartsWith("Bonjour"));
Console.WriteLine(texte.EndsWith("Hassan"));
Console.WriteLine(texte.Replace("Hassan", "Ali"));
Console.WriteLine(texte.ToUpper());
Console.WriteLine(texte.ToLower());
Console.WriteLine(texte.Substring(0, 7)); // Affiche "Bonjour"
Console.WriteLine(texte.Substring(8)); // Affiche "je suis Hassan."
Console.WriteLine(texte.Remove(7)); // Affiche "Bonjour"
Console.WriteLine(texte.Remove(7, 1)); // Affiche "Bonjour je suis Hassan."
Console.WriteLine(texte.Insert(7, "tout le monde ")); // Affiche "Bonjour tout le monde je suis Hassan."
Console.WriteLine(texte.PadLeft(30)); // Affiche "Bonjour, je suis Hassan."
Console.WriteLine(texte.PadRight(30)); // Affiche "Bonjour, je suis Hassan."
Console.WriteLine(texte.PadLeft(30, '*')); // Affiche "*****Bonjour, je suis Hassan."
Console.WriteLine(texte.PadRight(30, '*')); // Affiche "Bonjour, je suis Hassan*****"
Console.WriteLine(texte.Trim()); // Affiche "Bonjour, je suis Hassan."
Console.WriteLine(texte.TrimStart()); // Affiche "Bonjour, je suis Hassan."
Console.WriteLine(texte.TrimEnd()); // Affiche "Bonjour, je suis Hassan."
Console.WriteLine(texte.Trim('B', '.')); // Affiche "onjour, je suis Hassan"
Console.WriteLine(texte.Length); // Affiche 21
Console.WriteLine(texte[0]); // Affiche 'B'
string[] texte1 = texte.Split(',');
Console.WriteLine(texte1);
Console.WriteLine("========================Exercice Palindromes-Word ============");
//string mot = "radar";
//string mot2 = "Noon";
//string mot3 = "mom";
string word =Console.ReadLine().ToLower();
int leftCount = 0;
int rightCount = word.Length - 1;
for (int i = 0; i < word.Length / 2; i++)
{
    if (word[leftCount] != word[rightCount])
    {
        Console.WriteLine("Ce mot n'est pas un palindrome");
        break;
    }
    
    leftCount++;
    rightCount--;
}
Console.WriteLine("Ce mot est un palindrome");
Console.WriteLine("========================String-Builder ============");
        //string str="Hassan";
        //Console.WriteLine(str.Trim());
        //StringBuilder sb = new StringBuilder();
        StringBuilder sb = new StringBuilder("Hassan");
        sb.Append(" Rachdi");
        sb.AppendLine(" ");
        sb.AppendLine("Bienvenue dans l'application");
        Console.WriteLine(sb.ToString());
        Console.WriteLine(sb[3]);
        Console.WriteLine(sb.Insert(0,"19 MR "));
        Console.WriteLine(sb.Remove(0,2));
        Console.WriteLine(sb.Replace("Rachdi","Ali"));
        Console.WriteLine(sb.Length);
Console.WriteLine("========================String-Formatting ============");
DateTime date = DateTime.Now;
Console.WriteLine(date);
Console.WriteLine($"date: {date:d}");
Console.WriteLine($"date: {date:t}");
Console.WriteLine($"date: {date:dd}");
Console.WriteLine($"date: {date:MM}");
Console.WriteLine($"date: {date:yyyy}");
Console.WriteLine($"date: {date:dd:MM:yyyy}");
Console.WriteLine($"date: {date:hh:mm:ss}");
double price =2555.57;
Console.WriteLine($"Prix: {price:C}");
Console.WriteLine($"Prix: {price:P}");
Console.WriteLine($"Prix: {price:#####.#}");




