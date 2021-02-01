using UnityEngine;
using UnityEngine.EventSystems;

public class CloseGame : MonoBehaviour, IPointerDownHandler
{

    public void OnPointerDown(PointerEventData eventData)
    {
        Application.Quit();
    }
}