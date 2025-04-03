using Noir;
using Noir.Attributes;
using UnityEditor;
using UnityEngine;

public class GetComponentExampleObject : NoirBehaviour
{
    [Help("This component reference is populated from the the first child object in the hierarchy.")]
    [GetComponent(GetComponentSearchArea.ChildrenFirst)]
    [SerializeField] private SpriteRenderer _spriteRenderer;

    [Help("By default [GetComponent] will populate fields with the components that exist on the same GameObject")]
    [GetComponent]
    [SerializeField] private AudioSource _audioSource;

    [Help("GetComponent only works in the Unity Editor, it has no effect at runtime.", MessageType.Warning)]
    [GetComponent]
    [SerializeField] private Rigidbody2D _rigidbody2D;
}
