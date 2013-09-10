using System;

namespace ReflectionsDemo
{
    public static class MyUtilities
    {
        public static string Format(Object obj, string seperator)
        {
            var t = obj.GetType();
            
            var propertyInfos = t.GetProperties();
            var result = string.Empty;
            foreach (var propertyInfo in propertyInfos)
            {
                result += propertyInfo.GetValue(obj, null) + seperator;
            }
            return result.Substring(0,result.Length-1);
        }
        public static string NameFormat(Object obj, string seperator)
        {
            var t = obj.GetType();

            var propertyInfos = t.GetProperties();
            var result = string.Empty;
            foreach (var propertyInfo in propertyInfos)
            {
                var displayName = propertyInfo.Name;

                object[] displayNameAttributes = propertyInfo.GetCustomAttributes(typeof (DisplayNameAttribute),false);
                if (displayNameAttributes.Length > 0)
                    displayName = ((DisplayNameAttribute) displayNameAttributes[0]).Name;

                result += displayName + "=" + propertyInfo.GetValue(obj, null) + seperator;
            }
            return result.Substring(0, result.Length - 1);
        }
    }
}