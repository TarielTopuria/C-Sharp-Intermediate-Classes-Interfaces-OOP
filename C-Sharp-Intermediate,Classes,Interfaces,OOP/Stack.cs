namespace C_Sharp_Intermediate_Classes_Interfaces_OOP
{
    public class Stack
    {
        private readonly List<object> stack = new();
        public void Push(object obj)
        {

            if (obj != null)
            {
                stack.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("You can't add a null object to the stack.");
            }
        }

        public object Pop()
        {
            if (stack.Count != 0)
            {
                var result = stack[^1];
                stack.RemoveAt(stack.Count - 1);
                return result;
            }
            else
            {
                throw new InvalidOperationException("There aren't elements in the stack.");
            }
        }

        public void Clear()
        {
            try
            {
                Clear();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
    }
}
