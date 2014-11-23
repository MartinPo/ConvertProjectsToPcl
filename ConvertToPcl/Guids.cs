// Guids.cs
// MUST match guids.h

using System;

namespace MLabs.ConvertToPcl
{
    public static class GuidList
    {
        public const string guidConvertToPclPkgString = "4c5b2b2f-17b1-4b85-aceb-f5e8865dc05b";
        public const string guidConvertToPclCmdSetString = "bbba49fb-2ebd-4110-a269-fc45a929fbb9";

        public static readonly Guid guidConvertToPclCmdSet = new Guid(guidConvertToPclCmdSetString);
    };
}