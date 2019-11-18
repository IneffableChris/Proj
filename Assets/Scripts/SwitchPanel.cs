using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{
    public GameObject PanelToOpen;
    public GameObject PanelToClose;

    public void OpenPanel()
    {
        if (PanelToOpen != null)
        {
            PanelToOpen.SetActive(true);
        }
    }
    public void ClosePanel()
    {
        if(PanelToClose != null)
        {
            PanelToClose.SetActive(false);
        }
    }
    public void ChangePanel()
    {
        if(PanelToClose != null && PanelToOpen != null)
        {
            PanelToClose.SetActive(false);
            PanelToOpen.SetActive(true);
        }
    }

}
