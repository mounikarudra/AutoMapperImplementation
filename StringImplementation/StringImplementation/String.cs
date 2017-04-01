using System.Linq;
using System.Text;

namespace StringImplementation
{
    public sealed class String
    {
        private readonly char[] _charArray;
        private readonly int m_stringLength;
        private static readonly String Empty = "";

        public char this[int index]
        {
            get
            {
                return _charArray[index];
            }
            set
            {
                _charArray[index] = value;
            }
        }
        public String(char[] value)
        {
            _charArray = value;
            m_stringLength = _charArray.Length;
        }
        public String(char c, int count)
        {
            _charArray = new char[count];
            for (int i = 0; i < count; i++)
            {
                _charArray[i] = c;
            }

        }
        public String(char c, int startIndex, int length)
        {

        }
        /// <summary>
        /// gets the length of String.
        /// </summary>
        public int Length
        {
            get { return m_stringLength; }
        }
        public static implicit operator String(string v)
        {
            return new String(v.ToArray());
        }
        public static String operator +(String str0, String str1)
        {
            String temp = new String(' ', str0.Length + str1.Length);
            for (int i = 0; i < str0.Length; i++)
            {
                temp[i] = str0[i];
            }

            for (int i = str0.Length, j = 0; i < str0.Length + str1.Length && j < str1.Length; i++, j++)
            {
                temp[i] = str1[j];
            }
            return temp;
        }
        public override string ToString()
        {
            StringBuilder tempStr = new StringBuilder();
            foreach (char ch in _charArray)
            {
                tempStr.Append(ch);
            }
            return tempStr.ToString();
        }
        /// <summary>
        /// Concates the given string values.
        /// </summary>
        /// <param name="str0"></param>
        /// <param name="str1"></param>
        /// <returns></returns>
        public static String Concat(String str0, String str1)
        {
            if (IsNullOrEmpty(str0))
            {
                if (IsNullOrEmpty(str1))
                {
                    return Empty;
                }
                return str1;
            }

            if (IsNullOrEmpty(str1))
            {
                return str0;
            }
            return str0 + str1;

        }
        /// <summary>
        /// Checks if the String is null or empty.
        /// </summary>
        /// <param name="str0"></param>
        /// <returns></returns>
        private static bool IsNullOrEmpty(String str0)
        {
            if (str0 == null || str0 == Empty)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Compares the given strings.
        /// </summary>
        /// <param name="str0"></param>
        /// <param name="str1"></param>
        /// <returns> True if the values are equal else false.</returns>
        public static bool Compare(String str0, String str1)
        {
            if (IsNullOrEmpty(str0) || IsNullOrEmpty(str1) || str0.Length != str1.Length)
            {
                return false;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (str0[i] != str1[i])
                {
                    return false;
                }
            }
            return true;

        }
        

    }
}
