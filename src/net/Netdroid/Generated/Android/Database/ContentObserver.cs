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

namespace Android.Database
{
    #region ContentObserver declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html"/>
    /// </summary>
    public partial class ContentObserver : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ContentObserver>
    {
        const string _bridgeClassName = "android.database.ContentObserver";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ContentObserver class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ContentObserver() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ContentObserver class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ContentObserver(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region ContentObserver implementation
    public partial class ContentObserver
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#%3Cinit%3E(android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        public ContentObserver(Android.Os.Handler arg0)
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
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#deliverSelfNotifications()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool DeliverSelfNotifications()
        {
            return IExecuteWithSignature<bool>("deliverSelfNotifications", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#dispatchChange(boolean,android.net.Uri,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void DispatchChange(bool arg0, Android.Net.Uri arg1, int arg2)
        {
            IExecuteWithSignature("dispatchChange", "(ZLandroid/net/Uri;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#dispatchChange(boolean,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        public void DispatchChange(bool arg0, Android.Net.Uri arg1)
        {
            IExecuteWithSignature("dispatchChange", "(ZLandroid/net/Uri;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#dispatchChange(boolean,java.util.Collection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void DispatchChange(bool arg0, Java.Util.Collection<Android.Net.Uri> arg1, int arg2)
        {
            IExecuteWithSignature("dispatchChange", "(ZLjava/util/Collection;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#dispatchChange(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void DispatchChange(bool arg0)
        {
            IExecuteWithSignature("dispatchChange", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#onChange(boolean,android.net.Uri,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnChange(bool arg0, Android.Net.Uri arg1, int arg2)
        {
            IExecuteWithSignature("onChange", "(ZLandroid/net/Uri;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#onChange(boolean,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        public void OnChange(bool arg0, Android.Net.Uri arg1)
        {
            IExecuteWithSignature("onChange", "(ZLandroid/net/Uri;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#onChange(boolean,java.util.Collection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnChange(bool arg0, Java.Util.Collection<Android.Net.Uri> arg1, int arg2)
        {
            IExecuteWithSignature("onChange", "(ZLjava/util/Collection;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObserver.html#onChange(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnChange(bool arg0)
        {
            IExecuteWithSignature("onChange", "(Z)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}