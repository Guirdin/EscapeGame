using UnityEngine;
using UnityEngine.EventSystems;

public class OpenPDF : MonoBehaviour, IPointerDownHandler
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
        Application.OpenURL(System.Environment.CurrentDirectory + "/Documents/1.pdf");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OpenPDFs();
    }
}
