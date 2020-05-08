using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Data.SqlTypes;

public class Clicking : EventTrigger
{
    public bool turn = true;
    public bool canBePlayed = false;

    GameObject startButton;
    public override void OnPointerDown(PointerEventData data)
    {

        GameObject movedArea = GameObject.Find("DrawnPile");
        GameObject card = data.pointerCurrentRaycast.gameObject;
        data.pointerCurrentRaycast.gameObject.transform.SetParent(movedArea.transform, false);

    }
} 