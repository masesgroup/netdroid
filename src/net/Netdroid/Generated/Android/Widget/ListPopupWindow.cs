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

namespace Android.Widget
{
    #region ListPopupWindow declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html"/>
    /// </summary>
    public partial class ListPopupWindow : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ListPopupWindow>
    {
        const string _bridgeClassName = "android.widget.ListPopupWindow";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListPopupWindow() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ListPopupWindow(params object[] args) : base(args) { }
    
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

    #region ListPopupWindow implementation
    public partial class ListPopupWindow
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ListPopupWindow(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ListPopupWindow(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ListPopupWindow(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ListPopupWindow(Android.Content.Context arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#INPUT_METHOD_FROM_FOCUSABLE"/>
        /// </summary>
        public static int INPUT_METHOD_FROM_FOCUSABLE { get { if (!_INPUT_METHOD_FROM_FOCUSABLEReady) { _INPUT_METHOD_FROM_FOCUSABLEContent = SGetField<int>(LocalBridgeClazz, "INPUT_METHOD_FROM_FOCUSABLE"); _INPUT_METHOD_FROM_FOCUSABLEReady = true; } return _INPUT_METHOD_FROM_FOCUSABLEContent; } }
        private static int _INPUT_METHOD_FROM_FOCUSABLEContent = default;
        private static bool _INPUT_METHOD_FROM_FOCUSABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#INPUT_METHOD_NEEDED"/>
        /// </summary>
        public static int INPUT_METHOD_NEEDED { get { if (!_INPUT_METHOD_NEEDEDReady) { _INPUT_METHOD_NEEDEDContent = SGetField<int>(LocalBridgeClazz, "INPUT_METHOD_NEEDED"); _INPUT_METHOD_NEEDEDReady = true; } return _INPUT_METHOD_NEEDEDContent; } }
        private static int _INPUT_METHOD_NEEDEDContent = default;
        private static bool _INPUT_METHOD_NEEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#INPUT_METHOD_NOT_NEEDED"/>
        /// </summary>
        public static int INPUT_METHOD_NOT_NEEDED { get { if (!_INPUT_METHOD_NOT_NEEDEDReady) { _INPUT_METHOD_NOT_NEEDEDContent = SGetField<int>(LocalBridgeClazz, "INPUT_METHOD_NOT_NEEDED"); _INPUT_METHOD_NOT_NEEDEDReady = true; } return _INPUT_METHOD_NOT_NEEDEDContent; } }
        private static int _INPUT_METHOD_NOT_NEEDEDContent = default;
        private static bool _INPUT_METHOD_NOT_NEEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#MATCH_PARENT"/>
        /// </summary>
        public static int MATCH_PARENT { get { if (!_MATCH_PARENTReady) { _MATCH_PARENTContent = SGetField<int>(LocalBridgeClazz, "MATCH_PARENT"); _MATCH_PARENTReady = true; } return _MATCH_PARENTContent; } }
        private static int _MATCH_PARENTContent = default;
        private static bool _MATCH_PARENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#POSITION_PROMPT_ABOVE"/>
        /// </summary>
        public static int POSITION_PROMPT_ABOVE { get { if (!_POSITION_PROMPT_ABOVEReady) { _POSITION_PROMPT_ABOVEContent = SGetField<int>(LocalBridgeClazz, "POSITION_PROMPT_ABOVE"); _POSITION_PROMPT_ABOVEReady = true; } return _POSITION_PROMPT_ABOVEContent; } }
        private static int _POSITION_PROMPT_ABOVEContent = default;
        private static bool _POSITION_PROMPT_ABOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#POSITION_PROMPT_BELOW"/>
        /// </summary>
        public static int POSITION_PROMPT_BELOW { get { if (!_POSITION_PROMPT_BELOWReady) { _POSITION_PROMPT_BELOWContent = SGetField<int>(LocalBridgeClazz, "POSITION_PROMPT_BELOW"); _POSITION_PROMPT_BELOWReady = true; } return _POSITION_PROMPT_BELOWContent; } }
        private static int _POSITION_PROMPT_BELOWContent = default;
        private static bool _POSITION_PROMPT_BELOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#WRAP_CONTENT"/>
        /// </summary>
        public static int WRAP_CONTENT { get { if (!_WRAP_CONTENTReady) { _WRAP_CONTENTContent = SGetField<int>(LocalBridgeClazz, "WRAP_CONTENT"); _WRAP_CONTENTReady = true; } return _WRAP_CONTENTContent; } }
        private static int _WRAP_CONTENTContent = default;
        private static bool _WRAP_CONTENTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getBackground()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetBackground()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getBackground", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getEpicenterBounds()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public Android.Graphics.Rect GetEpicenterBounds()
        {
            return IExecuteWithSignature<Android.Graphics.Rect>("getEpicenterBounds", "()Landroid/graphics/Rect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getAnchorView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetAnchorView()
        {
            return IExecuteWithSignature<Android.View.View>("getAnchorView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getSelectedView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetSelectedView()
        {
            return IExecuteWithSignature<Android.View.View>("getSelectedView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#createDragToOpenListener(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.View.View.OnTouchListener"/></returns>
        public Android.View.View.OnTouchListener CreateDragToOpenListener(Android.View.View arg0)
        {
            return IExecuteWithSignature<Android.View.View.OnTouchListener>("createDragToOpenListener", "(Landroid/view/View;)Landroid/view/View$OnTouchListener;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#createDragToOpenListener(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.View.View.OnTouchListener"/></returns>
        public Android.View.View.OnTouchListener CreateDragToOpenListenerDirect(Android.View.View arg0)
        {
            return IExecuteWithSignature<Android.View.View.OnTouchListenerDirect, Android.View.View.OnTouchListener>("createDragToOpenListener", "(Landroid/view/View;)Landroid/view/View$OnTouchListener;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getListView()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListView"/></returns>
        public Android.Widget.ListView GetListView()
        {
            return IExecuteWithSignature<Android.Widget.ListView>("getListView", "()Landroid/widget/ListView;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#isInputMethodNotNeeded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInputMethodNotNeeded()
        {
            return IExecuteWithSignature<bool>("isInputMethodNotNeeded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#isModal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsModal()
        {
            return IExecuteWithSignature<bool>("isModal", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#isShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShowing()
        {
            return IExecuteWithSignature<bool>("isShowing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#onKeyDown(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyDown(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecute<bool>("onKeyDown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#onKeyPreIme(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyPreIme(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecute<bool>("onKeyPreIme", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#onKeyUp(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyUp(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecute<bool>("onKeyUp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#performItemClick(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformItemClick(int arg0)
        {
            return IExecuteWithSignature<bool>("performItemClick", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getAnimationStyle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAnimationStyle()
        {
            return IExecuteWithSignature<int>("getAnimationStyle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getHorizontalOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHorizontalOffset()
        {
            return IExecuteWithSignature<int>("getHorizontalOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getInputMethodMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInputMethodMode()
        {
            return IExecuteWithSignature<int>("getInputMethodMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getPromptPosition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPromptPosition()
        {
            return IExecuteWithSignature<int>("getPromptPosition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getSelectedItemPosition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSelectedItemPosition()
        {
            return IExecuteWithSignature<int>("getSelectedItemPosition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getSoftInputMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSoftInputMode()
        {
            return IExecuteWithSignature<int>("getSoftInputMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getVerticalOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVerticalOffset()
        {
            return IExecuteWithSignature<int>("getVerticalOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getSelectedItem()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetSelectedItem()
        {
            return IExecuteWithSignature("getSelectedItem", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#getSelectedItemId()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSelectedItemId()
        {
            return IExecuteWithSignature<long>("getSelectedItemId", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#clearListSelection()"/>
        /// </summary>
        public void ClearListSelection()
        {
            IExecuteWithSignature("clearListSelection", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#dismiss()"/>
        /// </summary>
        public void Dismiss()
        {
            IExecuteWithSignature("dismiss", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#postShow()"/>
        /// </summary>
        public void PostShow()
        {
            IExecuteWithSignature("postShow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setAdapter(android.widget.ListAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ListAdapter"/></param>
        public void SetAdapter(Android.Widget.ListAdapter arg0)
        {
            IExecuteWithSignature("setAdapter", "(Landroid/widget/ListAdapter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setAnchorView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetAnchorView(Android.View.View arg0)
        {
            IExecuteWithSignature("setAnchorView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setAnimationStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetAnimationStyle(int arg0)
        {
            IExecuteWithSignature("setAnimationStyle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setBackgroundDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetBackgroundDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setContentWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetContentWidth(int arg0)
        {
            IExecuteWithSignature("setContentWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setDropDownGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownGravity(int arg0)
        {
            IExecuteWithSignature("setDropDownGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setEpicenterBounds(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void SetEpicenterBounds(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("setEpicenterBounds", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHeight(int arg0)
        {
            IExecuteWithSignature("setHeight", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setHorizontalOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHorizontalOffset(int arg0)
        {
            IExecuteWithSignature("setHorizontalOffset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setInputMethodMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetInputMethodMode(int arg0)
        {
            IExecuteWithSignature("setInputMethodMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setListSelector(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetListSelector(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setListSelector", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setModal(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetModal(bool arg0)
        {
            IExecuteWithSignature("setModal", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setOnDismissListener(android.widget.PopupWindow.OnDismissListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.PopupWindow.OnDismissListener"/></param>
        public void SetOnDismissListener(Android.Widget.PopupWindow.OnDismissListener arg0)
        {
            IExecuteWithSignature("setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setOnItemClickListener(android.widget.AdapterView.OnItemClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.AdapterView.OnItemClickListener"/></param>
        public void SetOnItemClickListener(Android.Widget.AdapterView.OnItemClickListener arg0)
        {
            IExecuteWithSignature("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.AdapterView.OnItemSelectedListener"/></param>
        public void SetOnItemSelectedListener(Android.Widget.AdapterView.OnItemSelectedListener arg0)
        {
            IExecuteWithSignature("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setPromptPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPromptPosition(int arg0)
        {
            IExecuteWithSignature("setPromptPosition", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setPromptView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetPromptView(Android.View.View arg0)
        {
            IExecuteWithSignature("setPromptView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setSelection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSelection(int arg0)
        {
            IExecuteWithSignature("setSelection", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setSoftInputMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSoftInputMode(int arg0)
        {
            IExecuteWithSignature("setSoftInputMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setVerticalOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetVerticalOffset(int arg0)
        {
            IExecuteWithSignature("setVerticalOffset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetWidth(int arg0)
        {
            IExecuteWithSignature("setWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#setWindowLayoutType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetWindowLayoutType(int arg0)
        {
            IExecuteWithSignature("setWindowLayoutType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListPopupWindow.html#show()"/>
        /// </summary>
        public void Show()
        {
            IExecuteWithSignature("show", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}