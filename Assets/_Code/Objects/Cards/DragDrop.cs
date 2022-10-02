using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 originalPos;

    

    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        canvas = GetComponentInParent<CardHolder>().canvas;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("On Begin Drag");
        originalPos = rectTransform.anchoredPosition;
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerDrag != null)
        {
            rectTransform.anchoredPosition = originalPos;
        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("On Pointer");
    }

    public void OnDrop(PointerEventData eventData)
    {
        
    }
}
