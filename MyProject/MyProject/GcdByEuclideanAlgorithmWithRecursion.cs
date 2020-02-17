namespace MyProject
{
    //РЕКУРСИЯ
    //Найти НОД методом Евклида (алгоритм Евклида). Использовать рекурсивную процедуру. Для чисел 3430 и 1365:

    public class GcdByEuclideanAlgorithmWithRecursion
    {
        public int GetGcd(int firstNumb, int secondNumb)
        {
            int modulo;
            if (firstNumb > secondNumb)
            {
                modulo = firstNumb % secondNumb;
            }
            else
            {
                modulo = secondNumb % firstNumb;
            }

            if (modulo == 0)
            {
                return secondNumb;
            }

            firstNumb = secondNumb;
            secondNumb = modulo;
            return this.GetGcd(firstNumb, secondNumb);
        }
    }
}
