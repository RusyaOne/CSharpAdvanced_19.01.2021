﻿namespace MultipleUsagesOfCode.Examples
{
    public class SnapshotCreator<T> where T: IResource
    {
        public Snapshot<T> CreateSnapshot(T resource)
        {
            return new Snapshot<T>(resource);
        }
    }
}