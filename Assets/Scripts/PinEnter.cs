using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PinEnter : MonoBehaviour
{


    public string pin;
    public void EnteredPin(int numberPressed)
    {
        Global.inputPin = Global.inputPin + numberPressed.ToString();
        Debug.Log(Global.inputPin);
        if(Global.inputPin.Length >= 4)
        {
            Validation();
            
        }
    }

    public void Validation()
    {
        if (int.Parse(Global.inputPin) == 1234)
        {
            Debug.Log("Drinnen");
            Global.inputPin = "";
            SceneManager.LoadScene(sceneName: "ParentStart");
        }
        else
        {
            Debug.Log("Falsche Pin");
            Global.inputPin = "";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
