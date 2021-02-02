using UnityEngine;
using UnityEngine.EventSystems;

public class OpenImage : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OpenHelpImg() {
        Application.OpenURL(System.Environment.CurrentDirectory + "/Documents/room.png");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OpenHelpImg();
    }
}