using BepInEx;
using UnityEngine;

namespace JackOLantern.Core {
	public class Loader : BaseUnityPlugin {
		public static GameObject MainObj; // holds every component we need to run this mod loader
		public static Loader Instance; // instance

		public void Awake() {
			Instance = this;
			if (!MainObj) {
				MainObj = new GameObject("JackOLantern Loader");
			}
		}
	}
}