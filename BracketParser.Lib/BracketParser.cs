using System.Collections;

namespace BracketParser.Lib
{
    public class BracketParser
    {
        /// <summary>
        /// HasMatchingBrackets - checks if all opening brackets in checkMe have a matching closing bracket
        /// </summary>
        /// <param name="checkMe"></param>
        /// <returns>bool</returns>
        public bool HasMatchingBrackets(string checkMe)
        {
            Stack stack = new Stack();
            const char startBracket = '{';
            const char endBracket = '}';

            // Guard clause: Auto fail if first char is '}'
            if (checkMe.Length > 0 && checkMe[0] == endBracket)
                return false;

            foreach (char c in checkMe)
            {
                if (c == startBracket) // Is it the startBracket?
                {
                    // Yes
                    stack.Push("looking for end bracket");
                }
                else if (c == endBracket) // Is it the endBracket?
                {
                    // Yes
                    stack.Pop();
                }
            }

            // If the stack is empty, the string has all matching brackets.
            return stack.Count == 0;
        }
    }
}
