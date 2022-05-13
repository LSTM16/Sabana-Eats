using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UILogin : MonoBehaviour
{
    public TMPro.TMP_Text userText;
    public TMPro.TMP_Text passUser;
    public string[] userApp;
    public string[] passwords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loginUser() {
        int i = 0;
        while (i < userApp.Length) {
            if (userApp.ToString() == userText.text.ToString())
            {
                while (i < passwords.Length)
                {
                    if (passwords.ToString() == passUser.text.ToString())
                    {

                    }
                    
                    }
                }
            }
        }
    }
