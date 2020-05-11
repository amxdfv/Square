using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public GameObject PC;

    public void Start()
    {
       
    }


        public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void RulesPressed()
    {
        GameObject PC = GameObject.Find("RulesTxt");
        PC.transform.position = new Vector3(700,50);
        
    }

    public void ExitMenuPressed()
    {
        GameObject PC = GameObject.Find("RulesTxt");
        PC.transform.position = new Vector3(-1500, -100);
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
