using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Camera _cam;
    protected Vector2 _originalPositon;
    protected bool _dragging;
    [SerializeField] private GameObject _dropArea;
    [SerializeField] private GameObject _handArea;

    private void Awake()
    {
        _originalPositon = _handArea.transform.position;
        _cam = Camera.main;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
        _dragging = true;
    }

    private void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, _dropArea.transform.position) < 2)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position = _originalPositon;
            _dragging = false;
        }
    }


    Vector3 GetMousePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    

}
