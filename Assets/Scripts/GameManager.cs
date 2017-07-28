using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Image[] locks;
	public LineRenderer lr;
	// Use this for initialization
	public int[] points;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RandLine()
	{
		int r = Random.Range (0, locks.Length);
		Debug.LogError (r);
	}

	public void DrawLine ()
	{
		for (int i = 0; i < points.Length; i++) {
			int idx = points [i];
			Vector3 v = locks [idx].gameObject.transform.localPosition;
			Debug.Log (v);
//			if (i == 0)
//				lr.gameObject.transform.position = v;
			lr.SetPosition (i,v);
		}
	}
}
