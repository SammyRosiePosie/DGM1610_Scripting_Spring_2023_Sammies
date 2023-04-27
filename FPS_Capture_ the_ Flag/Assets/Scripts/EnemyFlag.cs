using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlag : MonoBehaviour
{
    private GameManager gm;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
      gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Find GameManager and reference the GameManager component
      rend = GetComponent<Renderer>();
      rend.enabled = true;  
    }

    void OnTriggerEnter(Collider other)
    {
        gm.hasFlag = true; //Get Flag and set boll hasFlag to true
        rend.enabled = false; //Hide the flag
    }
}
