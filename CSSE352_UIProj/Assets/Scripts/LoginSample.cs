using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginSample : MonoBehaviour
{
    public TMP_InputField Account;
    public TMP_InputField Password;
    // Start is called before the first frame update
    void Start()
    {
        Account = GameObject.Find("UserName").GetComponent<TMP_InputField>();
        Password = GameObject.Find("PassWord").GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    public void LoginInfo()
    {
        Debug.Log("UserName: " + Account.text);
        Debug.Log("PassWord: " + Password.text);
    }
}
