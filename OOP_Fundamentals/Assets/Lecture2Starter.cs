using UnityEngine;

namespace Lecture1
{
	
}	

public class Lecture2Starter : MonoBehaviour {

	Rectangle myRect;

	void Start()
	{
		myRect = new Rectangle ();
		Shape shape = new Shape ();

		Debug.Log(area);
	}
		


public class Shape
{
	public int width;
	public int height;

	public Shape()
	{
		width = 5;
		height =5;
	}

}	

public class Rectangle : Shape
{
	public int area;

	public Rectangle()
	{
		area = width * height;
	}
}
}