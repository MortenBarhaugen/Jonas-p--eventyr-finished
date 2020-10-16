using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public HitPlayer hitplayer;
    public Image fillImage;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //float fillValue = hitplayer.currentHealth / hitplayer.maxHealth;
        float fillValue = hitplayer.currentHealth;
        slider.value = fillValue;
    }
}
