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

            lang = "js";
            lang = "cs";

            return lang;
        }

        public static string FunctionName(string[] command)
        {
            string func = "";

            if(command[0].ToLower() == "gmail")
            {
                if(command[1].ToLower() == "search") func = "GmailSearch";
                if(c)
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

            return param;
        }
    }

}


