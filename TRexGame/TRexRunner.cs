using System;

namespace TRexGame
{
    public static class TRexRunner
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TRexRunnerGame())
                game.Run();
        }
    }
}
