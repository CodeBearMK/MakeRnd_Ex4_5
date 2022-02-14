namespace MakeRnd_Ex4_5
{
    class Programn
    {
        static void Main(string[] args)
        {
            int min = 10, max = 20, rnd_num = 7;
            int[] range = new int[max - min + 1];
            MakeRnd Rnd = new MakeRnd();
            Rnd.GetRnd(range, min, max, rnd_num);
            for (int i = 0; i < rnd_num; i++)
            {
                Console.WriteLine("第{0}個亂數: {1}", i + 1, range[i]);
            }
            Console.Read();
        }
    }
}