using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class user : MonoBehaviour
{
    public bool usertype;
    public bool gender;
    public string username;
    public int pincode;
    public int avatarID;
    public Input inputUsername;
    public Input inputPincode;
    public Input inputPincodeConfirm;

    

    //Mehr Variablen
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void getUsername(string newUsername)
    {
        //Check if username exists

        //if not:
        username = newUsername;
    }
    public void getPin(int newPincode, int newPincodeconfirm)
    {
        if(newPincode == newPincodeconfirm)
        {
            pincode = newPincode;
        }
        else
        {
            //Error: "Username existiert bereits"
        }
    }
    public void getGender(bool newGender)
    {
        gender =  newGender;
    }
    public void getType(bool newUsertype)
    {
        usertype = newUsertype;
    }

    
}
