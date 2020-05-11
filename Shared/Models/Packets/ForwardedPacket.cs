﻿using System;
using static TournamentAssistantShared.Packet;

namespace TournamentAssistantShared.Models.Packets
{
    [Serializable]
    public class ForwardingPacket
    {
        public string[] ForwardTo { get; set; }
        public PacketType Type { get; set; }
        public object SpecificPacket { get; set; }
    }
}
