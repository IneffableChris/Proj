using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PinEnter : MonoBehaviour
{

    public string pinInput = "";

    public void EnteredPin(int numberPressed)
    {
        pinInput = string.Concat(numberPressed.ToString());
        Debug.Log(pinInput);
        if(pinInput.Length == 4)
        {
            Validation();
        }
    }

    public void Validation()
    {
        if (int.Parse(pinInput) == 1234)
        {
            Debug.Log("Drinnen");
        }
        else
        {
            Debug.Log("Falsche Pin");
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
