using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Abraham
{
    class Desk
    {
        private const int MinWidth = 24;
        private const int MaxWidth = 96;
        private const int MinDepth = 12;
        private const int MaxDepth = 48;

        public int minWidth { get {return MinWidth; } }
        public int maxWidth { get { return MaxWidth; } }
        public int minDepth { get { return MinDepth; } }
        public int maxDepth { get { return MaxDepth; } }
    }

    // Create enumerated type named DesktopMaterial

    public enum DesktopMaterial
    {
        oak = 200,
        laminate = 100,
        pine = 50,
        rosewood = 300,
        veneer = 125
    }
}
