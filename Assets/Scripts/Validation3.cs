using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Windows.WebCam;

public class Validation3 : MonoBehaviour, IPointerDownHandler
{
    public InputField  Field;
    public Text textField;
    public Text popupText;
    public GameObject textPopup;
    
    public GameObject instructions;
    public GameObject enigme3;
    public GameObject informationsButton3;
    public GameObject textInputField3;
    public GameObject validateButton3;
    public GameObject timer;
    public GameObject victory;
    public GameObject help;
    public GameObject recording;
    public GameObject restart;

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
        if (textField.text == "pharaon")
        {
            instructions.SetActive(false);
            enigme3.SetActive(false);
            informationsButton3.SetActive(false);
            textInputField3.SetActive(false);
            validateButton3.SetActive(false);
            timer.SetActive(false);
            victory.SetActive(true);
            help.SetActive(false);
            recording.SetActive(false);
            restart.SetActive(true);
        }
        
        else
        {
            popupText.enabled = true; 
            textPopup.SetActive(true);
            Invoke("DisableText", 3f);
        }
    }
    
 
    
}