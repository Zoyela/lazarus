using UnityEngine;

public class PlayerController : MonoBehaviour{

	[SerializeField]
	private float speed;

	void Update(){
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}