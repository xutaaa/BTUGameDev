
using UnityEngine;

public class GameDev5 : MonoBehaviour {

    int a;
    float b = 0.653442f;
    bool c = true;
    string d = "some text";

    public Vector3 position;
    public Vector3 moveSpeed;
    public Vector3 ScaleSpeed;
    public Vector3 rotSpeed;
    public string newName;
    //public Transform otherTransform;
   
	
	void Start ()
    {
        //object starts at the position were it last was (transformed)
        //position = transform.position;
        //transform.name = "qurdebs sicocxle";
        //transform.name = newName;

       
	}
	

	void Update ()
    {
        //position = position + moveSpeed;

        transform.position = (transform.position + moveSpeed);

        if
            (transform.position.x >= 5f)
        {
            moveSpeed = moveSpeed * -1f;
        }
        else if 
            (transform.position.x <= -5f)
        {
            moveSpeed = moveSpeed * -1f;
        }
        //if (position.y < 10);
        //speed = -1;


        //Debug.Log(position + speed);

        //transform.localScale = (transform.localScale + ScaleSpeed);

        //transform.eulerAngles = (transform.eulerAngles + rotSpeed);

    
	}
}
