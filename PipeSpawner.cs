using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]public float maxtime = 1.5f;
    [SerializeField]private float timer;
    [SerializeField]private GameObject pipe;
    [SerializeField] public float height =0.45f;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();  
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxtime) {
            spawnpipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    private void spawnpipe()
    {
        Vector3 spawnposition = transform.position + new Vector3(0, Random.Range(-height, height));
        GameObject newpipe=Instantiate(pipe,spawnposition,Quaternion.identity);
        Destroy(newpipe,17f);
    }
}
