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

    private string newUsername;
    private int newPincode;
    private int newPincodeConfirm;
    private bool newUsertype;
    private bool newGender;
    private int newAvatarID;

    //Mehr Variablen
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool SaveUser()
    {  
        
    

        if (pincode != newPincode && newPincode == newPincodeConfirm)
        {
            pincode = newPincode;
        }
        else
        {
            //Fehler: Der selbe Pincode darf nicht nochmal genommen werden oder die neuen Pincodes stimmen nicht überein
        }
        username = newUsername;
        usertype = newUsertype;
        gender = newGender;
        avatarID = newAvatarID;

        //schreibe auf lokales System

        return false;
    }
}
