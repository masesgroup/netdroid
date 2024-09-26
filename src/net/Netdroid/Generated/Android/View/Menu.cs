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

namespace Android.View
{
    #region Menu declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/Menu.html"/>
    /// </summary>
    public partial class Menu : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Menu>
    {
        const string _bridgeClassName = "android.view.Menu";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Menu class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Menu() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Menu class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Menu(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IMenu
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMenu
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Menu implementation
    public partial class Menu : Android.View.IMenu
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#CATEGORY_ALTERNATIVE"/>
        /// </summary>
        public static int CATEGORY_ALTERNATIVE { get { if (!_CATEGORY_ALTERNATIVEReady) { _CATEGORY_ALTERNATIVEContent = SGetField<int>(LocalBridgeClazz, "CATEGORY_ALTERNATIVE"); _CATEGORY_ALTERNATIVEReady = true; } return _CATEGORY_ALTERNATIVEContent; } }
        private static int _CATEGORY_ALTERNATIVEContent = default;
        private static bool _CATEGORY_ALTERNATIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#CATEGORY_CONTAINER"/>
        /// </summary>
        public static int CATEGORY_CONTAINER { get { if (!_CATEGORY_CONTAINERReady) { _CATEGORY_CONTAINERContent = SGetField<int>(LocalBridgeClazz, "CATEGORY_CONTAINER"); _CATEGORY_CONTAINERReady = true; } return _CATEGORY_CONTAINERContent; } }
        private static int _CATEGORY_CONTAINERContent = default;
        private static bool _CATEGORY_CONTAINERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#CATEGORY_SECONDARY"/>
        /// </summary>
        public static int CATEGORY_SECONDARY { get { if (!_CATEGORY_SECONDARYReady) { _CATEGORY_SECONDARYContent = SGetField<int>(LocalBridgeClazz, "CATEGORY_SECONDARY"); _CATEGORY_SECONDARYReady = true; } return _CATEGORY_SECONDARYContent; } }
        private static int _CATEGORY_SECONDARYContent = default;
        private static bool _CATEGORY_SECONDARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#CATEGORY_SYSTEM"/>
        /// </summary>
        public static int CATEGORY_SYSTEM { get { if (!_CATEGORY_SYSTEMReady) { _CATEGORY_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "CATEGORY_SYSTEM"); _CATEGORY_SYSTEMReady = true; } return _CATEGORY_SYSTEMContent; } }
        private static int _CATEGORY_SYSTEMContent = default;
        private static bool _CATEGORY_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#FIRST"/>
        /// </summary>
        public static int FIRST { get { if (!_FIRSTReady) { _FIRSTContent = SGetField<int>(LocalBridgeClazz, "FIRST"); _FIRSTReady = true; } return _FIRSTContent; } }
        private static int _FIRSTContent = default;
        private static bool _FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#FLAG_ALWAYS_PERFORM_CLOSE"/>
        /// </summary>
        public static int FLAG_ALWAYS_PERFORM_CLOSE { get { if (!_FLAG_ALWAYS_PERFORM_CLOSEReady) { _FLAG_ALWAYS_PERFORM_CLOSEContent = SGetField<int>(LocalBridgeClazz, "FLAG_ALWAYS_PERFORM_CLOSE"); _FLAG_ALWAYS_PERFORM_CLOSEReady = true; } return _FLAG_ALWAYS_PERFORM_CLOSEContent; } }
        private static int _FLAG_ALWAYS_PERFORM_CLOSEContent = default;
        private static bool _FLAG_ALWAYS_PERFORM_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#FLAG_APPEND_TO_GROUP"/>
        /// </summary>
        public static int FLAG_APPEND_TO_GROUP { get { if (!_FLAG_APPEND_TO_GROUPReady) { _FLAG_APPEND_TO_GROUPContent = SGetField<int>(LocalBridgeClazz, "FLAG_APPEND_TO_GROUP"); _FLAG_APPEND_TO_GROUPReady = true; } return _FLAG_APPEND_TO_GROUPContent; } }
        private static int _FLAG_APPEND_TO_GROUPContent = default;
        private static bool _FLAG_APPEND_TO_GROUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#FLAG_PERFORM_NO_CLOSE"/>
        /// </summary>
        public static int FLAG_PERFORM_NO_CLOSE { get { if (!_FLAG_PERFORM_NO_CLOSEReady) { _FLAG_PERFORM_NO_CLOSEContent = SGetField<int>(LocalBridgeClazz, "FLAG_PERFORM_NO_CLOSE"); _FLAG_PERFORM_NO_CLOSEReady = true; } return _FLAG_PERFORM_NO_CLOSEContent; } }
        private static int _FLAG_PERFORM_NO_CLOSEContent = default;
        private static bool _FLAG_PERFORM_NO_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#NONE"/>
        /// </summary>
        public static int NONE { get { if (!_NONEReady) { _NONEContent = SGetField<int>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static int _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#SUPPORTED_MODIFIERS_MASK"/>
        /// </summary>
        public static int SUPPORTED_MODIFIERS_MASK { get { if (!_SUPPORTED_MODIFIERS_MASKReady) { _SUPPORTED_MODIFIERS_MASKContent = SGetField<int>(LocalBridgeClazz, "SUPPORTED_MODIFIERS_MASK"); _SUPPORTED_MODIFIERS_MASKReady = true; } return _SUPPORTED_MODIFIERS_MASKContent; } }
        private static int _SUPPORTED_MODIFIERS_MASKContent = default;
        private static bool _SUPPORTED_MODIFIERS_MASKReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#add(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem Add(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("add", "(IIII)Landroid/view/MenuItem;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#add(int,int,int,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem Add(int arg0, int arg1, int arg2, Java.Lang.CharSequence arg3)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#add(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem Add(int arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("add", "(I)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#add(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem Add(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#findItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem FindItem(int arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("findItem", "(I)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem GetItem(int arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("getItem", "(I)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#addSubMenu(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu AddSubMenu(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("addSubMenu", "(IIII)Landroid/view/SubMenu;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#addSubMenu(int,int,int,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu AddSubMenu(int arg0, int arg1, int arg2, Java.Lang.CharSequence arg3)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#addSubMenu(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu AddSubMenu(int arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("addSubMenu", "(I)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#addSubMenu(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu AddSubMenu(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#hasVisibleItems()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasVisibleItems()
        {
            return IExecuteWithSignature<bool>("hasVisibleItems", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#isShortcutKey(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsShortcutKey(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecuteWithSignature<bool>("isShortcutKey", "(ILandroid/view/KeyEvent;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#performIdentifierAction(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformIdentifierAction(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("performIdentifierAction", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#performShortcut(int,android.view.KeyEvent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformShortcut(int arg0, Android.View.KeyEvent arg1, int arg2)
        {
            return IExecuteWithSignature<bool>("performShortcut", "(ILandroid/view/KeyEvent;I)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#addIntentOptions(int,int,int,android.content.ComponentName,android.content.Intent[],android.content.Intent,int,android.view.MenuItem[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg4"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg5"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="int"/></returns>
        public int AddIntentOptions(int arg0, int arg1, int arg2, Android.Content.ComponentName arg3, Android.Content.Intent[] arg4, Android.Content.Intent arg5, int arg6, Android.View.MenuItem[] arg7)
        {
            return IExecuteWithSignature<int>("addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#removeGroup(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveGroup(int arg0)
        {
            IExecuteWithSignature("removeGroup", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#removeItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveItem(int arg0)
        {
            IExecuteWithSignature("removeItem", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#setGroupCheckable(int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void SetGroupCheckable(int arg0, bool arg1, bool arg2)
        {
            IExecuteWithSignature("setGroupCheckable", "(IZZ)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#setGroupEnabled(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetGroupEnabled(int arg0, bool arg1)
        {
            IExecuteWithSignature("setGroupEnabled", "(IZ)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#setGroupVisible(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetGroupVisible(int arg0, bool arg1)
        {
            IExecuteWithSignature("setGroupVisible", "(IZ)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#setQwertyMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetQwertyMode(bool arg0)
        {
            IExecuteWithSignature("setQwertyMode", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Menu.html#setGroupDividerEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetGroupDividerEnabled(bool arg0)
        {
            IExecuteWithSignature("setGroupDividerEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}