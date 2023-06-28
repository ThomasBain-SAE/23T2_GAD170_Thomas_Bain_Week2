using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //We want a reference to all the cars in the game 
    [SerializeField] private GameObject car;
    [SerializeField] private GameObject Holden;
    [SerializeField] private GameObject VS;
    [SerializeField] private GameObject Audi;

    [SerializeField] private Car[] allRacecarsArray;
    [SerializeField] private List<Car> allRacecarsList = new List<Car>();
    void Start()
    {
        //we want to oput the names of al our cars at start

        //for our array:
        Debug.Log(allRacecarsArray.Length);
        Debug.Log(allRacecarsArray[3].name);



        //and for our lists:
        Debug.Log(allRacecarsList.Count);
        Debug.Log(allRacecarsList[3].name);
        CheckWhichCarisCrashed();

    }

    // Update is called once per frame
    private void CheckWhichCarisCrashed()
    {
        //use for loop
        for (int selectedCarIndex = 0; selectedCarIndex < allRacecarsArray.Length; selectedCarIndex++)
        {
            if (allRacecarsList[selectedCarIndex].isCrashed == true)
            {
                Debug.Log("CRASHED" + selectedCarIndex);
                Debug.Log("A car has crashed: [" + allRacecarsList[selectedCarIndex].name + "!");
            }

        }
    }

    public void HelloworldButton()
    {


        Debug.Log("Hello World");

    }


}
