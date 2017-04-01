using System;
using System.ComponentModel;

namespace IsAndAsFunctionality
{
    class IsAndAsFunctionality
    {
        /// <summary>
        /// checks if the object passed to it of the specified type.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsFunctionality(object obj, Type type)
        {
            Type typeTemp = obj.GetType();
            Type current = typeTemp.BaseType;
            if (type.Equals(typeTemp))
            {
                return true;
            }
            while (current != null)
            {
                if (current.Equals(type))
                {
                    return true;
                }
                current = current.BaseType;
            }
            return false;
        }

        /// <summary>
        /// converts the object passed to the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public T AsFunctionality<T>(object obj, Type type)
        {
            if (obj == null)
            {
                return default(T);
            }
            bool flag = IsFunctionality(obj, type);
            if (flag)
            {
                return (T)obj;
            }
            return default(T);
        }
    }
}
