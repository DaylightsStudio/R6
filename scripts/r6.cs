using System;
using System.Net.Http;
using System.Threading.Tasks;

public class CPHInline
{
    public bool Execute()
    {
        // OPERATEURS ATTAQUE
        string operateursListe = GetStringAsync("https://raw.githubusercontent.com/DaylightsStudio/R6/main/operateurs/attaque.txt").Result;

        // OPERATEURS DEFENSE
        // string operateursListe = GetStringAsync("https://raw.githubusercontent.com/DaylightsStudio/R6/main/operateurs/defense.txt").Result;

        string[] ops = operateursListe.Split('\n');

        string operateur = args["rawInput"].ToString().ToLower(); // on prend le input de l'utilisateur et le transforme en minuscules
        string username = args["userName"].ToString().ToLower(); // nom d'utilisateur en minuscules
        string[] bob = { "daylightsstudio", "adaoh" }; // pseudos de ceux qui peuvent utiliser bob

        for (int i = 0; i < ops.Length; i++)
        {
            if (operateur == "bob")
            {
                if (username == bob[i])
                {
                    CPH.RunAction("Ops att animation", true);
                    return true;
                }
                else
                {
                    CPH.RunAction("Ops att wrong redeem", true);
                    return false;
                }
            }
            else
            {
                if (ops[i] == operateur)
                {
                    // l'opérateur est trouvé dans la liste, on passe à l'action suivante
                    CPH.RunAction("Ops att animation", true);
                    return true;
                }
            }
        }

        // l'opérateur n'a pas pu être trouvé dans la liste
        CPH.RunAction("Ops att wrong redeem", true);
        return false;
    }
	
    private static readonly HttpClient client = new HttpClient();

    private static async Task<string> GetStringAsync(string uri)
    {
        using (var client = new HttpClient())
        {
            return await client.GetStringAsync(uri);
        }
    }
}
