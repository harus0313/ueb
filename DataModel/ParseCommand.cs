namespace ueBoot.DataMode
{
    public class ParseCommand
    {
        public static string[] Parse(string commandString)
        {
            string[] commandArray = commandString.Split(" ");

            for(int i = 0; i < commandArray.Length; i++)
            {
                Console.WriteLine(commandArray[i]);
            }

            return commandArray;

        }

        public static string FuncLanguage(string[] command)
        {
            string lang = "";
            if(command[0].ToLower() == "gmail")
            {
                if(command[1].ToLower() == "search") lang = "js";
                if(command[1].ToLower() == "new") lang = "js";
            }
            else if(command[0].ToLower() == "twitter")
            {
                if(command[1].ToLower() == "new") lang = "js";
            }
            else if(command[0].ToLower() == "rakuten")
            {
                if(command[1].ToLower() == "search") lang = "js";
            }

            return lang;
        }

        public static string FunctionName(string[] command)
        {
            string func = "";

            if(command[0].ToLower() == "gmail")
            {
                if(command[1].ToLower() == "search") func = "GmailSearch";
                if(command[1].ToLower() == "new") func = "GmailNew";
            }
            else if(command[0].ToLower() == "twitter")
            {
                if(command[1].ToLower() == "new") func = "TwitterNew";
            }
            else if(command[0].ToLower() == "rakuten")
            {
                if(command[1].ToLower() == "search") func = "RakutenSearch";
            }
            
            return func;
        }

        public static string FunctionParameter(string[] command)
        {
            string param = "";

            if(command[0].ToLower() == "gmail")
            {
                if(command[1].ToLower() == "search") param = command[2];
            }
            else
            {
                if(command[0].ToLower() == "rakuten")
                {
                    if(command[1].ToLower() == "search") param = command[2];
                }
            }

            return param;
        }
    }

}


