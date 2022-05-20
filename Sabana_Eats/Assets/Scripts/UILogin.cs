using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UILogin : MonoBehaviour
{
    public TMPro.TMP_InputField userText;
    public TMPro.TMP_InputField passUser;
    public string[] userApp;
    public string[] passwords;
    // Start is called before the first frame update
    void Start()
    {
        userText.text = "";
        passUser.text = "";
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
