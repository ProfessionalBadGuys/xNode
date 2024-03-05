using UnityEngine;

namespace XNode {
	/// <summary>
	/// Can be used on Serialized fields to hide the label in the inspector. Overrides the Drawer.
	/// </summary>
	public class HideLabelAttribute : PropertyAttribute { }
}