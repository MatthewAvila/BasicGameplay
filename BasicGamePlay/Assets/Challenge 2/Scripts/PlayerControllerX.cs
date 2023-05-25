using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawnCooldown = 2.0f;
    private float dogSpawnTimer = 0.0f;

    // Update is called once per frame
    void Update()
    {

        dogSpawnTimer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawnTimer >= dogSpawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogSpawnTimer = 0.0f;
        }
    }
}
