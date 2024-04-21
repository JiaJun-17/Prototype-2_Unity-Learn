using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //an array of GameObject which is animalPrefabs
    private float spawnRangeZLeft = -10.0f;
    private float spawnRangeZRight = 30.0f;
    private float spawnPositionX = -20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //will take the method that we want to call and constantly repeat it over time depending on the rate we want
        InvokeRepeating("SpawnRandomAnimal" , startDelay , spawnInterval ); //( will repeatly call SpawnRandomAnimal() method , start at 2 secs, call it again every 1.5 secs)
    }

    // Update is called once per frame
    void Update()
    {
        /*  //no need to press Q since we have InvokeRepeating() method to spawn the animal automatically
        if(Input.GetKeyDown(KeyCode.Q))  //when user presses the Q key
        {
            SpawnRandomAnimal(); //call the SpawnRandomAnimal function while Q key is pressed
        }
        */
    }

    //adding new function. function does return anything, it will just do what we tell it to do inside the function
    //add new function to spawn animal automatically
    void SpawnRandomAnimal ()
    {
            //animalIndex means element 0/1/2... while 0 is horse, 1 is moose, 2 is dog
            //animalIndex = Random.Range(0, 3); //random number from 0 to 3, total of 3 element
            //OR
            int animalIndex = Random.Range(0, animalPrefabs.Length); //randowm number from 0 to the length of the array
            Vector3 spwanPosition = new Vector3(spawnPositionX,0,Random.Range(spawnRangeZLeft, spawnRangeZRight)); //(x,y,z) so fix at direction-x and random direction-z

            //create animalPrefabs using the selected animalIndex, spawn it at -20,0,0 (position) , make sure the rotation of the animal is the same
            //Instantiate(animalPrefabs[animalIndex], new Vector3(-20,0,0), animalPrefabs[animalIndex].transform.rotation);
            //become //so that random animal will be spawn at different direction-z
            Instantiate(animalPrefabs[animalIndex], spwanPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
