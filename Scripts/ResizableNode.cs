using UnityEngine;

namespace XNode {
    public abstract class ResizableNode : Node {

        [SerializeField, HideInInspector]
        private int width = 300;
        public static string WidthFieldName => nameof(width);

        [SerializeField, HideInInspector]
        private int height = 80;
        public static string HeightFieldName => nameof(height);
    }
}