using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    bool MouDw = false;
    public GameObject PC;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MovePal();
    }

    void OnMouseOver()
    {
        Debug.Log("shit");
    }

    void OnMouseDown()
    {
        MouDw = true;
        Debug.Log(MouDw);
    }

    void OnMouseUp()
    {
        MouDw = false;
        Debug.Log(MouDw);
    }

    void MovePal()
    {
        GameObject PCI = GameObject.Find("PalImage");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PC.transform.position = new Vector3(PC.transform.position.x - 10, PC.transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PC.transform.position = new Vector3(PC.transform.position.x + 10, PC.transform.position.y);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PC.transform.position = new Vector3(PC.transform.position.x , PC.transform.position.y+10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            PC.transform.position = new Vector3(PC.transform.position.x, PC.transform.position.y - 10);
        }
        Debug.Log(PC.transform.position.x);
        Debug.Log(PC.transform.position.y);
       
    }

}
