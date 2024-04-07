using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Prefab : MonoBehaviour 
{
    public GameObject fallPrefab;
    public Rigidbody2D playerController;
    public Rigidbody2D fallBall;

    void Start()
    {
        //fallPrefab = this.GetComponent<GameObject>();
        //Instantiate(fallPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Update()
    {
        int rand = Random.Range(0, 1050);
        int rand2 = Random.Range(-2, 2);
        // if(playerController.transform.position.y > 0f)
        // {
        //     Rigidbody2D ball = Instantiate(fallBall, transform.position, transform.rotation);
        // }
        Vector3 rand2Vector = new Vector3(rand2,0,0);
        if((playerController.transform.position.y > 0f) && (rand == 2))
        {
            Rigidbody2D ball = Instantiate(fallBall, transform.position+rand2Vector, transform.rotation);
        }
    }
}