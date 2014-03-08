using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	Transform myTransform;
	Transform CameraObject;
	Transform TankHead;

	public Texture2D crosshairImage;
	public float MoveSpeed = 6.0F;
	public float RotateSpeed = 5.0F;




	//CharacterController cc;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		//CameraObject = myTransform.FindChild("Camera");
		//TankHead = myTransform.FindChild("Head");
		//cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	
		float rotX = Input.GetAxis("Mouse X");
		float rotY = Input.GetAxis("Mouse Y");

		//float forward = Input.GetKey(
		if (Input.GetKey(KeyCode.W))
		{
			myTransform.position += myTransform.right * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			myTransform.position -= myTransform.right * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A))
		{
			myTransform.position += myTransform.forward * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D))
		{
			myTransform.position -= myTransform.forward * MoveSpeed * Time.deltaTime;
		}

		myTransform.Rotate(0, rotX, 0);


		//cc.SimpleMove(Physics.gravity);
			//Position(0, rotX, 0);
	}


	void OnGUI()
	{
		float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
		float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
		GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
	}



}
