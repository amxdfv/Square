using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewTurn : MonoBehaviour {

   public  GameObject PC;
    public GameObject BUT;
    public bool enabled;
    public bool paint;
    int cnt;
   public int tcnt;
    // счет игроков
    int rcnt;
    int bcnt;
    bool redturn;
    private object MessageBox;

    void Start () {
        redturn = true;
        enabled = true;
        GameObject PC = GameObject.Find("PlayerCell");
        PC.transform.position = new Vector3(1100, 550);
        int x = Random.Range(1, 6);
        int y = Random.Range(1, 6);
        cnt = x * y;
        PC.transform.localScale = new Vector3(x, y);
        GameObject PCI = GameObject.Find("PalImage");
        if (PCI.GetComponent<Image>().color == Color.red)
        {
            PCI.GetComponent<Image>().color = Color.blue;
        }
        else
        {
            PCI.GetComponent<Image>().color = Color.red;
        }
        Debug.Log(PC.transform.position.x);
        Debug.Log(PC.transform.position.y);
    }
	
	// Update is called once per frame
	void Update () {
        if (tcnt == 0)
        {
            paint = false;
        }
        if (Input.GetKey(KeyCode.Return))
        {
            NewTurnPress();
        }



    }

    public void NewTurnPress()
    {
        GameObject BUT = GameObject.Find("GameSet");
        
        if (enabled == true)
        {
            if (tcnt == cnt) {
                PalCnt();
                paint = true;
                GameObject PC = GameObject.Find("PlayerCell");
                PC.transform.position = new Vector3(1100, 500);
                int x = Random.Range(1, 6);
                int y = Random.Range(1, 6);
                cnt = x * y;
                PC.transform.localScale = new Vector3(x, y);
                GameObject PCI = GameObject.Find("PalImage");
                if (PCI.GetComponent<Image>().color == Color.red)
                {
                    PCI.GetComponent<Image>().color = Color.blue;
                }
                else
                {
                    PCI.GetComponent<Image>().color = Color.red;
                }

            }          

        }
        
        
    }

    public void RotatePress()
    {
        if (Input.GetKey(KeyCode.Return) == false)
        {
            GameObject PC = GameObject.Find("PlayerCell");
            float xx = PC.transform.localScale.x;
            float yy = PC.transform.localScale.y;
            PC.transform.localScale = new Vector3(yy, xx);
        }
    }

    void PalCnt()
    {
        if (redturn == true)
        {
            rcnt = rcnt + tcnt;
            GameObject PC = GameObject.Find("RCount");
            PC.GetComponent<Text>().text = rcnt.ToString();
            redturn = false;
        }
        else
        {
            bcnt = bcnt + tcnt;
            GameObject PC = GameObject.Find("BCount");
            PC.GetComponent<Text>().text = bcnt.ToString();
            redturn = true;
        }
    }

   public void ExitMenuPress()
    {
        if (Input.GetKey(KeyCode.Return) == false)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    


}
