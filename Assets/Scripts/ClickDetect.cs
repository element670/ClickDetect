using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClickDetect : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Transform parentAfterDrag;
    private Vector3 direction;
    private void Start()
    {
        transform.localScale = Vector3.one;

        transform.position = new Vector3(transform.position.x, transform.position.y, 0) ;
    }
    public void OnPointerClick(PointerEventData eventdata)
    {
        print(name + " was clicked");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        parentAfterDrag = transform.parent;
        //transform.SetParent(transform.root);
        //transform.SetAsLastSibling();
        transform.SetParent(transform.root.transform, false);
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        //transform.position = Input.mousePosition;
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }

    public void OnEndDrag(PointerEventData eventData) 
    {
        Debug.Log("End drag");
    }

    

    
}
