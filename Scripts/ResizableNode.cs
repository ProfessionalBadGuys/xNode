using UnityEngine;

namespace XNode {
    public abstract class ResizableNode : Node {

        [SerializeField, HideInInspector]
        private int width = -1;
        public static string WidthFieldName => nameof(width);

        [SerializeField, HideInInspector]
        private int height = -1;
        public static string HeightFieldName => nameof(height);
    }
}