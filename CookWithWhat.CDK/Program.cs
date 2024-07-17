using Amazon.CDK;

namespace CookWithWhat.CDK
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App();
            new CookWithWhatStack(app, "CookWithWhatStack");
            app.Synth();
        }
    }
}