using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {

    public GameObject player;   ///har bar instantiate kr ne wala dena h func bana kr hojae ga baad ma dekhte hain 
    public Vector3 offset;
    public float smooth = 5.0f;
    private Vector3 point;

    GameObject par;
    Transform front;
    Transform back;

    void Start()
    {//Set up things on the start method
//        point = player.transform.position;//get target's coords
 //       transform.LookAt(point);//makes the camera look to it 

        
    }

    void OnEnable()
    {
        par = player.transform.Find("Colliders").gameObject;
        back = par.transform.Find("ColliderBottom");
        front = par.transform.Find("ColliderFront");
    }
    /*
	//from net

	// The distance in the x-z plane to the target
	public float distance = 10.0f;
	// the height we want the camera to be above the target
	public float height = 20.0f;
	// How much we 
	public float heightDamping = 20.0f;
	public float rotationDamping = 3.0f;

	// Place the script in the Camera-Control group in the component menu
	[AddComponentMenu("Camera-Control/Smooth Follow")]
    */

	// original
    
	void Update () {
        /*
        par = player.transform.Find("Colliders").gameObject;
        back = par.transform.Find("ColliderBottom");
        front = par.transform.Find("ColliderFront");
        */
        Vector3 direction = front.position - back.position;
        direction = direction.normalized;

        
        transform.position = player.transform.position + (-8 * direction);
        transform.position += new Vector3(0,5,0);
        
        //transform.rotation = player.transform.rotation;
        transform.LookAt(player.transform);
        //transform.RotateAround(player.transform.position, new Vector3(0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * 10f);





    }
    


    
    /*
     * 
     * // net1
	void LateUpdate () {
		// Early out if we don't have a target
		if (!player.transform) return;

		// Calculate the current rotation angles
		float wantedRotationAngle = player.transform.eulerAngles.y;
		float wantedHeight = player.transform.position.y + height;

		float currentRotationAngle = player.transform.eulerAngles.y;
		float currentHeight = player.transform.position.y;

		// Damp the rotation around the y-axis
		currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
	
		// Damp the height
		currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

		// Convert the angle into a rotation
		var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
	
		// Set the position of the camera on the x-z plane to:
		// distance meters behind the target
		transform.position = player.transform.position;
		transform.position -= currentRotation * Vector3.forward * distance;

		// Set the height of the camera
		transform.position = new Vector3(transform.position.x,currentHeight,transform.position.z);
	
		// Always look at the target
		transform.LookAt(player.transform);
	}
    */

/*    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position, player.transform.position+offset,
            Time.deltaTime * smooth);
    }*/ 
}
