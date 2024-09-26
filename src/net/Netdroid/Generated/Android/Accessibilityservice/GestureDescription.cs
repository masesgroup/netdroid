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

namespace Android.Accessibilityservice
{
    #region GestureDescription declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html"/>
    /// </summary>
    public partial class GestureDescription : MASES.JCOBridge.C2JBridge.JVMBridgeBase<GestureDescription>
    {
        const string _bridgeClassName = "android.accessibilityservice.GestureDescription";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GestureDescription() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GestureDescription(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.accessibilityservice.GestureDescription$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region StrokeDescription declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html"/>
        /// </summary>
        public partial class StrokeDescription : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StrokeDescription>
        {
            const string _bridgeClassName = "android.accessibilityservice.GestureDescription$StrokeDescription";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public StrokeDescription() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public StrokeDescription(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region GestureDescription implementation
    public partial class GestureDescription
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getMaxStrokeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxStrokeCount()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxStrokeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getMaxGestureDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetMaxGestureDuration()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getMaxGestureDuration", "()J");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getStroke(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Accessibilityservice.GestureDescription.StrokeDescription"/></returns>
        public Android.Accessibilityservice.GestureDescription.StrokeDescription GetStroke(int arg0)
        {
            return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription.StrokeDescription>("getStroke", "(I)Landroid/accessibilityservice/GestureDescription$StrokeDescription;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getDisplayId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDisplayId()
        {
            return IExecuteWithSignature<int>("getDisplayId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getStrokeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStrokeCount()
        {
            return IExecuteWithSignature<int>("getStrokeCount", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription"/></returns>
            public Android.Accessibilityservice.GestureDescription Build()
            {
                return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription>("build", "()Landroid/accessibilityservice/GestureDescription;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.Builder.html#addStroke(android.accessibilityservice.GestureDescription.StrokeDescription)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Accessibilityservice.GestureDescription.StrokeDescription"/></param>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription.Builder"/></returns>
            public Android.Accessibilityservice.GestureDescription.Builder AddStroke(Android.Accessibilityservice.GestureDescription.StrokeDescription arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription.Builder>("addStroke", "(Landroid/accessibilityservice/GestureDescription$StrokeDescription;)Landroid/accessibilityservice/GestureDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.Builder.html#setDisplayId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription.Builder"/></returns>
            public Android.Accessibilityservice.GestureDescription.Builder SetDisplayId(int arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription.Builder>("setDisplayId", "(I)Landroid/accessibilityservice/GestureDescription$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StrokeDescription implementation
        public partial class StrokeDescription
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#%3Cinit%3E(android.graphics.Path,long,long,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="bool"/></param>
            public StrokeDescription(Android.Graphics.Path arg0, long arg1, long arg2, bool arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#%3Cinit%3E(android.graphics.Path,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public StrokeDescription(Android.Graphics.Path arg0, long arg1, long arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#continueStroke(android.graphics.Path,long,long,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="bool"/></param>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription.StrokeDescription"/></returns>
            public Android.Accessibilityservice.GestureDescription.StrokeDescription ContinueStroke(Android.Graphics.Path arg0, long arg1, long arg2, bool arg3)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription.StrokeDescription>("continueStroke", "(Landroid/graphics/Path;JJZ)Landroid/accessibilityservice/GestureDescription$StrokeDescription;", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#getPath()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Path"/></returns>
            public Android.Graphics.Path GetPath()
            {
                return IExecuteWithSignature<Android.Graphics.Path>("getPath", "()Landroid/graphics/Path;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#willContinue()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool WillContinue()
            {
                return IExecuteWithSignature<bool>("willContinue", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#getDuration()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetDuration()
            {
                return IExecuteWithSignature<long>("getDuration", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#getStartTime()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetStartTime()
            {
                return IExecuteWithSignature<long>("getStartTime", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}