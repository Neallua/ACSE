﻿namespace System
{
    public static class ArrayExtensions
    {
        public static T[] Copy<T>(this T[] sourceArray)
        {
            T[] destinationArray = new T[sourceArray.Length];
            Array.Copy(sourceArray, destinationArray, sourceArray.Length);
            return destinationArray;
        }
    }
}
