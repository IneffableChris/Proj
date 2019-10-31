using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addUser : MonoBehaviour
{
    public bool usertype;
    public bool sex;
    public string username;
    public int pincode;
    public int avatarID;
    //Mehr Variablen
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public addUser SaveUser(string newUsername, int newPincode, int newPincodeConfirme, bool newUsertype, bool newSex, int newAvatarID)
    {
        if (pincode != newPincode && newPincode == newPincodeConfirme)
        {
            pincode = newPincode;
        }
        else
        {
            //Fehler: Der selbe Pincode darf nicht nochmal genommen werden oder die neuen Pincodes stimmen nicht überein
        }
            
        username = newUsername;
        usertype = newUsertype;
        sex = newSex;
        avatarID = newAvatarID;

        //schreibe auf lokales System
        return 0;
    }




}
