using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	private readonly int ROW_L = 6;
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
		Debug.Log ("r=" + r);
		if (isLeftTop (r)) {
			Debug.Log ("LT");
			return;
		}

		if (isLeftBottom (r)) {
			Debug.Log ("LB");
			return;
		}

		if (isRightTop (r)) {
			Debug.Log ("RT");
			return;
		}

		if (isRightBottom (r)) {
			Debug.Log ("RB");
			return;
		}

		if (isLeft (r)) {
			Debug.Log ("L");
			return;
		} 

		if (isTop (r)) {
			Debug.Log ("T");
			return;
		}

		if (isRight (r)) {
			Debug.Log ("R");
			return;
		}

		if (isBottom (r)) {
			Debug.Log ("B");
			return;
		}
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

	private bool isLeftTop(int r)
	{
		return isLeft (r) && isTop (r);
	}

	private bool isLeftBottom(int r)
	{
		return isLeft (r) && isBottom (r);
	}

	private bool isRightTop(int r)
	{
		return isRight (r) && isTop (r);
	}

	private bool isRightBottom(int r)
	{
		return isRight (r) && isBottom (r);
	}

	private bool isLeft(int r)
	{
		return r % ROW_L == 0;
	}

	private bool isRight(int r)
	{
		return (r + 1) % ROW_L == 0;
	}

	private bool isTop(int r)
	{
		return r / ROW_L == 0;
	}

	private bool isBottom(int r)
	{
		return r / ROW_L == (locks.Length - 1) / ROW_L;
	}
}
