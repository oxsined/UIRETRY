Shader "Custom/UI_HolePunch"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue"="Geometry-1" }

        Pass
        {
            ZWrite Off
            ColorMask 0

            Stencil
            {
                Ref 1
                Comp Always
                Pass Replace
            }
        }
    }
}