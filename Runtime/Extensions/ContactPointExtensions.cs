using System.Collections.Generic;
using UnityEngine;

namespace Extensions
{
    public static class ContactPointExtensions
    {
        /// <summary>
        /// Returns the average point of a ICollection ContactPoint
        /// </summary>
        /// <param name="input">the input as list or array</param>
        /// <returns>Vector3</returns>
        public static Vector3 AveragePoint(this ICollection<ContactPoint> input)
        {
            var average = Vector3.zero;
            foreach (var vector in input)
            {
                average += vector.point;
            }
            return new Vector3(average.x / input.Count, average.y / input.Count, average.z / input.Count);
        }
    }
}
