using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Validation1 : MonoBehaviour, IPointerDownHandler
{
    public InputField  Field;
    public String playername;
    public Text textField;
    public Text popupText;
    public GameObject textPopup;
    
    public GameObject enigme1;
    public GameObject informationsButton1;
    public GameObject enigme2;
    public GameObject informationsButton2;
    public GameObject textInputField;
    public GameObject validateButton;
    public GameObject textInputField2;
    public GameObject validateButton2;

    // Start is called before the first frame update
    void Start()
    {
        Field.characterLimit = playername.Length;
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
        if (textField.text == "tabouret plumes bouche hibou plume main plume")
        {
            enigme1.SetActive(false);
            informationsButton1.SetActive(false);
            enigme2.SetActive(true);
            informationsButton2.SetActive(true);
            textInputField.SetActive(false);
            validateButton.SetActive(false);
            textInputField2.SetActive(true);
            validateButton2.SetActive(true);
        }
        
        else
        {
            popupText.enabled = true; 
            textPopup.SetActive(true);
            Invoke("DisableText", 3f);
        }
    }
}
