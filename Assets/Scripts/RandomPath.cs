using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomPath {

	public static readonly int ROW_L = 6;
	public static readonly int COL_L = 3;

	private enum NextPos{
		NR  = 1,
		NT  = -ROW_L,
		NB  = ROW_L,
		NL  = -1,
		NLT = -1-ROW_L,
		NRT = 1-ROW_L,
		NRB = 1+ROW_L,
		NLB = -1+ ROW_L
	}

	private static RandomPath _instance;

	public static RandomPath Inst{
		get{
			if (_instance == null) {
				_instance = new RandomPath ();
			}
			return _instance;
		}
	}

	public int LTNext(int r)
	{
		List<int> list = new List<int> ();
		list.Add (r + NextPos.NR);
		list.Add (r + NextPos.NB);
		list.Add (r + NextPos.NRB);
		for (int i = r + NextPos.NRB + NextPos.NR; i < r + NextPos.NRB + ROW_L - r % ROW_L; i++) {
			list.Add (i);
		}
		for (int i = 0; i < COL_L - r / ROW_L - 1; i++) {
			list.Add (r + NextPos.NRB + NextPos.NR +NextPos.NR * i);
		}
		Random rm = new Random();
		int idx = rm.Next (list.Count);  //随机数最大值不能超过list的总数

		return list[idx];
	}

	public bool isLeftTop(int r)
	{
		return isLeft (r) && isTop (r);
	}

	public bool isLeftBottom(int r)
	{
		return isLeft (r) && isBottom (r);
	}

	public bool isRightTop(int r)
	{
		return isRight (r) && isTop (r);
	}

	public bool isRightBottom(int r)
	{
		return isRight (r) && isBottom (r);
	}

	public bool isLeft(int r)
	{
		return r % ROW_L == 0;
	}

	public bool isRight(int r)
	{
		return (r + 1) % ROW_L == 0;
	}

	public bool isTop(int r)
	{
		return r / ROW_L == 0;
	}

	public bool isBottom(int r)
	{
		return r / ROW_L == (ROW_L*COL_L - 1) / ROW_L;
	}

}
