using System.Security.Cryptography.X509Certificates;

namespace Deligates
{
    internal class ArrayDeligates
    {
        delegate void DelOP(int x, int y);
        
        public static void SingleCastDelegate()
        {
            DelOP[] op =
            {
                new DelOP(Operation.Add),
                new DelOP(Operation.Sub)
            };
        for(int i = 0; i < op.Length; i++)
            {
                op[i](1, 2);
                op[i](3, 4);
                op[i](6, 2);
            }
        }      
        public static void MultiCastDelegate()
        {
            DelOP op = Operation.Add;
            op += Operation.Sub;
            op(3, 4);
            op(6, 2);
        }
    }
}