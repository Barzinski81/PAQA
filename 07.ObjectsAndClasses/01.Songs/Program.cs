namespace _01.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songsList = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                Song song = new Song();

                song.TypeList = data[0];
                song.Name = data[1];
                song.Time = data[2];

                songsList.Add(song);

            }

            string inputTypeList = Console.ReadLine();

            if (inputTypeList == "all")
            {
                foreach (var item in songsList)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in songsList.Where(s => s.TypeList == inputTypeList))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

    public class Song
    {

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
