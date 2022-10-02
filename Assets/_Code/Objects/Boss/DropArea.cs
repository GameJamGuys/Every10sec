using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler
{
    //public DragDrop card;
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("Drop");
        if (eventData.pointerDrag != null)
        {
            BattleCard card = eventData.pointerDrag.GetComponent<BattleCard>();
            if (card.CanUse()) card.UseCard();
            //eventData.pointerDrag.GetComponent<BattleCard>().UseCard();
        }
    }
}
