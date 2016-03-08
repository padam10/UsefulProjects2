using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerScriptDemo
{
    using System.IO;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;

    class Program
    {
        static void Main(string[] args)
        {
            var runspaceConfiguration = RunspaceConfiguration.Create();
            var runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration);
            runspace.Open();
            var scriptInvoker = new RunspaceInvoke(runspace);

            var pipeline = runspace.CreatePipeline();

             string path = Directory.GetCurrentDirectory();
            var scriptFilePath = Path.Combine(path, "FindInFiles.ps1");

            if (!File.Exists(scriptFilePath))
            {
                Console.WriteLine("File '{0}' does not exit", scriptFilePath);
                return;
            }

            pipeline.Commands.Add(scriptFilePath);

            // Execute PowerShell script
            pipeline.Invoke();
        }
    }
}
