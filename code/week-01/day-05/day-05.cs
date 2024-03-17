using System.Runtime.InteropServices;

namespace Socks
{
    public class SockPairs
    {
        public static int sockPairs(string socks)
        {
            Dictionary<char, int> socksFound = new Dictionary<char, int>();
            char[] eachSock = socks.ToCharArray();
            int numberOfSockPairs = 0;
            for (int i = 0; i < eachSock.Length; i++)
            {
                if (!socksFound.ContainsKey(eachSock[i]))
                {
                    socksFound.Add(eachSock[i], 1);
                }
                else
                {
                    socksFound[eachSock[i]] += 1;
                }
            }

            foreach (KeyValuePair<char, int> sockPair in socksFound)
            {
                numberOfSockPairs += sockPair.Value / 2;
            }
            return numberOfSockPairs;
        }
    }
}