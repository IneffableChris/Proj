using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOverlays : MonoBehaviour
{
    public void MoveOverlayParentAccessToTop()
    {
        var overlayParentAccess = GameObject.Find("OverlayParentAccess").transform.Find("CategoryPanel").GetComponent<RectTransform>();
        var pos = overlayParentAccess.anchoredPosition;
        overlayParentAccess.anchoredPosition = new Vector2(pos.x, 480);
    }
}
