namespace MyProject
{
    //Найти НОД методом Евклида (алгоритм Евклида). Использовать рекурсивную процедуру. Для чисел 3430 и 1365:

    class GcdByEuclideanAlgorithmWithRecursion
    {
        private int result,
            modulo;

        public int GetGcd(int firstNumb, int secondNumb)
        {
            if (firstNumb > secondNumb)
            {
                modulo = firstNumb % secondNumb;
            }
            else
            {
                modulo = secondNumb % firstNumb;
            }


            while (modulo >= 0)
            {
                if (modulo == 0)
                {
                    result = secondNumb;
                    break;
                }

                firstNumb = secondNumb;
                secondNumb = modulo;
                result = this.GetGcd(firstNumb, secondNumb);

            }

            return result;
        }
    }
}
