﻿namespace Samples.MultiFileSender.Dependencies
{
    public interface IRecognizer
    {
        bool TryRecognize(File file, out Document document);
    }
}