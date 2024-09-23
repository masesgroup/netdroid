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

namespace Android.Content
{
    #region UriRelativeFilterGroup declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html"/>
    /// </summary>
    public partial class UriRelativeFilterGroup : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UriRelativeFilterGroup>
    {
        const string _bridgeClassName = "android.content.UriRelativeFilterGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UriRelativeFilterGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UriRelativeFilterGroup(params object[] args) : base(args) { }
    
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

    #region UriRelativeFilterGroup implementation
    public partial class UriRelativeFilterGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public UriRelativeFilterGroup(int arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html#ACTION_ALLOW"/>
        /// </summary>
        public static int ACTION_ALLOW { get { if (!_ACTION_ALLOWReady) { _ACTION_ALLOWContent = SGetField<int>(LocalBridgeClazz, "ACTION_ALLOW"); _ACTION_ALLOWReady = true; } return _ACTION_ALLOWContent; } }
        private static int _ACTION_ALLOWContent = default;
        private static bool _ACTION_ALLOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html#ACTION_BLOCK"/>
        /// </summary>
        public static int ACTION_BLOCK { get { if (!_ACTION_BLOCKReady) { _ACTION_BLOCKContent = SGetField<int>(LocalBridgeClazz, "ACTION_BLOCK"); _ACTION_BLOCKReady = true; } return _ACTION_BLOCKContent; } }
        private static int _ACTION_BLOCKContent = default;
        private static bool _ACTION_BLOCKReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html#matchData(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MatchData(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<bool>("matchData", "(Landroid/net/Uri;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html#getAction()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAction()
        {
            return IExecuteWithSignature<int>("getAction", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html#getUriRelativeFilters()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Android.Content.UriRelativeFilter> GetUriRelativeFilters()
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Content.UriRelativeFilter>>("getUriRelativeFilters", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriRelativeFilterGroup.html#addUriRelativeFilter(android.content.UriRelativeFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.UriRelativeFilter"/></param>
        public void AddUriRelativeFilter(Android.Content.UriRelativeFilter arg0)
        {
            IExecuteWithSignature("addUriRelativeFilter", "(Landroid/content/UriRelativeFilter;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}