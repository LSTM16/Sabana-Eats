using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeLogin : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChargeLoginUser()
    {
        SceneManager.LoadScene("LoginUser", LoadSceneMode.Single);
    }

    public void ChargeRegisterUser()
    {
        SceneManager.LoadScene("Registrarse", LoadSceneMode.Single);
    }
}
