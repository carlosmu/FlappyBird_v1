using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneratorLogic : MonoBehaviour
{
    public float timeMax = 1;
    private float timeInitial = 0;
    public GameObject obstacle;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obstacleNew = Instantiate(obstacle);
        obstacleNew.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(obstacleNew, 10);        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeInitial > timeMax)
        {
            GameObject obstacleNew = Instantiate(obstacle);
            obstacleNew.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(obstacleNew, 10);
            timeInitial = 0;
        }  
        else
        {
            timeInitial += Time.deltaTime;
        }        
    }
}
