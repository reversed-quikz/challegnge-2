using UnityEngine;
using System.Collections;
//had help with this portion didnt understand how to get it to return then saw this online which made sense  ... pretty much detects when at second position and then sends it back and loops

public class MovementScript : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public bool atpos2 = true;
    public float speed = 0.3f;
    private Vector3 pos1spot;
    private Vector3 pos2spot;
    // Use this for initialization
    void Start()
    {
        pos1spot = new Vector3(pos1.position.x, 0, 0);
        pos2spot = new Vector3(pos2.position.x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thisPosition = new Vector3(transform.position.x, 0, 0);
        if (atpos2)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos2.position, speed);
            if (thisPosition.Equals(pos2spot))
            {
                //Debug.Log ("Position b");
                atpos2 = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pos1.position, speed);
            if (thisPosition.Equals(pos1spot))
            {
                //Debug.Log ("Position a");
                atpos2 = true;
            }
        }
    }

}
