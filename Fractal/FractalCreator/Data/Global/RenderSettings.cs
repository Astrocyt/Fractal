using System;
using System.Threading;

namespace FractalCreator.Data.Global
{
    public sealed class RenderSettings
    {
        public static ThreadPriority ThreadsPriority {get;set;}
        public static int NumberOfThreads {get; set;}

        static RenderSettings()
        {
            ThreadsPriority = ThreadPriority.Normal;
            NumberOfThreads = Environment.ProcessorCount;
        }
    }
}
