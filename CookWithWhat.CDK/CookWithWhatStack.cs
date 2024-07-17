using Amazon.CDK;
using Amazon.CDK.AWS.ECS;
using Amazon.CDK.AWS.ECR;
using Constructs;

namespace CookWithWhat.CDK
{
    public class CookWithWhatStack : Stack
    {
        public CookWithWhatStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // Define the publish command
            var publishCommand = "dotnet publish ../CookWithWhat.API/CookWithWhat.API.csproj --configuration Release --runtime linux-x64 --self-contained --output ./out";

            // Execute the publish command
            var exitCode = ExecuteCommand(publishCommand);
            if (exitCode != 0)
            {
                throw new Exception($"Publish command failed with exit code {exitCode}");
            }

            // Create an ECR repository
            var repository = new Repository(this, "CookWithWhatRepo");

            // Create an ECS cluster
            var cluster = new Cluster(this, "CookWithWhatCluster");

            // TODO: Add more resources as needed, such as ECS tasks, services, etc.
        }

        private int ExecuteCommand(string command)
        {
            var process = new System.Diagnostics.Process()
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{command}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            Console.WriteLine(result);
            return process.ExitCode;
        }
    }
}