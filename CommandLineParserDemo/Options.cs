using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace CommandLineParserDemo
{
    using System.Globalization;

    public class Options
    {
        [Option('r', "read", Required = false,HelpText = "Input file to be processed.")]
        public string InputFile { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }



        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            try
            {
                if (CommandLine.Parser.Default.ParseArguments(args, options))
                {
                    string d = "-09/15/2015 10:00";
                    DateTimeOffset newdate = DateTimeOffset.Parse(d);
                    //var date = DateTimeOffset.TryParse(d, out newdate);
                    // Values are available here
                    if (options.Verbose) Console.WriteLine("Filename: {0}", options.InputFile);
                }
            }
            catch (FormatException fe)
            {

                Console.WriteLine("wrong date "+ fe.Message);
            }
            Console.Read();
        }
    }
}
