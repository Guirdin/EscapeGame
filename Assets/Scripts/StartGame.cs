using UnityEngine;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour, IPointerDownHandler
{
    public GameObject logo;
    public GameObject startButton;
    public GameObject introText;
    public GameObject instructions;
    public GameObject enigme1;
    public GameObject informationsButton1;
    public GameObject help;
    public GameObject textInputField;
    public GameObject validateButton;
    public GameObject timer;

    public void StartGames()
    {
        logo.SetActive(false);
        startButton.SetActive(false);
        introText.SetActive(false);
        instructions.SetActive(true);
        enigme1.SetActive(true);
        informationsButton1.SetActive(true);
        help.SetActive(true);
        textInputField.SetActive(true);
        validateButton.SetActive(true);
        timer.SetActive(true);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        StartGames();
    }
}
