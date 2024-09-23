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

namespace Android.Util
{
    #region EventLogTags declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/EventLogTags.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class EventLogTags : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EventLogTags>
    {
        const string _bridgeClassName = "android.util.EventLogTags";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EventLogTags() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EventLogTags(params object[] args) : base(args) { }
    
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
        #region Description declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLogTags.Description.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Description : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Description>
        {
            const string _bridgeClassName = "android.util.EventLogTags$Description";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Description() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Description(params object[] args) : base(args) { }
        
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

    #region EventLogTags implementation
    public partial class EventLogTags
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLogTags.html#%3Cinit%3E(java.io.BufferedReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.BufferedReader"/></param>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public EventLogTags(Java.Io.BufferedReader arg0)
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
        /// <see href="https://developer.android.com/reference/android/util/EventLogTags.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.EventLogTags.Description"/></returns>
        [global::System.Obsolete()]
        public Android.Util.EventLogTags.Description Get(int arg0)
        {
            return IExecuteWithSignature<Android.Util.EventLogTags.Description>("get", "(I)Landroid/util/EventLogTags$Description;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLogTags.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Util.EventLogTags.Description"/></returns>
        [global::System.Obsolete()]
        public Android.Util.EventLogTags.Description Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Util.EventLogTags.Description>("get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Description implementation
        public partial class Description
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/util/EventLogTags.Description.html#mTag"/>
            /// </summary>
            [global::System.Obsolete()]
            public int mTag { get { if (!_mTagReady) { _mTagContent = IGetField<int>("mTag"); _mTagReady = true; } return _mTagContent; } }
            private int _mTagContent = default;
            private bool _mTagReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/util/EventLogTags.Description.html#mName"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.String mName { get { if (!_mNameReady) { _mNameContent = IGetField<Java.Lang.String>("mName"); _mNameReady = true; } return _mNameContent; } }
            private Java.Lang.String _mNameContent = default;
            private bool _mNameReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
        
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