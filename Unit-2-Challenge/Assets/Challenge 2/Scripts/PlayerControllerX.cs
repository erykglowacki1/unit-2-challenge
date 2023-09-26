using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1.0f;
    private float waitTimer = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (timer < waitTimer) { }
        // On spacebar press, send dog
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
        timer += Time.deltaTime;
        Debug.Log(timer);
    }
}
