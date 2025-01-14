/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region RenderNode declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html"/>
    /// </summary>
    public partial class RenderNode : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RenderNode>
    {
        const string _bridgeClassName = "android.graphics.RenderNode";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RenderNode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RenderNode(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region RenderNode implementation
    public partial class RenderNode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public RenderNode(Java.Lang.String arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#beginRecording()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.RecordingCanvas"/></returns>
        public Android.Graphics.RecordingCanvas BeginRecording()
        {
            return IExecuteWithSignature<Android.Graphics.RecordingCanvas>("beginRecording", "()Landroid/graphics/RecordingCanvas;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#beginRecording(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.RecordingCanvas"/></returns>
        public Android.Graphics.RecordingCanvas BeginRecording(int arg0, int arg1)
        {
            return IExecuteWithSignature<Android.Graphics.RecordingCanvas>("beginRecording", "(II)Landroid/graphics/RecordingCanvas;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getClipToBounds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetClipToBounds()
        {
            return IExecuteWithSignature<bool>("getClipToBounds", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getClipToOutline()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetClipToOutline()
        {
            return IExecuteWithSignature<bool>("getClipToOutline", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getUseCompositingLayer()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseCompositingLayer()
        {
            return IExecuteWithSignature<bool>("getUseCompositingLayer", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#hasDisplayList()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasDisplayList()
        {
            return IExecuteWithSignature<bool>("hasDisplayList", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#hasIdentityMatrix()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasIdentityMatrix()
        {
            return IExecuteWithSignature<bool>("hasIdentityMatrix", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#hasOverlappingRendering()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasOverlappingRendering()
        {
            return IExecuteWithSignature<bool>("hasOverlappingRendering", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#hasShadow()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasShadow()
        {
            return IExecuteWithSignature<bool>("hasShadow", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#isForceDarkAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsForceDarkAllowed()
        {
            return IExecuteWithSignature<bool>("isForceDarkAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#isPivotExplicitlySet()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPivotExplicitlySet()
        {
            return IExecuteWithSignature<bool>("isPivotExplicitlySet", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#offsetLeftAndRight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OffsetLeftAndRight(int arg0)
        {
            return IExecuteWithSignature<bool>("offsetLeftAndRight", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#offsetTopAndBottom(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OffsetTopAndBottom(int arg0)
        {
            return IExecuteWithSignature<bool>("offsetTopAndBottom", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#resetPivot()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ResetPivot()
        {
            return IExecuteWithSignature<bool>("resetPivot", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setAlpha(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetAlpha(float arg0)
        {
            return IExecuteWithSignature<bool>("setAlpha", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setAmbientShadowColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetAmbientShadowColor(int arg0)
        {
            return IExecuteWithSignature<bool>("setAmbientShadowColor", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setCameraDistance(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetCameraDistance(float arg0)
        {
            return IExecuteWithSignature<bool>("setCameraDistance", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setClipRect(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetClipRect(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<bool>("setClipRect", "(Landroid/graphics/Rect;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setClipToBounds(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetClipToBounds(bool arg0)
        {
            return IExecuteWithSignature<bool>("setClipToBounds", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setClipToOutline(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetClipToOutline(bool arg0)
        {
            return IExecuteWithSignature<bool>("setClipToOutline", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setElevation(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetElevation(float arg0)
        {
            return IExecuteWithSignature<bool>("setElevation", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setForceDarkAllowed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetForceDarkAllowed(bool arg0)
        {
            return IExecuteWithSignature<bool>("setForceDarkAllowed", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setHasOverlappingRendering(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetHasOverlappingRendering(bool arg0)
        {
            return IExecuteWithSignature<bool>("setHasOverlappingRendering", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setOutline(android.graphics.Outline)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Outline"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetOutline(Android.Graphics.Outline arg0)
        {
            return IExecuteWithSignature<bool>("setOutline", "(Landroid/graphics/Outline;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setPivotX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPivotX(float arg0)
        {
            return IExecuteWithSignature<bool>("setPivotX", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setPivotY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPivotY(float arg0)
        {
            return IExecuteWithSignature<bool>("setPivotY", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setPosition(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPosition(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<bool>("setPosition", "(Landroid/graphics/Rect;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setPosition(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPosition(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<bool>("setPosition", "(IIII)Z", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setProjectBackwards(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetProjectBackwards(bool arg0)
        {
            return IExecuteWithSignature<bool>("setProjectBackwards", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setProjectionReceiver(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetProjectionReceiver(bool arg0)
        {
            return IExecuteWithSignature<bool>("setProjectionReceiver", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setRenderEffect(android.graphics.RenderEffect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RenderEffect"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetRenderEffect(Android.Graphics.RenderEffect arg0)
        {
            return IExecuteWithSignature<bool>("setRenderEffect", "(Landroid/graphics/RenderEffect;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setRotationX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetRotationX(float arg0)
        {
            return IExecuteWithSignature<bool>("setRotationX", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setRotationY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetRotationY(float arg0)
        {
            return IExecuteWithSignature<bool>("setRotationY", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setRotationZ(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetRotationZ(float arg0)
        {
            return IExecuteWithSignature<bool>("setRotationZ", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setScaleX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetScaleX(float arg0)
        {
            return IExecuteWithSignature<bool>("setScaleX", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setScaleY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetScaleY(float arg0)
        {
            return IExecuteWithSignature<bool>("setScaleY", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setSpotShadowColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetSpotShadowColor(int arg0)
        {
            return IExecuteWithSignature<bool>("setSpotShadowColor", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setTranslationX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetTranslationX(float arg0)
        {
            return IExecuteWithSignature<bool>("setTranslationX", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setTranslationY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetTranslationY(float arg0)
        {
            return IExecuteWithSignature<bool>("setTranslationY", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setTranslationZ(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetTranslationZ(float arg0)
        {
            return IExecuteWithSignature<bool>("setTranslationZ", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#setUseCompositingLayer(boolean,android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Paint"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetUseCompositingLayer(bool arg0, Android.Graphics.Paint arg1)
        {
            return IExecuteWithSignature<bool>("setUseCompositingLayer", "(ZLandroid/graphics/Paint;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getAlpha()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetAlpha()
        {
            return IExecuteWithSignature<float>("getAlpha", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getCameraDistance()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCameraDistance()
        {
            return IExecuteWithSignature<float>("getCameraDistance", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getElevation()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetElevation()
        {
            return IExecuteWithSignature<float>("getElevation", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getPivotX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetPivotX()
        {
            return IExecuteWithSignature<float>("getPivotX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getPivotY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetPivotY()
        {
            return IExecuteWithSignature<float>("getPivotY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getRotationX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetRotationX()
        {
            return IExecuteWithSignature<float>("getRotationX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getRotationY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetRotationY()
        {
            return IExecuteWithSignature<float>("getRotationY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getRotationZ()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetRotationZ()
        {
            return IExecuteWithSignature<float>("getRotationZ", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getScaleX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetScaleX()
        {
            return IExecuteWithSignature<float>("getScaleX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getScaleY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetScaleY()
        {
            return IExecuteWithSignature<float>("getScaleY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getTranslationX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetTranslationX()
        {
            return IExecuteWithSignature<float>("getTranslationX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getTranslationY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetTranslationY()
        {
            return IExecuteWithSignature<float>("getTranslationY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getTranslationZ()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetTranslationZ()
        {
            return IExecuteWithSignature<float>("getTranslationZ", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getAmbientShadowColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAmbientShadowColor()
        {
            return IExecuteWithSignature<int>("getAmbientShadowColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getBottom()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBottom()
        {
            return IExecuteWithSignature<int>("getBottom", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getLeft()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLeft()
        {
            return IExecuteWithSignature<int>("getLeft", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getRight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRight()
        {
            return IExecuteWithSignature<int>("getRight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getSpotShadowColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSpotShadowColor()
        {
            return IExecuteWithSignature<int>("getSpotShadowColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getTop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTop()
        {
            return IExecuteWithSignature<int>("getTop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#computeApproximateMemoryUsage()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ComputeApproximateMemoryUsage()
        {
            return IExecuteWithSignature<long>("computeApproximateMemoryUsage", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getUniqueId()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetUniqueId()
        {
            return IExecuteWithSignature<long>("getUniqueId", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#discardDisplayList()"/>
        /// </summary>
        public void DiscardDisplayList()
        {
            IExecuteWithSignature("discardDisplayList", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#endRecording()"/>
        /// </summary>
        public void EndRecording()
        {
            IExecuteWithSignature("endRecording", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getInverseMatrix(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void GetInverseMatrix(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("getInverseMatrix", "(Landroid/graphics/Matrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RenderNode.html#getMatrix(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void GetMatrix(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("getMatrix", "(Landroid/graphics/Matrix;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}