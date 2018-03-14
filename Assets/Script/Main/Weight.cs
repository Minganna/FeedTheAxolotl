
using UnityEngine;

public class Weight : MonoBehaviour {

	public float distanceFromChainEnd=0.6f;

	public void ConnectRopeEnd(Rigidbody2D endRB)
	{
		HingeJoint2D Joint=gameObject.AddComponent<HingeJoint2D>();
		Joint.autoConfigureConnectedAnchor = false;
		Joint.connectedBody = endRB;
		Joint.anchor = Vector2.zero;
		Joint.connectedAnchor = new Vector2 (0f, -distanceFromChainEnd);
	}
}
