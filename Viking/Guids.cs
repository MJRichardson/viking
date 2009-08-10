// Guids.cs
// MUST match guids.h
using System;

namespace Company.Viking
{
    static class GuidList
    {
        public const string guidVikingPkgString = "000a554a-ca9a-44b9-ae2b-de75ff9d1e03";
        public const string guidVikingCmdSetString = "d40f99c9-f139-4b58-af75-15b14ca14185";

        public static readonly Guid guidVikingCmdSet = new Guid(guidVikingCmdSetString);
    };
}