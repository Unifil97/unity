﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float irrota=1;//irroitus väli 1s
    private float seurKoira=0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > seurKoira)
        {
            seurKoira=Time.time+irrota;// päästä seuraava koira tietynajan päästä 1s
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
