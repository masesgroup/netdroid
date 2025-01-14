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

namespace Android.App
{
    #region ListFragment declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/ListFragment.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ListFragment : Android.App.Fragment
    {
        const string _bridgeClassName = "android.app.ListFragment";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListFragment() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ListFragment(params object[] args) : base(args) { }
    
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

    #region ListFragment implementation
    public partial class ListFragment
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
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#getListAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ListAdapter GetListAdapter()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapter>("getListAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#getListAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ListAdapter GetListAdapterDirect()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapterDirect, Android.Widget.ListAdapter>("getListAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#getListView()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListView"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ListView GetListView()
        {
            return IExecuteWithSignature<Android.Widget.ListView>("getListView", "()Landroid/widget/ListView;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#getSelectedItemPosition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetSelectedItemPosition()
        {
            return IExecuteWithSignature<int>("getSelectedItemPosition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#getSelectedItemId()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetSelectedItemId()
        {
            return IExecuteWithSignature<long>("getSelectedItemId", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#onListItemClick(android.widget.ListView,android.view.View,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ListView"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void OnListItemClick(Android.Widget.ListView arg0, Android.View.View arg1, int arg2, long arg3)
        {
            IExecuteWithSignature("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#setEmptyText(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void SetEmptyText(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setEmptyText", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#setListAdapter(android.widget.ListAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ListAdapter"/></param>
        [global::System.Obsolete()]
        public void SetListAdapter(Android.Widget.ListAdapter arg0)
        {
            IExecuteWithSignature("setListAdapter", "(Landroid/widget/ListAdapter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#setListShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetListShown(bool arg0)
        {
            IExecuteWithSignature("setListShown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#setListShownNoAnimation(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetListShownNoAnimation(bool arg0)
        {
            IExecuteWithSignature("setListShownNoAnimation", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ListFragment.html#setSelection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSelection(int arg0)
        {
            IExecuteWithSignature("setSelection", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}