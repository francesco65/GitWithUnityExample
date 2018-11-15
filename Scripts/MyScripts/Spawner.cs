using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    public GameObject cube_Prefab;

	// Use this for initialization
	void Start ()
    {
        Instantiate(cube_Prefab);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //se cliccando con il tasto sx al rilascio del mouse(0 = click sx) 
        //instanzio un cubo, il quale viene instanziato usando ogni volta una
        //posizione casuale
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(cube_Prefab, new Vector3(Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5)), cube_Prefab.transform.rotation);
        }
	}
}
