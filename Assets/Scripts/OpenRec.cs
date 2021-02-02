using UnityEngine;
using UnityEngine.EventSystems;

public class OpenRec : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OpenRecording() {
        Application.OpenURL(System.Environment.CurrentDirectory + "/Documents/3.mp3");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OpenRecording();
    }
}