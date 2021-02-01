using UnityEngine;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour, IPointerDownHandler
{
    public GameObject logo;
    public GameObject startButton;
    public GameObject introText;
    public GameObject informationsButton1;
    public GameObject informationsButton2;
    public GameObject informationsButton3;
    public GameObject textInputField;
    public GameObject validateButton;
    public GameObject timer;

    public void StartGames()
    {
        logo.SetActive(false);
        startButton.SetActive(false);
        introText.SetActive(false);
        informationsButton1.SetActive(true);
        informationsButton2.SetActive(true);
        informationsButton3.SetActive(true);
        textInputField.SetActive(true);
        validateButton.SetActive(true);
        timer.SetActive(true);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        StartGames();
    }
}
