using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlowLightNumberCountUI : MonoBehaviour
{
    public int count; 

    public TextMeshProUGUI countText;

    //Adds to count hopefully
    public void IncreaseCount(int amount)
    {
        count += amount;
        UpdateCountText();
    }
    
    public void UpdateCountText()
    {
        countText.text = "Glow Lights: " + count;
    }
    
}
