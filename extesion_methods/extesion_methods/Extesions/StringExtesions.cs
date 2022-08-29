
namespace System
{
    public static class StringExtesions
    {
        public static string Cut(this string thisObj, int size)
        {
            if (size == 0)
            {
                throw new ArgumentException("Tamanho não pode ser zero");
            }

            if (thisObj.Length <= size)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, size) + "...";
            }

        }
    }
}

