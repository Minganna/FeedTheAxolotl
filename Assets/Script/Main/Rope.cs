using UnityEngine;

public class Rope : MonoBehaviour {

	public Rigidbody2D hook;

	public GameObject LinkPrefab;

	public Weight weight;

	public int links = 7;

	// Use this for initialization
	void Start () {
		GenerateRope ();
	}

	void GenerateRope()
	{
		Rigidbody2D previousRB = hook;
		for (int i = 0; i < links; i++) {

			GameObject link =	Instantiate (LinkPrefab, transform);
			HingeJoint2D joint = link.GetComponent<HingeJoint2D> ();
			joint.connectedBody = previousRB;

			if (i < links - 1) {
				previousRB = link.GetComponent<Rigidbody2D> ();
			} else 
			{
				weight.ConnectRopeEnd (link.GetComponent<Rigidbody2D> ());
			}
		}


	}

}
