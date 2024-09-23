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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region NinePatch declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html"/>
    /// </summary>
    public partial class NinePatch : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NinePatch>
    {
        const string _bridgeClassName = "android.graphics.NinePatch";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NinePatch() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NinePatch(params object[] args) : base(args) { }
    
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

    #region NinePatch implementation
    public partial class NinePatch
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#%3Cinit%3E(android.graphics.Bitmap,byte[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public NinePatch(Android.Graphics.Bitmap arg0, byte[] arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#%3Cinit%3E(android.graphics.Bitmap,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public NinePatch(Android.Graphics.Bitmap arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#isNinePatchChunk(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNinePatchChunk(byte[] arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNinePatchChunk", "([B)Z", new object[] { arg0 });
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getBitmap()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetBitmap()
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getBitmap", "()Landroid/graphics/Bitmap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getPaint()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Paint"/></returns>
        public Android.Graphics.Paint GetPaint()
        {
            return IExecuteWithSignature<Android.Graphics.Paint>("getPaint", "()Landroid/graphics/Paint;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getTransparentRegion(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.Graphics.Region"/></returns>
        public Android.Graphics.Region GetTransparentRegion(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Region>("getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#hasAlpha()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAlpha()
        {
            return IExecuteWithSignature<bool>("hasAlpha", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getDensity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDensity()
        {
            return IExecuteWithSignature<int>("getDensity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#draw(android.graphics.Canvas,android.graphics.Rect,android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Paint"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Android.Graphics.Rect arg1, Android.Graphics.Paint arg2)
        {
            IExecute("draw", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#draw(android.graphics.Canvas,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Android.Graphics.Rect arg1)
        {
            IExecute("draw", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#draw(android.graphics.Canvas,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.RectF"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Android.Graphics.RectF arg1)
        {
            IExecute("draw", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#setPaint(android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Paint"/></param>
        public void SetPaint(Android.Graphics.Paint arg0)
        {
            IExecuteWithSignature("setPaint", "(Landroid/graphics/Paint;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}