using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class declencheur : MonoBehaviour
{
    public GameObject charge;
    public int compteur = 0;
    public float x = 15.3f;
    public float y = 2.5f;
    public float z = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Incrémenter le compteur avant de l'afficher
        compteur++;
        Debug.Log($"Déclenché, {compteur} charge(s) !");
        charge.transform.position = new Vector3(x, y, z);
    }
}
