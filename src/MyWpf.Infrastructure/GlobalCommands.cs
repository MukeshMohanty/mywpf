using System;
using Prism.Commands;

namespace MyWpf.Infrastructure
{
    public static class GlobalCommands
    {
        public static CompositeCommand SaveAllCommand = new CompositeCommand();
        public static CompositeCommand NavigateCommand = new CompositeCommand();
    }
}