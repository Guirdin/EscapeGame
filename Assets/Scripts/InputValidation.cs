using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InputValidation : MonoBehaviour, IPointerDownHandler
{
    public InputField  textInputField;
    public Text textField;

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

    public void ValidateField()
    {
        if (textField.text == "Pyramid Test")
        {
            Debug.Log("Vous Avez Gagné!");
        }
        else
        {
            Debug.Log("Vous Avez Perdu!");
        }
    }
    
 
    
}
