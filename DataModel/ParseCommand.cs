namespace ueb.DataModel
{
    public class ParseCommand
    {

        public class CommandInfo
        {
            public string FunctionLanguage;
            public string FunctionName;
            public string Parameter;
        }

        public static string[] Parse(string commandString)
        {
            string[] commandArray = commandString.Split(" ");

            for(int i = 0; i < commandArray.Length; i++)
            {
                Console.WriteLine(commandArray[i]);
            }

            return commandArray;

        }

        public static CommandInfo GetCommandInfo(string command)
        {
            CommandInfo commandInfo = new CommandInfo();
            string[] commandArray = Parse(command);

            switch (commandArray[0].ToLower())
            {
                case "gmail":
                    switch (commandArray[1].ToLower())
                    {
                        case "search":
                            commandInfo.FunctionLanguage = "js";
                            commandInfo.FunctionName = "GmailSearch";
                            commandInfo.Parameter = commandArray[2];
                            break;
                        case "new":
                            commandInfo.FunctionLanguage = "js";
                            commandInfo.FunctionName = "GmailNew";
                            break;
                    }
                    break;
                case "twitter":
                    switch (commandArray[1].ToLower())
                    {
                        case "new":
                            commandInfo.FunctionLanguage = "js";
                            commandInfo.FunctionName = "TwitterNew";
                            break;
                    }
                    break;
                case "rakuten":
                    switch (commandArray[1].ToLower())
                    {
                        case "search":
                            commandInfo.FunctionLanguage = "js";
                            commandInfo.FunctionName = "RakutenSearch";
                            commandInfo.Parameter = commandArray[2];
                            break;
                    }
                    break;
                case "bootstrap":
                    switch (commandArray[1].ToLower())
                    {
                        case "docs":
                            commandInfo.FunctionLanguage = "js";
                            commandInfo.FunctionName = "BootstrapDocs";
                            break;
                    }
                    break;
                
            }

            return commandInfo;
        }

    }

}


