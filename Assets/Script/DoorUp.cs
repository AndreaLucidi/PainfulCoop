using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUp : MonoBehaviour {
    public float speed;
    public float UpMuch;
    private float targetY;
    public GameObject Door;
    private bool active;
	// Use this for initialization
	void Start () {
        active = false;
		targetY = Door.transform.position.y + UpMuch;
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
		if (active)
        {
            if (Door.transform.position.y != targetY)
            {
                Door.transform.position = Vector3.MoveTowards(Door.transform.position, new Vector3(Door.transform.position.x, targetY, Door.transform.position.z), step);
            }
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            active = true;
        }
    }
}
