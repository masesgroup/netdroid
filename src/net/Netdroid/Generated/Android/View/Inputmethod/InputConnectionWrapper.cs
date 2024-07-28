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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Inputmethod
{
    #region InputConnectionWrapper
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
            return IExecute<Android.View.Inputmethod.ExtractedText>("getExtractedText", arg0, arg1);
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
            return IExecute<Android.View.Inputmethod.SurroundingText>("getSurroundingText", arg0, arg1, arg2);
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
            return IExecute<bool>("commitContent", arg0, arg1, arg2);
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
            return IExecute<bool>("commitText", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#commitText(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CommitText(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecute<bool>("commitText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#deleteSurroundingText(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeleteSurroundingText(int arg0, int arg1)
        {
            return IExecute<bool>("deleteSurroundingText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#deleteSurroundingTextInCodePoints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeleteSurroundingTextInCodePoints(int arg0, int arg1)
        {
            return IExecute<bool>("deleteSurroundingTextInCodePoints", arg0, arg1);
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
            return IExecute<bool>("performPrivateCommand", arg0, arg1);
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
            return IExecute<bool>("previewHandwritingGesture", arg0, arg1);
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
            return IExecute<bool>("replaceText", arg0, arg1, arg2, arg3, arg4);
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
            return IExecute<bool>("requestCursorUpdates", arg0, arg1);
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
            return IExecute<bool>("setComposingRegion", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setComposingRegion(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetComposingRegion(int arg0, int arg1)
        {
            return IExecute<bool>("setComposingRegion", arg0, arg1);
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
            return IExecute<bool>("setComposingText", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#setComposingText(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetComposingText(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecute<bool>("setComposingText", arg0, arg1);
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
            return IExecute<bool>("setSelection", arg0, arg1);
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
            return IExecute<Java.Lang.CharSequence>("getTextAfterCursor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#getTextBeforeCursor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTextBeforeCursor(int arg0, int arg1)
        {
            return IExecute<Java.Lang.CharSequence>("getTextBeforeCursor", arg0, arg1);
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
            IExecute("performHandwritingGesture", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputConnectionWrapper.html#requestTextBoundsInfo(android.graphics.RectF,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void RequestTextBoundsInfo(Android.Graphics.RectF arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.View.Inputmethod.TextBoundsInfoResult> arg2)
        {
            IExecute("requestTextBoundsInfo", arg0, arg1, arg2);
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