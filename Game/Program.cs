using System;

namespace DirectX
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TRexRunnerGame())
                game.Run();
        }
    }
}
