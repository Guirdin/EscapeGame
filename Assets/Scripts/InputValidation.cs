using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InputValidation : MonoBehaviour, IPointerDownHandler
{
    public InputField  Field;
    public Text textField;
    public Text popupText;
    public GameObject textPopup;
    
    public GameObject instructions;
    public GameObject enigme1;
    public GameObject informationsButton1;
    public GameObject enigme2;
    public GameObject informationsButton2;
    public GameObject enigme3;
    public GameObject informationsButton3;
    public GameObject textInputField;
    public GameObject validateButton;
    public GameObject timer;
    public GameObject victory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        ValidateField();
    }
    
    public void DisableText()
    { 
        popupText.enabled = false; 
    }    

    public void ValidateField()
    {
        if (textField.text == "Pyramid Test")
        {
            instructions.SetActive(false);
            enigme1.SetActive(false);
            informationsButton1.SetActive(false);
            enigme2.SetActive(false);
            informationsButton2.SetActive(false);
            enigme3.SetActive(false);
            informationsButton3.SetActive(false);
            textInputField.SetActive(false);
            validateButton.SetActive(false);
            timer.SetActive(false);
            victory.SetActive(true);
        }
        
        else
        {
            popupText.enabled = true; 
            textPopup.SetActive(true);
            Invoke("DisableText", 3f);
        }
    }
    
 
    
}
