using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	Transform myTransform;
	Transform CameraObject;
	Transform TankModel;
	float VerticalRotation = 0;
	float VerticalRange = 60.0f;


	public Texture2D crosshairImage;
	public float MoveSpeed = 6.0F;
	public float RotateSpeed = 5.0F;


	CharacterController cc;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		//TankModel = myTransform.FindChild("Tank");
		cc = GetComponent<CharacterController>();
		//TankModel.
		//CameraObject = myTransform.FindChild("Camera");
		//TankHead = myTransform.FindChild("Head");
	}
	
	// Update is called once per frame
	void Update () {
	
		float rotX = Input.GetAxis("Mouse X");
		float rotY = Input.GetAxis("Mouse Y");

		float VerticalSpeed = Input.GetAxis("Vertical") * MoveSpeed;
		float HorizontalSpeed = Input.GetAxis ("Horizontal") * MoveSpeed;
		Vector3 Speed = new Vector3(VerticalSpeed, 0 ,HorizontalSpeed);
		//float forward = Input.GetKey(
		/*if (Input.GetKey(KeyCode.W))
		{
			myTransform.position -= myTransform.right * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			myTransform.position += myTransform.right * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A))
		{
			myTransform.position -= myTransform.forward * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D))
		{
			myTransform.position += myTransform.forward * MoveSpeed * Time.deltaTime;
		}*/


		cc.SimpleMove(Speed);
		VerticalRotation =- rotY * 3.0f;
		VerticalRotation = Mathf.Clamp(VerticalRotation, -VerticalRange, VerticalRange);
		//myTransform.localRotation = Quaternion.Euler(VerticalRotation,0,0);


		//float rotYAxis = myTransform.rotation.eulerAngles.y;
		//float desiredyAxis = Mathf.Clamp(rotYAxis, -0.0f, 0.0f);

		//myTransform.rotation = Quaternion.Euler(desiredyAxis, 0, 0);
		//if ((rotYAxis >= -90) && (rotYAxis <= 5))
		//{
		//	myTransform.Rotate(0, rotX, rotY);
		//}
		myTransform.Rotate(0, rotX, VerticalRotation);






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
