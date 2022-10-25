namespace Part_A
{
    public static class Helper
    {
        public static int ReturnFifthElement(LinkedList<int> linkedList)
        {
            int result;
            if (linkedList == null || linkedList.Count < 5)
            {
                throw new Exception("Invalid LinkedList.");
            }
            var count = 1;
            var elementPosition = linkedList.Count - 4;
            var listNode = linkedList.First;
            do
            {
                if (listNode != null)
                {
                    result = listNode.Value;
                }
                else
                {
                    throw new Exception("Invalid LinkedList. Null value found.");
                }
                listNode = listNode.Next;
                count++;
            } while (count <= elementPosition);
            return result;
        }

        public static string ReverseWords(string value)
        {
            var result = "";
            if (string.IsNullOrEmpty(value))
            {
                return result;
            }
            var word = "";
            foreach (char c in value)
            {
                if (c == ' ')
                {
                    for (int i = word.Length -1; i > -1; i--)
                    {
                        result += word[i];
                    }
                    result += ' ';
                    word = "";
                }
                else
                {
                    word += c;
                }
            }
            if(word.Length > 0)
            {
                for (int i = word.Length - 1; i > -1; i--)
                {
                    result += word[i];
                }
            }
            return result;
        }
    }
}