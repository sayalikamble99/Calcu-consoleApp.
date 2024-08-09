namespace CalcConsoleApp
{
    public class MathCls
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public int MultiplicationUsingAddition(int num1, int num2)
        {
            int result = 0;
            for (int i = 0; i < num1; i++)
            {
                result += num2;
            }
            return result;
        }

        public int Substraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
