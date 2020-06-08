using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
	internal static class RectTransformStretcher
	{
		[MenuItem( "CONTEXT/RectTransform/Stretch" )]
		private static void Stretch( MenuCommand command )
		{
			var rectTransform = ( RectTransform ) command.context;

			Undo.RecordObject( rectTransform, nameof( Stretch ) );

			rectTransform.anchorMin  = Vector2.zero;
			rectTransform.anchorMax  = Vector2.one;
			rectTransform.offsetMin  = Vector2.zero;
			rectTransform.offsetMax  = Vector2.zero;
			rectTransform.pivot      = new Vector2( 0.5f, 0.5f );
			rectTransform.rotation   = Quaternion.identity;
			rectTransform.localScale = Vector3.one;
		}
	}
}