﻿using UnityEngine;
using System.Collections;

namespace Tabletop{

	public class TreasureLocation {

		public Player player = null;
		public Treasure treasure = null;
		public bool active = true;

		public TreasureLocation(){
		}
		public TreasureLocation (Treasure t) {
			treasure = t;
		}
	}
}
