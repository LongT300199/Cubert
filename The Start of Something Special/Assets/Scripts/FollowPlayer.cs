using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 cameraOffset;

	// Update is called once per frame
	void Update () {
		//Debug.Log(player.position);
		transform.position = player.position + cameraOffset;
	}
}
