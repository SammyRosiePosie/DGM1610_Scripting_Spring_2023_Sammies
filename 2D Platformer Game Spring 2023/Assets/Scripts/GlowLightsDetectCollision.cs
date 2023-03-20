using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowLightsDetectCollision : MonoBehaviour
{
        private GlowLightNumberCountUI glowLightsManager;

    public int glowLightCount;

    private void Start()
    {
        glowLightsManager = GameObject.Find("GlowLightsManager").GetComponent<GlowLightNumberCountUI>();
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            glowLightsManager.IncreaseCount(glowLightCount);
        }
    }
    
    /*
    private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
   }
   */
}
