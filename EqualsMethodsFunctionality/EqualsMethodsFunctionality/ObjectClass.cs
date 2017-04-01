using System;

namespace EqualsMethodsFunctionality
{
    static class ObjectClass
    {
        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="objectA"></param>
        /// <param name="objectB"></param>
        /// <returns>Returns a boolean if the passed object objectB is equal to this otherwise false.</returns>
        public static bool EqualsVirtual(this Object objectA, Object objectB)
        {
            if (objectA.GetType() != typeof(object))
            {
                return objectA.Equals(objectB);
            }
            else if (objectA == null)
            {
                throw new NullReferenceException();
            }
            else if (objectA == objectB)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether the specified object instances are considered equal.
        /// </summary>
        /// <param name="objectA"></param>
        /// <param name="objectB"></param>
        /// <returns>true if the objects are considered equal; otherwise, false. If both objA and objB are null, the method returns true.</returns>
        public static bool EqualsStatic(Object objectA, Object objectB)
        {
            if (objectA == objectB)
            {
                return true;
            }
            if (objectA == null || objectB == null)
            {
                return false;
            }
            return objectA.EqualsVirtual(objectB);
        }

        /// <summary>
        /// Determines whether the specified Object instances are the same instance.
        /// </summary>
        /// <param name="objectA"></param>
        /// <param name="objectB"></param>
        /// <returns>true if objectA is the same instance as objectB or if both are null; otherwise, false.</returns>
        public static bool EqualsReference(Object objectA, Object objectB)
        {
            return objectA == objectB;
        }
    }
}
