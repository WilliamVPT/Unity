using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pousuite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject Joueur;
    // Update is called once per frame
    void Update()
    {
        Vector3 C = transform.position;
        Vector3 S = Joueur.transform.position;
        float v = 2.00f;
        Vector3 direction = (S-C);
        Vector3 normale = direction.normalized;
        transform.position += normale * v * Time.deltaTime;
    }
}
