using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler
{
    //public DragDrop card;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<DragDrop>().DeleteCard();
            //card.DeleteCard();
        }
    }
}
