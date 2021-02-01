using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Validation2 : MonoBehaviour, IPointerDownHandler
{
    public InputField  Field;
    public Text textField;
    public Text popupText;
    public GameObject textPopup;
    
    public GameObject enigme2;
    public GameObject informationsButton2;
    public GameObject enigme3;
    public GameObject informationsButton3;
    public GameObject textInputField2;
    public GameObject validateButton2;
    public GameObject textInputField3;
    public GameObject validateButton3;

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
        if (textField.text == "107 104 195 169 111 112 115")
        {
            enigme2.SetActive(false);
            informationsButton2.SetActive(false);
            enigme3.SetActive(true);
            informationsButton3.SetActive(true);
            textInputField2.SetActive(false);
            validateButton2.SetActive(false);
            textInputField3.SetActive(true);
            validateButton3.SetActive(true);
        }
        
        else
        {
            popupText.enabled = true; 
            textPopup.SetActive(true);
            Invoke("DisableText", 3f);
        }
    }
    
 
    
}