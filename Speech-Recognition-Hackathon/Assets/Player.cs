using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 250, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "wall")
        {
            Debug.Log("colledie");
            gameManager.SetActive(false);
        }
        
    }
   

}
