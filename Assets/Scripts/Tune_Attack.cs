﻿using UnityEngine;
using System.Collections;

public class Tune_Attack : Tune {

    /// <summary>
    /// What should happen when the tune completes?
    /// </summary>
    /// <param name="crit">Was the tune played perfectly?</param>
	public override void TuneComplete (bool crit)
	{
		base.TuneComplete (crit);

		GameObject temp = (GameObject)GameObject.Instantiate(spawnObject,ownerTransform.position + ownerTransform.forward*2f, ownerTransform.rotation);
		temp.GetComponent<Attack>().agressor = ownerTransform.GetComponent<BaseControl>().player;
		temp.GetComponent<Spawnable>().Crit(crit);
	}

}
