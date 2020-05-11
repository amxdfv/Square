using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paint : MonoBehaviour {

   public  bool occupied; // показывает занята ли ячейка
    public GameObject PC;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject PC = GameObject.Find("PalImage");
        GameObject GS = GameObject.Find("GameSet");
        if (occupied == false) {
            this.GetComponent<Image>().color = PC.GetComponent<Image>().color;
            GS.GetComponent<NewTurn>().tcnt = GS.GetComponent<NewTurn>().tcnt + 1;
        }
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        GameObject PC = GameObject.Find("GameSet");

        if (occupied == false)
        {
            
            if (PC.GetComponent<NewTurn>().paint == false )
            {
              //  Debug.Log(PC.GetComponent<NewTurn>().paint);
                this.GetComponent<Image>().color = Color.white;
                PC.GetComponent<NewTurn>().tcnt = PC.GetComponent<NewTurn>().tcnt - 1;
            }
            else
            {
                occupied = true;
                PC.GetComponent<NewTurn>().tcnt = PC.GetComponent<NewTurn>().tcnt - 1;
            }
            
        }

    }

}
