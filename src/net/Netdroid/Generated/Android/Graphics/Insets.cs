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
    #region Insets declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/Insets.html"/>
    /// </summary>
    public partial class Insets : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.graphics.Insets";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Insets() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Insets(params object[] args) : base(args) { }
    
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

    #region Insets implementation
    public partial class Insets
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#bottom"/>
        /// </summary>
        public int bottom { get { if (!_bottomReady) { _bottomContent = IGetField<int>("bottom"); _bottomReady = true; } return _bottomContent; } }
        private int _bottomContent = default;
        private bool _bottomReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#left"/>
        /// </summary>
        public int left { get { if (!_leftReady) { _leftContent = IGetField<int>("left"); _leftReady = true; } return _leftContent; } }
        private int _leftContent = default;
        private bool _leftReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#right"/>
        /// </summary>
        public int right { get { if (!_rightReady) { _rightContent = IGetField<int>("right"); _rightReady = true; } return _rightContent; } }
        private int _rightContent = default;
        private bool _rightReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#top"/>
        /// </summary>
        public int top { get { if (!_topReady) { _topContent = IGetField<int>("top"); _topReady = true; } return _topContent; } }
        private int _topContent = default;
        private bool _topReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#NONE"/>
        /// </summary>
        public static Android.Graphics.Insets NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Android.Graphics.Insets>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static Android.Graphics.Insets _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#add(android.graphics.Insets,android.graphics.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Insets"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Insets"/></param>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public static Android.Graphics.Insets Add(Android.Graphics.Insets arg0, Android.Graphics.Insets arg1)
        {
            return SExecute<Android.Graphics.Insets>(LocalBridgeClazz, "add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#max(android.graphics.Insets,android.graphics.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Insets"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Insets"/></param>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public static Android.Graphics.Insets Max(Android.Graphics.Insets arg0, Android.Graphics.Insets arg1)
        {
            return SExecute<Android.Graphics.Insets>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#min(android.graphics.Insets,android.graphics.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Insets"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Insets"/></param>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public static Android.Graphics.Insets Min(Android.Graphics.Insets arg0, Android.Graphics.Insets arg1)
        {
            return SExecute<Android.Graphics.Insets>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#of(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public static Android.Graphics.Insets Of(Android.Graphics.Rect arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Insets>(LocalBridgeClazz, "of", "(Landroid/graphics/Rect;)Landroid/graphics/Insets;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#of(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public static Android.Graphics.Insets Of(int arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Android.Graphics.Insets>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#subtract(android.graphics.Insets,android.graphics.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Insets"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Insets"/></param>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public static Android.Graphics.Insets Subtract(Android.Graphics.Insets arg0, Android.Graphics.Insets arg1)
        {
            return SExecute<Android.Graphics.Insets>(LocalBridgeClazz, "subtract", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Insets.html#writeToParcel(android.os.Parcel,int)"/>
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