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

namespace Android.View.Inputmethod
{
    #region InputConnectionWrapper declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html"/>
    /// </summary>
    public partial class InputConnectionWrapper : Android.View.Inputmethod.InputConnection
    {
        const string _bridgeClassName = "android.view.inputmethod.InputConnectionWrapper";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InputConnectionWrapper() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InputConnectionWrapper(params object[] args) : base(args) { }
    
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

    #region InputConnectionWrapper implementation
    public partial class InputConnectionWrapper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#%3Cinit%3E(android.view.inputmethod.InputConnection,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputConnection"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public InputConnectionWrapper(Android.View.Inputmethod.InputConnection arg0, bool arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getHandler()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Handler"/></returns>
        public Android.Os.Handler GetHandler()
        {
            return IExecuteWithSignature<Android.Os.Handler>("getHandler", "()Landroid/os/Handler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getExtractedText(android.view.inputmethod.ExtractedTextRequest,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.ExtractedTextRequest"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Inputmethod.ExtractedText"/></returns>
        public Android.View.Inputmethod.ExtractedText GetExtractedText(Android.View.Inputmethod.ExtractedTextRequest arg0, int arg1)
        {
            return IExecuteWithSignature<Android.View.Inputmethod.ExtractedText>("getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getSurroundingText(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Inputmethod.SurroundingText"/></returns>
        public Android.View.Inputmethod.SurroundingText GetSurroundingText(int arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Android.View.Inputmethod.SurroundingText>("getSurroundingText", "(III)Landroid/view/inputmethod/SurroundingText;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#takeSnapshot()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Inputmethod.TextSnapshot"/></returns>
        public Android.View.Inputmethod.TextSnapshot TakeSnapshot()
        {
            return IExecuteWithSignature<Android.View.Inputmethod.TextSnapshot>("takeSnapshot", "()Landroid/view/inputmethod/TextSnapshot;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#beginBatchEdit()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool BeginBatchEdit()
        {
            return IExecuteWithSignature<bool>("beginBatchEdit", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#clearMetaKeyStates(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ClearMetaKeyStates(int arg0)
        {
            return IExecuteWithSignature<bool>("clearMetaKeyStates", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#commitCompletion(android.view.inputmethod.CompletionInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.CompletionInfo"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CommitCompletion(Android.View.Inputmethod.CompletionInfo arg0)
        {
            return IExecuteWithSignature<bool>("commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#commitContent(android.view.inputmethod.InputContentInfo,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputContentInfo"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CommitContent(Android.View.Inputmethod.InputContentInfo arg0, int arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<bool>("commitContent", "(Landroid/view/inputmethod/InputContentInfo;ILandroid/os/Bundle;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#commitCorrection(android.view.inputmethod.CorrectionInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.CorrectionInfo"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CommitCorrection(Android.View.Inputmethod.CorrectionInfo arg0)
        {
            return IExecuteWithSignature<bool>("commitCorrection", "(Landroid/view/inputmethod/CorrectionInfo;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#commitText(java.lang.CharSequence,int,android.view.inputmethod.TextAttribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.Inputmethod.TextAttribute"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CommitText(Java.Lang.CharSequence arg0, int arg1, Android.View.Inputmethod.TextAttribute arg2)
        {
            return IExecuteWithSignature<bool>("commitText", "(Ljava/lang/CharSequence;ILandroid/view/inputmethod/TextAttribute;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#commitText(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CommitText(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("commitText", "(Ljava/lang/CharSequence;I)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#deleteSurroundingText(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeleteSurroundingText(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("deleteSurroundingText", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#deleteSurroundingTextInCodePoints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeleteSurroundingTextInCodePoints(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("deleteSurroundingTextInCodePoints", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#endBatchEdit()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool EndBatchEdit()
        {
            return IExecuteWithSignature<bool>("endBatchEdit", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#finishComposingText()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool FinishComposingText()
        {
            return IExecuteWithSignature<bool>("finishComposingText", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#performContextMenuAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformContextMenuAction(int arg0)
        {
            return IExecuteWithSignature<bool>("performContextMenuAction", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#performEditorAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformEditorAction(int arg0)
        {
            return IExecuteWithSignature<bool>("performEditorAction", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#performPrivateCommand(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformPrivateCommand(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            return IExecuteWithSignature<bool>("performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#performSpellCheck()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool PerformSpellCheck()
        {
            return IExecuteWithSignature<bool>("performSpellCheck", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#previewHandwritingGesture(android.view.inputmethod.PreviewableHandwritingGesture,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.PreviewableHandwritingGesture"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreviewHandwritingGesture(Android.View.Inputmethod.PreviewableHandwritingGesture arg0, Android.Os.CancellationSignal arg1)
        {
            return IExecuteWithSignature<bool>("previewHandwritingGesture", "(Landroid/view/inputmethod/PreviewableHandwritingGesture;Landroid/os/CancellationSignal;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#replaceText(int,int,java.lang.CharSequence,int,android.view.inputmethod.TextAttribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.View.Inputmethod.TextAttribute"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ReplaceText(int arg0, int arg1, Java.Lang.CharSequence arg2, int arg3, Android.View.Inputmethod.TextAttribute arg4)
        {
            return IExecuteWithSignature<bool>("replaceText", "(IILjava/lang/CharSequence;ILandroid/view/inputmethod/TextAttribute;)Z", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#reportFullscreenMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ReportFullscreenMode(bool arg0)
        {
            return IExecuteWithSignature<bool>("reportFullscreenMode", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#requestCursorUpdates(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestCursorUpdates(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("requestCursorUpdates", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#requestCursorUpdates(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestCursorUpdates(int arg0)
        {
            return IExecuteWithSignature<bool>("requestCursorUpdates", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#sendKeyEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendKeyEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("sendKeyEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setComposingRegion(int,int,android.view.inputmethod.TextAttribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.Inputmethod.TextAttribute"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetComposingRegion(int arg0, int arg1, Android.View.Inputmethod.TextAttribute arg2)
        {
            return IExecuteWithSignature<bool>("setComposingRegion", "(IILandroid/view/inputmethod/TextAttribute;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setComposingRegion(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetComposingRegion(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("setComposingRegion", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setComposingText(java.lang.CharSequence,int,android.view.inputmethod.TextAttribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.Inputmethod.TextAttribute"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetComposingText(Java.Lang.CharSequence arg0, int arg1, Android.View.Inputmethod.TextAttribute arg2)
        {
            return IExecuteWithSignature<bool>("setComposingText", "(Ljava/lang/CharSequence;ILandroid/view/inputmethod/TextAttribute;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setComposingText(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetComposingText(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("setComposingText", "(Ljava/lang/CharSequence;I)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setImeConsumesInput(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetImeConsumesInput(bool arg0)
        {
            return IExecuteWithSignature<bool>("setImeConsumesInput", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setSelection(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetSelection(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("setSelection", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getCursorCapsMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetCursorCapsMode(int arg0)
        {
            return IExecuteWithSignature<int>("getCursorCapsMode", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getSelectedText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetSelectedText(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSelectedText", "(I)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getTextAfterCursor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTextAfterCursor(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTextAfterCursor", "(II)Ljava/lang/CharSequence;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getTextBeforeCursor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTextBeforeCursor(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#closeConnection()"/>
        /// </summary>
        public void CloseConnection()
        {
            IExecuteWithSignature("closeConnection", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#performHandwritingGesture(android.view.inputmethod.HandwritingGesture,java.util.concurrent.Executor,java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.HandwritingGesture"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntConsumer"/></param>
        public void PerformHandwritingGesture(Android.View.Inputmethod.HandwritingGesture arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.IntConsumer arg2)
        {
            IExecuteWithSignature("performHandwritingGesture", "(Landroid/view/inputmethod/HandwritingGesture;Ljava/util/concurrent/Executor;Ljava/util/function/IntConsumer;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#requestTextBoundsInfo(android.graphics.RectF,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void RequestTextBoundsInfo(Android.Graphics.RectF arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.View.Inputmethod.TextBoundsInfoResult> arg2)
        {
            IExecuteWithSignature("requestTextBoundsInfo", "(Landroid/graphics/RectF;Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setTarget(android.view.inputmethod.InputConnection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputConnection"/></param>
        public void SetTarget(Android.View.Inputmethod.InputConnection arg0)
        {
            IExecuteWithSignature("setTarget", "(Landroid/view/inputmethod/InputConnection;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}