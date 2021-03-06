﻿namespace SoundFingerprinting.Data
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class HashedFingerprint 
    {
        public HashedFingerprint(long[] hashBins, uint sequenceNumber, float startsAt, IEnumerable<string> clusters)
        {
            HashBins = hashBins;
            SequenceNumber = sequenceNumber;
            StartsAt = startsAt;
            Clusters = clusters;
        }

        public long[] HashBins { get; }

        public uint SequenceNumber { get; }

        public float StartsAt { get; }

        public IEnumerable<string> Clusters { get; }
    }
}
