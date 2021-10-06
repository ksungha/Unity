using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.ParticleSystemJobs;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _laserSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _laserSpeed);
    }
}
