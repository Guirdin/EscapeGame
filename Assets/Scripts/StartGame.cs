using UnityEngine;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour, IPointerDownHandler
{
    public GameObject startButton;
    public GameObject informationsButton1;
    public GameObject informationsButton2;
    public GameObject informationsButton3;
    
    public void StartGames()
    {
        startButton.SetActive(false);
        informationsButton1.SetActive(true);
        informationsButton2.SetActive(true);
        informationsButton3.SetActive(true);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        StartGames();
    }
}
