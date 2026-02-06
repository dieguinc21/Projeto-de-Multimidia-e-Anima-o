using UnityEngine;
using System.Collections;
using DragonBones;

public class TestAnimation : MonoBehaviour
{

    void Start()
    {
        UnityFactory.factory.LoadDragonBonesData("SimpleGuy/SimpleGuy_ske"); // DragonBones file path (without suffix)
        UnityFactory.factory.LoadTextureAtlasData("SimpleGuy/SimpleGuy_tex"); //Texture atlas file path (without suffix) 

        // Create armature.
        var armatureComponent = UnityFactory.factory.BuildArmatureComponent("SimpleGuy");
        // Input armature name

        // Play animation.
        armatureComponent.animation.Play("Dead");

        // Change armatureposition.
        armatureComponent.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }
}