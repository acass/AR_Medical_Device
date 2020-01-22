using UnityEngine;

public class ChangeCloths : MonoBehaviour {
    
    public Renderer mShirt, mPants;
    public Texture[] mShirtTextures;

    public void changeMyShirt(int myTexture) {

        switch (myTexture) {
            case 0:
                mShirt.material.SetTexture("_MainTex", mShirtTextures[0]);
                mPants.material.SetTexture("_MainTex", mShirtTextures[0]);
                break;
            case 1:
                mShirt.material.SetTexture("_MainTex", mShirtTextures[1]);
                mPants.material.SetTexture("_MainTex", mShirtTextures[0]);
                break;
            case 2:
                mShirt.material.SetTexture("_MainTex", mShirtTextures[2]);
                mPants.material.SetTexture("_MainTex", mShirtTextures[0]);
                break;
            default:
                break;
        }
    }
}