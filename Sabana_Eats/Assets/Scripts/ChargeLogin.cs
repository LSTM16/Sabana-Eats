using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeLogin : MonoBehaviour
{
    public int panelCharge;
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
        PlayerPrefs.SetInt("panelCharge", 0);
        SceneManager.LoadScene("LoginUser", LoadSceneMode.Single);

    }

    public void ChargeRegisterUser()
    {
        PlayerPrefs.SetInt("panelCharge", 1);
        SceneManager.LoadScene("Registrarse", LoadSceneMode.Single);
    }
}
