using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class LoginSample : MonoBehaviour
{
    public TMP_InputField Account;
    public TMP_InputField Password;
    public TMP_InputField Email
        ;
    // Start is called before the first frame update
    void Start()
    {
        Account = GameObject.Find("UserName").GetComponent<TMP_InputField>();
        Password = GameObject.Find("PassWord").GetComponent<TMP_InputField>();
        Email = GameObject.Find("Email").GetComponent<TMP_InputField>();
        Email.onValueChanged.AddListener(OnValidate);
        Email.onEndEdit.AddListener(Ended);
    }

    // Update is called once per frame
    public void LoginInfo()
    {
        Debug.Log("UserName: " + Account.text);
        Debug.Log("PassWord: " + Password.text);

    }



    public void OnValidate(string text)
    {

        Debug.Log("Typing right now");
    }
    public void Ended(string text)
    {
        Debug.Log("Typing is finished");
    }
}
