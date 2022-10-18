using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;

    public GameObject startMenu;
    public InputField usernameField;
    public Text text;
    public Text text1;
    public Image imagen;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        startMenu.SetActive(false);
        imagen.gameObject.SetActive(false);
        usernameField.interactable = false;
        text.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);


        Client.instance.ConnectToServer();
    }
}
