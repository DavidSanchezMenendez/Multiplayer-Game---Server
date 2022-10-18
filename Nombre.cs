using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nombre : MonoBehaviour
{
    public Text Name;
    PlayerManager player;
    // Start is called before the first frame update
    private void Start()
    {
        player = GetComponent<PlayerManager>();
        string name = player.username;
        player.transform.GetComponent<Nombre>().Nick(name);

    }
    public void Nick(string name)
    {
        
        Name.text = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
