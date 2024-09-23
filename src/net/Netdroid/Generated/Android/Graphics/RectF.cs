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
    #region RectF declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/RectF.html"/>
    /// </summary>
    public partial class RectF : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.graphics.RectF";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RectF() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RectF(params object[] args) : base(args) { }
    
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

    #region RectF implementation
    public partial class RectF
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#%3Cinit%3E(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public RectF(Android.Graphics.Rect arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#%3Cinit%3E(android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        public RectF(Android.Graphics.RectF arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#%3Cinit%3E(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public RectF(float arg0, float arg1, float arg2, float arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#bottom"/>
        /// </summary>
        public float bottom { get { return IGetField<float>("bottom"); } set { ISetField("bottom", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#left"/>
        /// </summary>
        public float left { get { return IGetField<float>("left"); } set { ISetField("left", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#right"/>
        /// </summary>
        public float right { get { return IGetField<float>("right"); } set { ISetField("right", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#top"/>
        /// </summary>
        public float top { get { return IGetField<float>("top"); } set { ISetField("top", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#intersects(android.graphics.RectF,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Intersects(Android.Graphics.RectF arg0, Android.Graphics.RectF arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "intersects", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#contains(android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Android.Graphics.RectF arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Landroid/graphics/RectF;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#contains(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(float arg0, float arg1, float arg2, float arg3)
        {
            return IExecute<bool>("contains", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#contains(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(float arg0, float arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#intersect(android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersect(Android.Graphics.RectF arg0)
        {
            return IExecuteWithSignature<bool>("intersect", "(Landroid/graphics/RectF;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#intersect(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersect(float arg0, float arg1, float arg2, float arg3)
        {
            return IExecute<bool>("intersect", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#intersects(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(float arg0, float arg1, float arg2, float arg3)
        {
            return IExecute<bool>("intersects", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#setIntersect(android.graphics.RectF,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetIntersect(Android.Graphics.RectF arg0, Android.Graphics.RectF arg1)
        {
            return IExecute<bool>("setIntersect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#centerX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float CenterX()
        {
            return IExecuteWithSignature<float>("centerX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#centerY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float CenterY()
        {
            return IExecuteWithSignature<float>("centerY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#height()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Height()
        {
            return IExecuteWithSignature<float>("height", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#width()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Width()
        {
            return IExecuteWithSignature<float>("width", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#toShortString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToShortString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toShortString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#inset(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Inset(float arg0, float arg1)
        {
            IExecute("inset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#offset(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Offset(float arg0, float arg1)
        {
            IExecute("offset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#offsetTo(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void OffsetTo(float arg0, float arg1)
        {
            IExecute("offsetTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#readFromParcel(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public void ReadFromParcel(Android.Os.Parcel arg0)
        {
            IExecuteWithSignature("readFromParcel", "(Landroid/os/Parcel;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#round(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void Round(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("round", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#roundOut(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void RoundOut(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("roundOut", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#set(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void Set(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#set(android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        public void Set(Android.Graphics.RectF arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/RectF;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#set(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void Set(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("set", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#setEmpty()"/>
        /// </summary>
        public void SetEmpty()
        {
            IExecuteWithSignature("setEmpty", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#sort()"/>
        /// </summary>
        public void Sort()
        {
            IExecuteWithSignature("sort", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#union(android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        public void Union(Android.Graphics.RectF arg0)
        {
            IExecuteWithSignature("union", "(Landroid/graphics/RectF;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#union(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void Union(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("union", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#union(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Union(float arg0, float arg1)
        {
            IExecute("union", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/RectF.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}