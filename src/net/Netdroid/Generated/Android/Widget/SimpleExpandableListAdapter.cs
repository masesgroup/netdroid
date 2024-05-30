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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region SimpleExpandableListAdapter
    public partial class SimpleExpandableListAdapter
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
        /// Handlers initializer for <see cref="SimpleExpandableListAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("newChildView", new System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(NewChildViewEventHandler));
            AddEventHandler("newGroupView", new System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(NewGroupViewEventHandler));
            AddEventHandler("areAllItemsEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(AreAllItemsEnabledEventHandler));
            AddEventHandler("isEmpty", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(IsEmptyEventHandler));
            AddEventHandler("getChildType", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetChildTypeEventHandler));
            AddEventHandler("getChildTypeCount", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetChildTypeCountEventHandler));
            AddEventHandler("getGroupType", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetGroupTypeEventHandler));
            AddEventHandler("getGroupTypeCount", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetGroupTypeCountEventHandler));
            AddEventHandler("getCombinedChildId", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(GetCombinedChildIdEventHandler));
            AddEventHandler("getCombinedGroupId", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(GetCombinedGroupIdEventHandler));
            AddEventHandler("notifyDataSetChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NotifyDataSetChangedEventHandler));
            AddEventHandler("notifyDataSetInvalidated", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NotifyDataSetInvalidatedEventHandler));
            AddEventHandler("onGroupCollapsed", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnGroupCollapsedEventHandler));
            AddEventHandler("onGroupExpanded", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnGroupExpandedEventHandler));
            AddEventHandler("registerDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(RegisterDataSetObserverEventHandler));
            AddEventHandler("unregisterDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(UnregisterDataSetObserverEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleExpandableListAdapter.html#newChildView(boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNewChildView"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool, Android.View.ViewGroup, Android.View.View> OnNewChildView { get; set; } = null;

        void NewChildViewEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
        {
            var methodToExecute = (OnNewChildView != null) ? OnNewChildView : NewChildView;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.View.ViewGroup>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleExpandableListAdapter.html#newChildView(boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public virtual Android.View.View NewChildView(bool arg0, Android.View.ViewGroup arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleExpandableListAdapter.html#newGroupView(boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNewGroupView"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool, Android.View.ViewGroup, Android.View.View> OnNewGroupView { get; set; } = null;

        void NewGroupViewEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
        {
            var methodToExecute = (OnNewGroupView != null) ? OnNewGroupView : NewGroupView;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.View.ViewGroup>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleExpandableListAdapter.html#newGroupView(boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public virtual Android.View.View NewGroupView(bool arg0, Android.View.ViewGroup arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnAreAllItemsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnAreAllItemsEnabled { get; set; } = null;

        void AreAllItemsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnAreAllItemsEnabled != null) ? OnAreAllItemsEnabled : AreAllItemsEnabled;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool AreAllItemsEnabled()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#isEmpty()"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEmpty"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnIsEmpty { get; set; } = null;

        void IsEmptyEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnIsEmpty != null) ? OnIsEmpty : IsEmpty;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEmpty()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildType(int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetChildType"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, int, int> OnGetChildType { get; set; } = null;

        void GetChildTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetChildType != null) ? OnGetChildType : GetChildType;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetChildType(int arg0, int arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildTypeCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetChildTypeCount"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int> OnGetChildTypeCount { get; set; } = null;

        void GetChildTypeCountEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetChildTypeCount != null) ? OnGetChildTypeCount : GetChildTypeCount;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetChildTypeCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupType(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetGroupType"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, int> OnGetGroupType { get; set; } = null;

        void GetGroupTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetGroupType != null) ? OnGetGroupType : GetGroupType;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetGroupType(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupTypeCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetGroupTypeCount"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int> OnGetGroupTypeCount { get; set; } = null;

        void GetGroupTypeCountEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetGroupTypeCount != null) ? OnGetGroupTypeCount : GetGroupTypeCount;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetGroupTypeCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedChildId(long,long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCombinedChildId"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, long, long> OnGetCombinedChildId { get; set; } = null;

        void GetCombinedChildIdEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnGetCombinedChildId != null) ? OnGetCombinedChildId : GetCombinedChildId;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<long>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedChildId(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long GetCombinedChildId(long arg0, long arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedGroupId(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCombinedGroupId"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, long> OnGetCombinedGroupId { get; set; } = null;

        void GetCombinedGroupIdEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnGetCombinedGroupId != null) ? OnGetCombinedGroupId : GetCombinedGroupId;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedGroupId(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long GetCombinedGroupId(long arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotifyDataSetChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnNotifyDataSetChanged { get; set; } = null;

        void NotifyDataSetChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNotifyDataSetChanged != null) ? OnNotifyDataSetChanged : NotifyDataSetChanged;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        public virtual void NotifyDataSetChanged()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotifyDataSetInvalidated"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnNotifyDataSetInvalidated { get; set; } = null;

        void NotifyDataSetInvalidatedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNotifyDataSetInvalidated != null) ? OnNotifyDataSetInvalidated : NotifyDataSetInvalidated;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        public virtual void NotifyDataSetInvalidated()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupCollapsed(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnGroupCollapsed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<int> OnOnGroupCollapsed { get; set; } = null;

        void OnGroupCollapsedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnGroupCollapsed != null) ? OnOnGroupCollapsed : OnGroupCollapsed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupCollapsed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void OnGroupCollapsed(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupExpanded(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnGroupExpanded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<int> OnOnGroupExpanded { get; set; } = null;

        void OnGroupExpandedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnGroupExpanded != null) ? OnOnGroupExpanded : OnGroupExpanded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupExpanded(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void OnGroupExpanded(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRegisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnRegisterDataSetObserver { get; set; } = null;

        void RegisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnRegisterDataSetObserver != null) ? OnRegisterDataSetObserver : RegisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUnregisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnUnregisterDataSetObserver { get; set; } = null;

        void UnregisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnUnregisterDataSetObserver != null) ? OnUnregisterDataSetObserver : UnregisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SimpleExpandableListAdapterDirect
    public partial class SimpleExpandableListAdapterDirect
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildTypeCount()"/> 
        /// </summary>
        public int ChildTypeCount
        {
            get { return IExecute<int>("getChildTypeCount"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupTypeCount()"/> 
        /// </summary>
        public int GroupTypeCount
        {
            get { return IExecute<int>("getGroupTypeCount"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleExpandableListAdapter.html#newChildView(boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public override Android.View.View NewChildView(bool arg0, Android.View.ViewGroup arg1)
        {
            return IExecute<Android.View.View>("newChildView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleExpandableListAdapter.html#newGroupView(boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public override Android.View.View NewGroupView(bool arg0, Android.View.ViewGroup arg1)
        {
            return IExecute<Android.View.View>("newGroupView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool AreAllItemsEnabled()
        {
            return IExecute<bool>("areAllItemsEnabled");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetChildType(int arg0, int arg1)
        {
            return IExecute<int>("getChildType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetGroupType(int arg0)
        {
            return IExecute<int>("getGroupType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedChildId(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long GetCombinedChildId(long arg0, long arg1)
        {
            return IExecute<long>("getCombinedChildId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedGroupId(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long GetCombinedGroupId(long arg0)
        {
            return IExecute<long>("getCombinedGroupId", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        public override void NotifyDataSetChanged()
        {
            IExecute("notifyDataSetChanged");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        public override void NotifyDataSetInvalidated()
        {
            IExecute("notifyDataSetInvalidated");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupCollapsed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnGroupCollapsed(int arg0)
        {
            IExecute("onGroupCollapsed", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupExpanded(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnGroupExpanded(int arg0)
        {
            IExecute("onGroupExpanded", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("registerDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("unregisterDataSetObserver", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}