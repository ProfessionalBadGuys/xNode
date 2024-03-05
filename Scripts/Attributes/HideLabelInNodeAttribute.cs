using UnityEngine;

namespace XNode {
	/// <summary>
	/// Used on Serialized fields to hide the label but ONLY in the Node inspector. Does NOT override the Drawer, allowing custom drawers to still handle the main drawing function.
	/// </summary>
	public class HideLabelInNodeAttribute : PropertyAttribute { }

}