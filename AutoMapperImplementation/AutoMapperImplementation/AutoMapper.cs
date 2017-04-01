using System;
using System.Reflection;

namespace AutoMapperImplementation
{
    class AutoMapper
    {
        public static FieldInfo _fieldInfoSource;
        public static PropertyInfo _propertyInfoSource;
        public static FieldInfo[] _fieldInfoDestination;
        public static PropertyInfo[] _propertyInfoDestination;

        /// <summary>
        /// Maps the source object to destination object.
        /// </summary>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source"></param>
        /// <returns>Destination object</returns>
        public static TDestination Map<TDestination>(object source)
        {
            _fieldInfoDestination = typeof(TDestination).GetFields();
            _propertyInfoDestination = typeof(TDestination).GetProperties();
            Type sourceType = source.GetType();
            object destination = Activator.CreateInstance(typeof(TDestination));
            Type destType = typeof(TDestination);

            // Maps the fields present in source to fields in destination.
            foreach (FieldInfo fieldInfoDest in _fieldInfoDestination)
            {
                if (sourceType.GetField(fieldInfoDest.Name) != null)
                {
                    _fieldInfoSource = sourceType.GetField(fieldInfoDest.Name);
                    fieldInfoDest.SetValue(destination, _fieldInfoSource.GetValue(source));
                }
            }

            // Maps properties present in source to properties in destination.
            foreach (PropertyInfo propertyInfodest in _propertyInfoDestination)
            {
                if (sourceType.GetProperty(propertyInfodest.Name) != null)
                {
                    _propertyInfoSource = sourceType.GetProperty(propertyInfodest.Name);
                    propertyInfodest.SetValue(destination, _propertyInfoSource.GetValue(source));
                }
            }

            // Maps properties present in source to fields in destination.
            foreach (FieldInfo fieldInfoDest in _fieldInfoDestination)
            {
                if (sourceType.GetProperty(fieldInfoDest.Name) != null)
                {
                    _propertyInfoSource = sourceType.GetProperty(fieldInfoDest.Name);
                    fieldInfoDest.SetValue(destination, _propertyInfoSource.GetValue(source));
                }
            }

            // Maps fields present in source to properties in destination.
            foreach (PropertyInfo propertyInfoDest in _propertyInfoDestination)
            {
                if (sourceType.GetField(propertyInfoDest.Name) != null)
                {
                    _fieldInfoSource = sourceType.GetField(propertyInfoDest.Name);
                    propertyInfoDest.SetValue(destination, _fieldInfoSource.GetValue(source));
                }
            }

            return (TDestination)destination;

        }
    }
}
