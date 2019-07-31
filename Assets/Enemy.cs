using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
  
        void Start()
        {

        }

        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Przeciwnik pokonany");
            Debug.Log(other);

            var player = other.GetComponent<PlayerMovement>();
            // Player player = other.GetComponent<Player>();

            if (player)
            {
                player.YouWin();
            }
        }

    }

    

