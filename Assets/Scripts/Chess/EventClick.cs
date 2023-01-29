using UnityEngine;
using UnityEngine.EventSystems;
public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
   // private MaterialApplier materialApplier;
    private void Awake()
    {
       // materialApplier = GetComponent<MaterialApplier>();
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        //
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
       //
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        //empty
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        //empty
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        //empty
    }
}
