using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public void PlayerSpawn()
    {
        Vector3 spawnPos = FindObjectOfType<SpawnPosition>().GetSpawnPosition();

        Instantiate(player, spawnPos, Quaternion.identity);      
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerSpawn();
        }
    }
}
