using System.Text;

namespace _03.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] splitInput = input.Split();

                int serial = int.Parse(splitInput[0]);
                string name = splitInput[1];
                int quantity = int.Parse(splitInput[2]);
                double price = double.Parse(splitInput[3]);

                Item currentItem = new Item(name, price);
                Box currentBox = new Box(serial, currentItem, quantity);

                boxes.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var item in boxes.OrderByDescending(b => b.Price))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(item.SerialNumber.ToString());
                sb.AppendLine($"-- {item.Item.Name} - ${item.Item.Price:F2}: {item.Quantity}");
                sb.AppendLine($"-- ${item.Price:F2}");

                Console.WriteLine(sb.ToString().TrimEnd());
            }
        }
    }

    public class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public Box(int serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double Price => Quantity * Item.Price;
    }

}
