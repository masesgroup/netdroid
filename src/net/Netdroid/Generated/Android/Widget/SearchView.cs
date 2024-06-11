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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region SearchView
    public partial class SearchView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SearchView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public SearchView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public SearchView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public SearchView(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.SearchView"/> to <see cref="Android.View.CollapsibleActionView"/>
        /// </summary>
        public static implicit operator Android.View.CollapsibleActionView(Android.Widget.SearchView t) => t.Cast<Android.View.CollapsibleActionView>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#getSuggestionsAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.CursorAdapter"/></returns>
        public Android.Widget.CursorAdapter GetSuggestionsAdapter()
        {
            return IExecuteWithSignature<Android.Widget.CursorAdapter>("getSuggestionsAdapter", "()Landroid/widget/CursorAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#getSuggestionsAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.CursorAdapter"/></returns>
        public Android.Widget.CursorAdapter GetSuggestionsAdapterDirect()
        {
            return IExecuteWithSignature<Android.Widget.CursorAdapterDirect, Android.Widget.CursorAdapter>("getSuggestionsAdapter", "()Landroid/widget/CursorAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#isIconfiedByDefault()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsIconfiedByDefault()
        {
            return IExecuteWithSignature<bool>("isIconfiedByDefault", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#isIconified()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIconified()
        {
            return IExecuteWithSignature<bool>("isIconified", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#isIconifiedByDefault()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIconifiedByDefault()
        {
            return IExecuteWithSignature<bool>("isIconifiedByDefault", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#isQueryRefinementEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsQueryRefinementEnabled()
        {
            return IExecuteWithSignature<bool>("isQueryRefinementEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#isSubmitButtonEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSubmitButtonEnabled()
        {
            return IExecuteWithSignature<bool>("isSubmitButtonEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#getImeOptions()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetImeOptions()
        {
            return IExecuteWithSignature<int>("getImeOptions", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#getInputType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInputType()
        {
            return IExecuteWithSignature<int>("getInputType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#getMaxWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxWidth()
        {
            return IExecuteWithSignature<int>("getMaxWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#getQuery()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetQuery()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getQuery", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#getQueryHint()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetQueryHint()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getQueryHint", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#onActionViewCollapsed()"/>
        /// </summary>
        public void OnActionViewCollapsed()
        {
            IExecuteWithSignature("onActionViewCollapsed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#onActionViewExpanded()"/>
        /// </summary>
        public void OnActionViewExpanded()
        {
            IExecuteWithSignature("onActionViewExpanded", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setIconified(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIconified(bool arg0)
        {
            IExecuteWithSignature("setIconified", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setIconifiedByDefault(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIconifiedByDefault(bool arg0)
        {
            IExecuteWithSignature("setIconifiedByDefault", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setImeOptions(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetImeOptions(int arg0)
        {
            IExecuteWithSignature("setImeOptions", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setInputType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetInputType(int arg0)
        {
            IExecuteWithSignature("setInputType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setMaxWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxWidth(int arg0)
        {
            IExecuteWithSignature("setMaxWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setOnCloseListener(android.widget.SearchView.OnCloseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SearchView.OnCloseListener"/></param>
        public void SetOnCloseListener(Android.Widget.SearchView.OnCloseListener arg0)
        {
            IExecuteWithSignature("setOnCloseListener", "(Landroid/widget/SearchView$OnCloseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setOnQueryTextFocusChangeListener(android.view.View.OnFocusChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View.OnFocusChangeListener"/></param>
        public void SetOnQueryTextFocusChangeListener(Android.View.View.OnFocusChangeListener arg0)
        {
            IExecuteWithSignature("setOnQueryTextFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setOnQueryTextListener(android.widget.SearchView.OnQueryTextListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SearchView.OnQueryTextListener"/></param>
        public void SetOnQueryTextListener(Android.Widget.SearchView.OnQueryTextListener arg0)
        {
            IExecuteWithSignature("setOnQueryTextListener", "(Landroid/widget/SearchView$OnQueryTextListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setOnSearchClickListener(android.view.View.OnClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View.OnClickListener"/></param>
        public void SetOnSearchClickListener(Android.View.View.OnClickListener arg0)
        {
            IExecuteWithSignature("setOnSearchClickListener", "(Landroid/view/View$OnClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setOnSuggestionListener(android.widget.SearchView.OnSuggestionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SearchView.OnSuggestionListener"/></param>
        public void SetOnSuggestionListener(Android.Widget.SearchView.OnSuggestionListener arg0)
        {
            IExecuteWithSignature("setOnSuggestionListener", "(Landroid/widget/SearchView$OnSuggestionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setQuery(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetQuery(Java.Lang.CharSequence arg0, bool arg1)
        {
            IExecute("setQuery", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setQueryHint(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetQueryHint(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setQueryHint", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setQueryRefinementEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetQueryRefinementEnabled(bool arg0)
        {
            IExecuteWithSignature("setQueryRefinementEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setSearchableInfo(android.app.SearchableInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.SearchableInfo"/></param>
        public void SetSearchableInfo(Android.App.SearchableInfo arg0)
        {
            IExecuteWithSignature("setSearchableInfo", "(Landroid/app/SearchableInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setSubmitButtonEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSubmitButtonEnabled(bool arg0)
        {
            IExecuteWithSignature("setSubmitButtonEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SearchView.html#setSuggestionsAdapter(android.widget.CursorAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.CursorAdapter"/></param>
        public void SetSuggestionsAdapter(Android.Widget.CursorAdapter arg0)
        {
            IExecuteWithSignature("setSuggestionsAdapter", "(Landroid/widget/CursorAdapter;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnCloseListener
        public partial class OnCloseListener
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
            /// Handlers initializer for <see cref="OnCloseListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onClose", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnCloseEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SearchView.OnCloseListener.html#onClose()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnClose"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<bool> OnOnClose { get; set; } = null;

            void OnCloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnClose != null) ? OnOnClose : OnClose;
                var executionResult = methodToExecute.Invoke();
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnCloseListener.html#onClose()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnClose()
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnCloseListenerDirect
        public partial class OnCloseListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnCloseListener.html#onClose()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public override bool OnClose()
            {
                return IExecuteWithSignature<bool>("onClose", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnQueryTextListener
        public partial class OnQueryTextListener
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
            /// Handlers initializer for <see cref="OnQueryTextListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onQueryTextChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnQueryTextChangeEventHandler));
                AddEventHandler("onQueryTextSubmit", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnQueryTextSubmitEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SearchView.OnQueryTextListener.html#onQueryTextChange(java.lang.String)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnQueryTextChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Java.Lang.String, bool> OnOnQueryTextChange { get; set; } = null;

            void OnQueryTextChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
            {
                var methodToExecute = (OnOnQueryTextChange != null) ? OnOnQueryTextChange : OnQueryTextChange;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnQueryTextListener.html#onQueryTextChange(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnQueryTextChange(Java.Lang.String arg0)
            {
                return default;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SearchView.OnQueryTextListener.html#onQueryTextSubmit(java.lang.String)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnQueryTextSubmit"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Java.Lang.String, bool> OnOnQueryTextSubmit { get; set; } = null;

            void OnQueryTextSubmitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
            {
                var methodToExecute = (OnOnQueryTextSubmit != null) ? OnOnQueryTextSubmit : OnQueryTextSubmit;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnQueryTextListener.html#onQueryTextSubmit(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnQueryTextSubmit(Java.Lang.String arg0)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnQueryTextListenerDirect
        public partial class OnQueryTextListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnQueryTextListener.html#onQueryTextChange(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnQueryTextChange(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<bool>("onQueryTextChange", "(Ljava/lang/String;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnQueryTextListener.html#onQueryTextSubmit(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnQueryTextSubmit(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<bool>("onQueryTextSubmit", "(Ljava/lang/String;)Z", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnSuggestionListener
        public partial class OnSuggestionListener
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
            /// Handlers initializer for <see cref="OnSuggestionListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSuggestionClick", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnSuggestionClickEventHandler));
                AddEventHandler("onSuggestionSelect", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnSuggestionSelectEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SearchView.OnSuggestionListener.html#onSuggestionClick(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSuggestionClick"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<int, bool> OnOnSuggestionClick { get; set; } = null;

            void OnSuggestionClickEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnSuggestionClick != null) ? OnOnSuggestionClick : OnSuggestionClick;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnSuggestionListener.html#onSuggestionClick(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnSuggestionClick(int arg0)
            {
                return default;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SearchView.OnSuggestionListener.html#onSuggestionSelect(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSuggestionSelect"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<int, bool> OnOnSuggestionSelect { get; set; } = null;

            void OnSuggestionSelectEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnSuggestionSelect != null) ? OnOnSuggestionSelect : OnSuggestionSelect;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnSuggestionListener.html#onSuggestionSelect(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnSuggestionSelect(int arg0)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnSuggestionListenerDirect
        public partial class OnSuggestionListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnSuggestionListener.html#onSuggestionClick(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnSuggestionClick(int arg0)
            {
                return IExecuteWithSignature<bool>("onSuggestionClick", "(I)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SearchView.OnSuggestionListener.html#onSuggestionSelect(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnSuggestionSelect(int arg0)
            {
                return IExecuteWithSignature<bool>("onSuggestionSelect", "(I)Z", arg0);
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