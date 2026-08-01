namespace Assets.Scripts.Utils
{
	internal class Node
	{
		public int Weight { get; set; }

		public Card Value { get; set; }

		public int TotalWeight { get; set; }

		public Node(int weight, Card value, int totalWeight)
		{
		}
	}
}
