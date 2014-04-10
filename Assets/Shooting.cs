using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {


	public GameObject BulletPrefab;
	Transform myTransform;
	Transform SpawnPoint;
	float bulletspeed = 100.0f;
	bool Pressed;
	Transform CameraObj;
	// Use this for initialization
	void Start () {
		Pressed = false;
		myTransform = transform;
		SpawnPoint = myTransform.FindChild("Spawn");
		CameraObj = myTransform.FindChild("Camera");
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetButtonUp("Fire1"))
		{
			Pressed = false;
		}


		if ((Input.GetButton("Fire1")) && !Pressed)
		{



			GameObject Bullet = (GameObject)Instantiate(BulletPrefab, SpawnPoint.position, CameraObj.rotation); 
			Bullet.rigidbody.AddForce(-myTransform.right * bulletspeed, ForceMode.Impulse);
			Pressed = true;
		}
	}
}
