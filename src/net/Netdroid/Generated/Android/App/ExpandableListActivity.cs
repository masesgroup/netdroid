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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App
{
    #region ExpandableListActivity
    public partial class ExpandableListActivity
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
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#getExpandableListAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ExpandableListAdapter"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ExpandableListAdapter GetExpandableListAdapter()
        {
            return IExecuteWithSignature<Android.Widget.ExpandableListAdapter>("getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#getExpandableListAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ExpandableListAdapter"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ExpandableListAdapter GetExpandableListAdapterDirect()
        {
            return IExecuteWithSignature<Android.Widget.ExpandableListAdapterDirect, Android.Widget.ExpandableListAdapter>("getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#getExpandableListView()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ExpandableListView"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ExpandableListView GetExpandableListView()
        {
            return IExecuteWithSignature<Android.Widget.ExpandableListView>("getExpandableListView", "()Landroid/widget/ExpandableListView;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#onChildClick(android.widget.ExpandableListView,android.view.View,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ExpandableListView"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnChildClick(Android.Widget.ExpandableListView arg0, Android.View.View arg1, int arg2, int arg3, long arg4)
        {
            return IExecute<bool>("onChildClick", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#setSelectedChild(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool SetSelectedChild(int arg0, int arg1, bool arg2)
        {
            return IExecute<bool>("setSelectedChild", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#getSelectedId()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetSelectedId()
        {
            return IExecuteWithSignature<long>("getSelectedId", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#getSelectedPosition()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetSelectedPosition()
        {
            return IExecuteWithSignature<long>("getSelectedPosition", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#onGroupCollapse(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void OnGroupCollapse(int arg0)
        {
            IExecuteWithSignature("onGroupCollapse", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#onGroupExpand(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void OnGroupExpand(int arg0)
        {
            IExecuteWithSignature("onGroupExpand", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#setListAdapter(android.widget.ExpandableListAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ExpandableListAdapter"/></param>
        [global::System.Obsolete()]
        public void SetListAdapter(Android.Widget.ExpandableListAdapter arg0)
        {
            IExecuteWithSignature("setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ExpandableListActivity.html#setSelectedGroup(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSelectedGroup(int arg0)
        {
            IExecuteWithSignature("setSelectedGroup", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}