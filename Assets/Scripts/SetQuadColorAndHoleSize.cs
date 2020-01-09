using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class SetQuadColorAndHoleSize : MonoBehaviour {
	public Color color = Color.red;
	public float holeRadius = 0.3f;

	private void Start() {
		holeRadius = Mathf.Clamp(holeRadius, 0, 0.5f);

		var renderer = GetComponent<MeshRenderer>();
		renderer.material.SetColor(ColorProperty, color);
		renderer.material.SetFloat(HoleRadiusProperty, holeRadius);
	}

	private static readonly int ColorProperty = Shader.PropertyToID("_Color");
	private static readonly int HoleRadiusProperty = Shader.PropertyToID("_HoleRadius");
}
