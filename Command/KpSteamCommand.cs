using System.Threading.Tasks;
using KP_Steam_Uploader.Command.Download;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;

namespace KP_Steam_Uploader.Command
{
    [Command(
        Name = "kpsteam",
        ThrowOnUnexpectedArgument = false,
        OptionsComparison = System.StringComparison.InvariantCultureIgnoreCase)]
    [Subcommand(
        typeof(DownloadCommand))]
    public class KpSteamCommand: AbstractKpSteamCommand
    {

        public KpSteamCommand(ILogger<KpSteamCommand> logger, IConsole console)
        {
            Logger = logger;
            Console = console;
        }

        protected override Task<int> OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();

            return Task.FromResult(0);
        }
    }
}