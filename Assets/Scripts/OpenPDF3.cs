using UnityEngine;
using UnityEngine.EventSystems;

public class OpenPDF3 : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OpenPDFs() {
        Application.OpenURL(System.Environment.CurrentDirectory + "/3.pdf");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OpenPDFs();
    }
}