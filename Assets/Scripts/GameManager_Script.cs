using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager_Script : MonoBehaviour
{
    [SerializeField]
    public Transform parent;

    GameObject portal_1;
    GameObject portal_2;
    GameObject portal_3;
    GameObject portal_4;

    float timer, timer_shutoff;
    float timer_2, timer_2shutoff;

    int countsTime;
    float seconds = 3;

    bool set1_Active; //pairs of portals to set active
    bool set2_Active;

    // Start is called before the first frame update
    void Start()
    {
        //countsTime = 0;
        timer = 0;
        //set2_Active = false;

        //setting a reference for the portals
        portal_1 = parent.GetChild(0).gameObject;
        portal_4 = parent.GetChild(3).gameObject;

        portal_3 = parent.GetChild(1).gameObject;
        portal_2 = parent.GetChild(2).gameObject;

        portal_3.SetActive(false);
        portal_2.SetActive(false);
        portal_1.SetActive(false);  
        portal_4.SetActive(false);

        countsTime = 3;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if(timer>3&& timer<6 && countsTime ==3)
        {
            countsTime = 1;

        }else if(timer>6 && timer<9&&countsTime ==1)
        {
            countsTime = 3;

        }else if(timer>9 && timer < 12&&countsTime == 3)
        {
            countsTime = 2;
        }
        else if(timer>12  &&countsTime == 2)
        {
            countsTime = 3;
            timer = 0;
        }
        switch (countsTime)
        {
            case 1:

                portal_3.SetActive(false);
                portal_2.SetActive(false);
                portal_1.SetActive(true);
                portal_4.SetActive(true);
                break;
            
            case 2:

                portal_3.SetActive(true);
                portal_2.SetActive(true);
                portal_1.SetActive(false);
                portal_4.SetActive(false);
                break;
            
            case 3:

                portal_3.SetActive(false);
                portal_2.SetActive(false);
                portal_1.SetActive(false);
                portal_4.SetActive(false);
                break;
            
        }
    }

    void resetTime(float time)
    {
        time = 3;
    }
    
}

