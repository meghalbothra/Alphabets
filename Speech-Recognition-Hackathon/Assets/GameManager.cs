using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] Vector3 pos;
    //public bool start = false;

    IEnumerator Period()
    {
        yield return new WaitForSeconds(2);
        Instantiate(obj, pos, Quaternion.identity);
        StartCoroutine(Period());
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(Period());
    }

    public void StopGame()
    {
        StopCoroutine(Period());
    }
}
