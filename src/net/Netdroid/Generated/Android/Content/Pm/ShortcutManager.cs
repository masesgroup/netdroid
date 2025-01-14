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

namespace Android.Content.Pm
{
    #region ShortcutManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html"/>
    /// </summary>
    public partial class ShortcutManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ShortcutManager>
    {
        const string _bridgeClassName = "android.content.pm.ShortcutManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ShortcutManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ShortcutManager(params object[] args) : base(args) { }
    
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

    #region ShortcutManager implementation
    public partial class ShortcutManager
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#FLAG_MATCH_CACHED"/>
        /// </summary>
        public static int FLAG_MATCH_CACHED { get { if (!_FLAG_MATCH_CACHEDReady) { _FLAG_MATCH_CACHEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_MATCH_CACHED"); _FLAG_MATCH_CACHEDReady = true; } return _FLAG_MATCH_CACHEDContent; } }
        private static int _FLAG_MATCH_CACHEDContent = default;
        private static bool _FLAG_MATCH_CACHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#FLAG_MATCH_DYNAMIC"/>
        /// </summary>
        public static int FLAG_MATCH_DYNAMIC { get { if (!_FLAG_MATCH_DYNAMICReady) { _FLAG_MATCH_DYNAMICContent = SGetField<int>(LocalBridgeClazz, "FLAG_MATCH_DYNAMIC"); _FLAG_MATCH_DYNAMICReady = true; } return _FLAG_MATCH_DYNAMICContent; } }
        private static int _FLAG_MATCH_DYNAMICContent = default;
        private static bool _FLAG_MATCH_DYNAMICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#FLAG_MATCH_MANIFEST"/>
        /// </summary>
        public static int FLAG_MATCH_MANIFEST { get { if (!_FLAG_MATCH_MANIFESTReady) { _FLAG_MATCH_MANIFESTContent = SGetField<int>(LocalBridgeClazz, "FLAG_MATCH_MANIFEST"); _FLAG_MATCH_MANIFESTReady = true; } return _FLAG_MATCH_MANIFESTContent; } }
        private static int _FLAG_MATCH_MANIFESTContent = default;
        private static bool _FLAG_MATCH_MANIFESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#FLAG_MATCH_PINNED"/>
        /// </summary>
        public static int FLAG_MATCH_PINNED { get { if (!_FLAG_MATCH_PINNEDReady) { _FLAG_MATCH_PINNEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_MATCH_PINNED"); _FLAG_MATCH_PINNEDReady = true; } return _FLAG_MATCH_PINNEDContent; } }
        private static int _FLAG_MATCH_PINNEDContent = default;
        private static bool _FLAG_MATCH_PINNEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#createShortcutResultIntent(android.content.pm.ShortcutInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.ShortcutInfo"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateShortcutResultIntent(Android.Content.Pm.ShortcutInfo arg0)
        {
            return IExecuteWithSignature<Android.Content.Intent>("createShortcutResultIntent", "(Landroid/content/pm/ShortcutInfo;)Landroid/content/Intent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#addDynamicShortcuts(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddDynamicShortcuts(Java.Util.List<Android.Content.Pm.ShortcutInfo> arg0)
        {
            return IExecuteWithSignature<bool>("addDynamicShortcuts", "(Ljava/util/List;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#isRateLimitingActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRateLimitingActive()
        {
            return IExecuteWithSignature<bool>("isRateLimitingActive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#isRequestPinShortcutSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRequestPinShortcutSupported()
        {
            return IExecuteWithSignature<bool>("isRequestPinShortcutSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#requestPinShortcut(android.content.pm.ShortcutInfo,android.content.IntentSender)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.ShortcutInfo"/></param>
        /// <param name="arg1"><see cref="Android.Content.IntentSender"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestPinShortcut(Android.Content.Pm.ShortcutInfo arg0, Android.Content.IntentSender arg1)
        {
            return IExecuteWithSignature<bool>("requestPinShortcut", "(Landroid/content/pm/ShortcutInfo;Landroid/content/IntentSender;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#setDynamicShortcuts(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetDynamicShortcuts(Java.Util.List<Android.Content.Pm.ShortcutInfo> arg0)
        {
            return IExecuteWithSignature<bool>("setDynamicShortcuts", "(Ljava/util/List;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#updateShortcuts(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateShortcuts(Java.Util.List<Android.Content.Pm.ShortcutInfo> arg0)
        {
            return IExecuteWithSignature<bool>("updateShortcuts", "(Ljava/util/List;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#getIconMaxHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIconMaxHeight()
        {
            return IExecuteWithSignature<int>("getIconMaxHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#getIconMaxWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIconMaxWidth()
        {
            return IExecuteWithSignature<int>("getIconMaxWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#getMaxShortcutCountPerActivity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxShortcutCountPerActivity()
        {
            return IExecuteWithSignature<int>("getMaxShortcutCountPerActivity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#getDynamicShortcuts()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.ShortcutInfo> GetDynamicShortcuts()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.ShortcutInfo>>("getDynamicShortcuts", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#getManifestShortcuts()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.ShortcutInfo> GetManifestShortcuts()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.ShortcutInfo>>("getManifestShortcuts", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#getPinnedShortcuts()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.ShortcutInfo> GetPinnedShortcuts()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.ShortcutInfo>>("getPinnedShortcuts", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#getShortcuts(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.ShortcutInfo> GetShortcuts(int arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.ShortcutInfo>>("getShortcuts", "(I)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#disableShortcuts(java.util.List,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        public void DisableShortcuts(Java.Util.List<Java.Lang.String> arg0, Java.Lang.CharSequence arg1)
        {
            IExecuteWithSignature("disableShortcuts", "(Ljava/util/List;Ljava/lang/CharSequence;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#disableShortcuts(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void DisableShortcuts(Java.Util.List<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("disableShortcuts", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#enableShortcuts(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void EnableShortcuts(Java.Util.List<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("enableShortcuts", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#pushDynamicShortcut(android.content.pm.ShortcutInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.ShortcutInfo"/></param>
        public void PushDynamicShortcut(Android.Content.Pm.ShortcutInfo arg0)
        {
            IExecuteWithSignature("pushDynamicShortcut", "(Landroid/content/pm/ShortcutInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#removeAllDynamicShortcuts()"/>
        /// </summary>
        public void RemoveAllDynamicShortcuts()
        {
            IExecuteWithSignature("removeAllDynamicShortcuts", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#removeDynamicShortcuts(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void RemoveDynamicShortcuts(Java.Util.List<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("removeDynamicShortcuts", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#removeLongLivedShortcuts(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void RemoveLongLivedShortcuts(Java.Util.List<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("removeLongLivedShortcuts", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutManager.html#reportShortcutUsed(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ReportShortcutUsed(Java.Lang.String arg0)
        {
            IExecuteWithSignature("reportShortcutUsed", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}