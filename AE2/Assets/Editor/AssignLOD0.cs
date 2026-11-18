
using UnityEngine;
using UnityEditor;

public static class AssignLOD0
{
    [MenuItem("Tools/LOD/Assign Children to LOD0")]
    private static void Assign()
    {
        GameObject root = Selection.activeGameObject;

        if (root == null)
        {
            Debug.LogWarning("Selecciona el edificio en Hierarchy.");
            return;
        }

        Renderer[] renderers =
            root.GetComponentsInChildren<Renderer>(true);

        if (renderers.Length == 0)
        {
            Debug.LogWarning("No se encontraron Renderers.");
            return;
        }

        LODGroup group = root.GetComponent<LODGroup>();

        if (group == null)
            group = Undo.AddComponent<LODGroup>(root);

        Undo.RecordObject(group, "Assign LOD0 Renderers");

        LOD lod0 = new LOD(0.6f, renderers);
        group.SetLODs(new[] { lod0 });
        group.RecalculateBounds();

        EditorUtility.SetDirty(group);

        Debug.Log(
            $"LOD0 configurado: {renderers.Length} renderers en {root.name}");
    }
}
