using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform camTransform;
    public Camera cam;
    public Transform debugHitPoint;
    Vector3 hookShootPosition;
    float hookshotSize;
    public Transform HookShotTransform;
    bool dejargancho = false;
    public Text Nombre;
    public GameObject Instanciar;
    AudioSource audio;
    public AudioClip Nigga;
    PlayerManager player;
    private void Start()
    {
        player = GetComponent<PlayerManager>();
        int id = player.id;
        player.transform.GetComponent<PlayerController>().Name(id);
        audio = GetComponent<AudioSource>();

    }
    public void Name(int id)
    {
        string nombre = id.ToString();
        Nombre.text = nombre;
    }
    private void Update()

    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ClientSend.PlayerShoot(camTransform.forward);
        }
        
        ClientSend.Gancho(camTransform.forward);

        SendInputToServer();

    }

    /// <summary>Sends player input to the server.</summary>
    private void SendInputToServer()
    {

        bool[] _inputs = new bool[]
        {
            Input.GetKey(KeyCode.W),
            Input.GetKey(KeyCode.S),
            Input.GetKey(KeyCode.A),
            Input.GetKey(KeyCode.D),
            Input.GetKey(KeyCode.Space),
            Input.GetKey(KeyCode.E),
            Input.GetKeyDown(KeyCode.N),
            Input.GetKeyDown(KeyCode.Mouse1)

        };

        ClientSend.PlayerMovement(_inputs);
        


       

    }
   
   
}