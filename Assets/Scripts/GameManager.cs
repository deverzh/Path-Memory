using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Image[] locks;
	public LineRenderer lr;
	public int[] points;
	void Start () {
	
	}

	public void RandLine()
	{
		int r = Random.Range (0, locks.Length);
		r = 0;
		Debug.Log ("r=" + r);
		if (RandomPath.Inst.isLeftTop (r)) {
			Debug.Log ("LT"+RandomPath.Inst.LTNext(r));
			return;
		}

		if (RandomPath.Inst.isLeftBottom (r)) {
			Debug.Log ("LB");
			return;
		}

		if (RandomPath.Inst.isRightTop (r)) {
			Debug.Log ("RT");
			return;
		}

		if (RandomPath.Inst.isRightBottom (r)) {
			Debug.Log ("RB");
			return;
		}

		if (RandomPath.Inst.isLeft (r)) {
			Debug.Log ("L");
			return;
		} 

		if (RandomPath.Inst.isTop (r)) {
			Debug.Log ("T");
			return;
		}

		if (RandomPath.Inst.isRight (r)) {
			Debug.Log ("R");
			return;
		}

		if (RandomPath.Inst.isBottom (r)) {
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


}
