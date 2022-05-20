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
    public TMPro.TMP_InputField userRegisterText;
    public TMPro.TMP_InputField passRegisterUser;
    public string[] userApp;
    public string[] passwords;
    public GameObject[] paneles;
    public int condicion;
    
    // Start is called before the first frame update
    void Start()
    {
        condicion = PlayerPrefs.GetInt("panelCharge");

        if(condicion==0)
        {
            paneles[0].SetActive(true);
            paneles[1].SetActive(false);
        }
        else if (condicion == 1)
            {
                paneles[0].SetActive(false);
                paneles[1].SetActive(true);
            }
        userText.text = "";
        passUser.text = "";
        userRegisterText.text = "";
        passRegisterUser.text = "";
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
                        SceneManager.LoadScene("Menu Principal", LoadSceneMode.Single);
                    }else
                    {
                    }

                }
            }
            }
        
        
            }
    }
