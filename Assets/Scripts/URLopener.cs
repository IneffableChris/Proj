using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLopener : MonoBehaviour
{
    public void OpenWebsite(string URL)
    {
        Application.OpenURL(URL);
    }
}
