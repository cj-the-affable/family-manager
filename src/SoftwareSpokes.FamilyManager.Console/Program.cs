using System.CommandLine;

var command = new RootCommand("Admin tool for Family Management app.");
command.AddCommand(BuildGoogleCommand());
command.TreatUnmatchedTokensAsErrors = true;




Command BuildGoogleCommand()
{
    var command = new Command("google", "Manages google integration.");
    command.AddCommand(BuildGoogleCalendarCommand());
    
    return command;
}

Command BuildGoogleCalendarCommand()
{
    var command = new Command("calendar", "Manages google calendar integration.");
    command.AddCommand(BuildSubscribeToCalendarCommand());
    return command;
}

Command BuildSubscribeToCalendarCommand()
{
    var command = new Command("subscribe");
    var calendarOption = new Option<string>("calendar", "Subscribe to a calendar.")
    {
        Arity = ArgumentArity.ExactlyOne,
        IsRequired = true
    };

    command.AddOption(calendarOption);

    return command;
}