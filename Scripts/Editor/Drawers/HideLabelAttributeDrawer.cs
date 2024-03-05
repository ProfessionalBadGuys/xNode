using UnityEditor;
using UnityEngine;

namespace XNode {
	[CustomPropertyDrawer(typeof(HideLabelAttribute))]
	public class HideLabelAttributeDrawer : PropertyDrawer {

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			EditorGUI.PropertyField(position, property, GUIContent.none, true);
		}
	}
}