Shader "Masked/DepthMask"
{
    SubShader
    {
        // Render the mask after regular geometry, but defore masked geometry and trasparent things

        Tags { "Queue" = "Geometry-1" }

        // Don't draw in the RGBA channels; just the depth buffer

        ColorMask 0
        ZWrite On

        // Do nothing specific in the pass:

        Pass{}
    }
}
