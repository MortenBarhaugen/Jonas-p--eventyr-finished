using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float lifeTime;
    //public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathDelay());
        //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //audio.PlayOneShot(audio.clip);
    }

    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
