public class TutParameter
{
	public static readonly string SQUARE;

	public static readonly string CIRCLE;

	public TutAnchorObject anchorObject;

	public bool checkCollide;

	public bool clickAnyWhere;

	public int groupID;

	public int Height;

	public int id;

	public PointerShapeTye shape;

	public TutType type;

	public int width;

	public TutParameter(TutAnchorObject anchor, int width = 120, int height = 120, PointerShapeTye shape = PointerShapeTye.CIRCLE, bool checkCollide = true, bool clickAnyWhere = false)
	{
	}

	public TutParameter(int groupID, int id)
	{
	}
}
